using System;
using System.Data;
using System.Data.Common;

namespace Lib.Manager
{
    class DBManager
    {
        private OracleManager m_OracleManager;

        public void SetConnectInfo(string aAddr, int aPort, string aId, string aPwd, string aDataBase)
        {
            m_OracleManager = new OracleManager(aAddr, aPort, aId, aPwd, aDataBase);
        }

        //4000자 이상 문자열 ToClob으로 처리하기
        public string MakeToClobQuery(string aSrc)
        {
            return MakeToClobQuery(aSrc, 4000);
        }
        public string MakeToClobQuery(string aSrc, int aBlock)
        {
            string _result = "";
            if (aSrc == null)
            {
                _result = "''";
            }
            else
            {
                int _len = aSrc.Length;
                int _count = (_len + 1) / aBlock;
                for (int _idx = 0; _idx < _count; _idx++)
                {
                    if (_result.Length > 0) { _result += "||"; }
                    int _start = _idx * aBlock;
                    int _size = _len - _start;
                    if (_size > aBlock) { _size = aBlock; }
                    _result += string.Format(" TO_CLOB('{0}') "
                        , aSrc.Substring(_start, _size));

                }
            }
            return _result;
        }
        //대기표 1번씩 늘리기
        public int ReadSeq(string aSeqName)
        {
            int _result = -1;
            DataTable _dt = null;
            DbConnection _Connection = m_OracleManager.NewConnection();
            if (_Connection == null)
            {
                return _result;
            }
            else
            {
                //쿼리문 만들기
                string _strQuery = string.Format("SELECT  {0}.nextval FROM DUAL ", aSeqName);
                _dt = m_OracleManager.SelectQuery(_Connection, _strQuery, "contact");
                if (_dt != null && _dt.Rows.Count > 0)
                {
                    _result = Convert.ToInt32(_dt.Rows[0][0]);
                }
            }
            return _result;
        }

        //상품관리 -------------------------------------------------------------
        public DataTable ReadGoods(int _category, string _name)
        {
            DataTable _dt = null;

            DbConnection _Connection = m_OracleManager.NewConnection();
            if (_Connection == null)
            {
                return null;
            }
            else
            {
                //회원수정 쿼리문 만들기
                string _strQuery = "SELECT goods_number, goods_name, goods_price, goods_description, ";
                _strQuery += "goods_regdate, goods_moddate, goods_picture, mbr_regnumber, ";
                _strQuery += "mbr_modnumber, ctr_typenumber ";
                _strQuery += "FROM jhs_goods ";

                string _whereQuery = "";
                if (_category > 0)
                {
                    if (_whereQuery.Length > 0)
                    {
                        _whereQuery += " AND ";
                    }
                    else
                    {
                        _whereQuery = " WHERE ";
                    }
                    _whereQuery += String.Format(" ctr_typenumber = {0}", _category);
                }

                if (_name.Length > 0)
                {
                    if (_whereQuery.Length > 0)
                    {
                        _whereQuery += " AND ";
                    }
                    else
                    {
                        _whereQuery = " WHERE ";
                    }
                    _whereQuery += String.Format(" goods_name like '%{0}%' ", _name);
                }
                _strQuery += _whereQuery;
                _dt = m_OracleManager.SelectQuery(_Connection, _strQuery, "goods");
            }
            return _dt;
        }
        public int SaveProduct(int _category, string _name, int _price, string _description, string _goods_picture)
        {
            int _code = 0;
            DbConnection _Connection = m_OracleManager.NewConnection();
            if (_Connection == null)
            {
                _code = -999;
            }
            else
            {
                //쿼리문 만들기
                if (_goods_picture.Length > 0)
                {
                    _goods_picture = MakeToClobQuery(_goods_picture);
                }

                string _strQuery = "INSERT INTO jhs_goods(goods_number,goods_name,goods_price,goods_description,goods_regdate,goods_picture,ctr_typenumber) ";
                _strQuery += string.Format("VALUES(SEQ_JHS_GOODS.nextval, '{0}',{1},'{2}',SYSDATE,{3},'{4}') ", _name, _price, _description, _goods_picture, _category);

                try
                {
                    _code = m_OracleManager.ExcuteQuery(_strQuery);
                }
                catch (DbException ex)
                {
                    // 쿼리 실행 도중 오류가 발생한 경우 이곳으로 예외가 전달
                    Console.WriteLine("오류 발생: " + ex.Message);
                    _code = -1;
                }
            }
            return _code;
        }


