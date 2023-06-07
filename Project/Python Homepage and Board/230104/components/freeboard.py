from flask import Blueprint,render_template,request,redirect
import dusrma as ds
from components.db import freeboardmanage

app = Blueprint('freeboard',__name__,url_prefix='/freeboard')


@app.route("/updateform")
def updateform():
    idx = request.args.get('idx')
    res = freeboardmanage.selectRow(idx)
    return render_template('freeboard/update.html',res=res)

@app.route("updateproc",methods=['POST'])
def updateproc():
    title = request.form['title']
    content = request.form['content']
    writer = request.form['writer']
    idx = request.form['idx']
    freeboardmanage.update(title,content,writer,idx)
    return redirect('/freeboard')

@app.route("/")
def select():
    page = request.args.get('page')
    page = 1 if page is None else page 
    res = freeboardmanage.select(int(page))
    pageCnt,RowCnt = freeboardmanage.selectPageCntRowCnt()
    return render_template('freeboard/select.html',res=res,pageCnt=pageCnt,RowCnt=RowCnt,curPage=page)
    #select 를 주소를 요청을 하면 주소줄안에 page라는 파라메타가 있는데 그 번호에 따라서 select(page) select * from freeboard limit 0,3 행갯수를 구하는 selectpageCntRowcnt() select.html로 보냄

@app.route("/dusrma",methods=['POST','GET'])
def dusrma():
    insu = 330000 #초기값으로 초기화
    if request.method == 'POST': #폼태그 형식이 post
        insu = request.form['won'] #input type에 name이 won
    result = ds.dusrma(insu)
    return render_template("dusrma.html",result=result)

@app.route("/insert")
def insert():
    return render_template("freeboard/insert.html")

@app.route("insertproc",methods=['POST'])
def insertproc():
    title = request.form['title']
    content = request.form['content']
    writer = request.form['writer']
    freeboardmanage.insert(title,content,writer)
    return redirect('/freeboard')

@app.route("delete")
def delete():
    idx = int(request.args.get('idx'))
    freeboardmanage.delete(idx)
    return redirect('/freeboard')

@app.route("view")
def view():
    idx = int(request.args.get('idx'))
    res = freeboardmanage.selectRow(idx)
    return render_template("freeboard/view.html",res=res)
