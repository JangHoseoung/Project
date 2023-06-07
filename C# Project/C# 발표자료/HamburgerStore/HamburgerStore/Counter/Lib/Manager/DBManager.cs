using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public string MakeToClobQuery(string aSrc) {
            return MakeToClobQuery(aSrc, 4000);
        }
        public string MakeToClobQuery(string aSrc, int aBlock) {
            string _result = "";
            if (aSrc == null) {
                _result = "''";
            } else { 
                int _len = aSrc.Length;
                int _count = (_len + 1) / aBlock;
                for(int _idx = 0; _idx< _count; _idx++)
                {
                    if(_result.Length > 0) { _result += "||"; }
                    int _start = _idx * aBlock;
                    int _size = _len - _start;
                    if(_size> aBlock) {  _size = aBlock;}
                    _result += string.Format(" TO_CLOB('{0}') "
                        , aSrc.Substring(_start, _size));

                }
            }
            return _result;                             
        }

        public int ModifyMember(int _mbr_ucode, string _mbr_name, string _mbr_sex
                                , string _mbr_tel, string _mbr_birthday
                                , string _mbr_regdate, string _mbr_picture)
        {
            int _code = 0;
            DbConnection _Connection = m_OracleManager.NewConnection();
            if(_Connection == null) {
                _code = -999;
            } else
            {
                //회원수정 쿼리문 만들기

                string _strQuery = "UPDATE kb_member SET ";
                _strQuery += string.Format("mbr_name = '{0}', ",_mbr_name);
                _strQuery += string.Format("mbr_sex  = '{0}', ",_mbr_sex);
                _strQuery += string.Format("mbr_tel  = '{0}', ",_mbr_tel);
                _strQuery += string.Format("mbr_birthday = '{0}', ",_mbr_birthday);
                _strQuery += string.Format("mbr_regdate  = '{0}', ",_mbr_regdate);
                _strQuery += string.Format("mbr_picture  = {0}  ",_mbr_picture);

                _strQuery += string.Format("WHERE mbr_ucode = {0}", _mbr_ucode);

                _code = m_OracleManager.ExcuteQuery(_strQuery);   
            }

            return _code;
        }




    }
}