        public int DeleteProduct(int _goods_number)
        {
            int _code = 0;
            DbConnection _Connection = m_OracleManager.NewConnection();
            if (_Connection == null)
            {
                _code = -999;
            }
            else
            {

                string _strQuery = string.Format("DELETE FROM jhs_goods WHERE goods_number = '{0}'", _goods_number);
                _code = m_OracleManager.ExcuteQuery(_strQuery);
            }
            return _code;
        }

        public int ModifyProduct(int _goods_number, int _category, string _name, int _price, string _description, string _goods_picture)
        {
            int _code = 0;
            DbConnection _Connection = m_OracleManager.NewConnection();
            if (_Connection == null)
            {
                _code = -999;
            }
            else
            {
                //회원수정 쿼리문 만들기
                if (_goods_picture.Length > 0)
                {
                    _goods_picture = MakeToClobQuery(_goods_picture);
                }

                string _strQuery = "UPDATE jhs_goods SET ";
                _strQuery += string.Format(" goods_name = '{0}', goods_price = {1}," +
                    " goods_description = '{2}',goods_moddate = SYSDATE,goods_picture = {3}," +
                    " ctr_typenumber = {4} where goods_number = '{5}' ", _name, _price, _description, _goods_picture, _category, _goods_number);
                _code = m_OracleManager.ExcuteQuery(_strQuery);
            }

            return _code;
        }

        public int AddOrderList(int _ol_number, int _ol_watingnumber,
            int _ol_payment, string _ol_paymenttype, int _ol_processstatus)
        {
            int _code = 0;
            DbConnection _Connection = m_OracleManager.NewConnection();
            if (_Connection == null)
            {
                _code = -999;
            }
            else
            {

                string _strQuery = "INSERT INTO jhs_order(ol_number,ol_date,ol_watingnumber,ol_payment,ol_paymenttype,ol_processstatus) ";
                _strQuery += string.Format("VALUES({0},SYSDATE,{1},{2},'{3}',{4}) "
                    , _ol_number, _ol_watingnumber, _ol_payment, _ol_paymenttype, _ol_processstatus);

                try
                {
                    _code = m_OracleManager.ExcuteQuery(_strQuery);
                }
                catch (DbException ex)
                {
                    // 쿼리 실행 도중 오류가 발생한 경우 이곳으로 예외가 전달됩니다.
                    Console.WriteLine("오류 발생: " + ex.Message);
                    _code = -1;
                }
            }
            return _code;
        }
        public int AddOrderDetail(int _od_quantity, int _od_price, int _ol_number, int _goods_number, string _goods_name)
        {
            int _code = 0;
            DbConnection _Connection = m_OracleManager.NewConnection();
            if (_Connection == null)
            {
                _code = -999;
            }
            else
            {
                string _strQuery = "INSERT INTO jhs_orderdetail ( od_number, od_quantity, od_price, ol_number, goods_number, goods_name,od_date ) ";
                _strQuery += string.Format("VALUES(seq_order_detail.nextval,{0},{1},{2},{3},'{4}',SYSDATE) "
                        , _od_quantity, _od_price, _ol_number, _goods_number, _goods_name);
                try
                {
                    _code = m_OracleManager.ExcuteQuery(_strQuery);
                }
                catch (DbException ex)
                {
                    // 쿼리 실행 도중 오류가 발생한 경우 이곳으로 예외가 전달됩니다.
                    Console.WriteLine("오류 발생: " + ex.Message);
                    _code = -1;
                }
            }
            return _code;
        }
    }
}
