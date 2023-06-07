import pymysql
host='127.0.0.1'
port=3306
user='root'
password='root123'
dbname='hsJang'
charset='utf8'

def selectRow(idx):
    db = pymysql.connect(host=host,port=port,
        user=user,password=password,
        db=dbname,charset=charset
    ) 
    sql = f'select * from freeboard where idx= {idx}'
    cursor = db.cursor()
    cursor.execute(sql)
    res = cursor.fetchone()
    db.close()
    return res

def select(page):
    db = pymysql.connect(host=host,port=port,
        user=user,password=password,
        db=dbname,charset=charset
    )
    startrow = (page-1)*3
    #1페이지면 startrow 가 0
    #2페이지면 startrow 가 3
    #3페이지면 startrow 가 6 
    sql = f'select * from freeboard order by idx desc limit {startrow},5' #5문단씩 끊어줌
    cursor = db.cursor()
    cursor.execute(sql)
    res = cursor.fetchall()
    db.close()
    return res

def insert(title,content,writer):
    db = pymysql.connect(host=host,port=port,
        user=user,password=password,
        db=dbname,charset=charset
    )
    sql = f"""INSERT INTO freeboard
            (title,content,writer,regdate)
            VALUES
            ('{title}','{content}','{writer}',NOW())"""
    cursor = db.cursor()
    cursor.execute(sql)
    db.commit()
    db.close()

def delete(idx):
    db = pymysql.connect(host=host,port=port,
        user=user,password=password,
        db=dbname,charset=charset
    )
    sql = f"""DELETE FROM freeboard
            WHERE idx={idx}"""
    cursor = db.cursor()
    cursor.execute(sql)
    db.commit()
    db.close()  

def update(title,content,writer,idx):
    db = pymysql.connect(host=host,port=port,
        user=user,password=password,
        db=dbname,charset=charset
    )
    sql = f"""UPDATE freeboard
        SET title = '{title}',
	    content = '{content}',
	    writer = '{writer}'
	    WHERE idx = {idx};"""
    cursor = db.cursor()
    cursor.execute(sql)
    db.commit()
    db.close()

def selectPageCntRowCnt():
    db = pymysql.connect(host=host,port=port,
        user=user,password=password,
        db=dbname,charset=charset
    )
    sql = f'SELECT COUNT(idx) FROM freeboard;' 
    cursor = db.cursor()
    cursor.execute(sql)
    res = cursor.fetchone()
    print(res[0])
    RowCnt = res[0]
    pageCnt = int(RowCnt/ 3) #소수점 삭제
    pageCnt = pageCnt if RowCnt%3==0 else pageCnt+1
    print(pageCnt,RowCnt)
    db.close()
    return pageCnt,RowCnt
