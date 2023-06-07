from flask import Flask, render_template,request
import dusrma as ds
import lotto1 as lt
from components import freeboard

#python ex01.py로 실행 주소 컨트롤 클릭

app = Flask(__name__)


app.register_blueprint(freeboard.app)

@app.route("/")
def hello():
    return render_template('main.html')


@app.route("/dusrma",methods=['POST','GET'])
def dusrma():
    insu = 330000 #초기값으로 초기화
    if request.method == 'POST': #폼태그 형식이 post
        insu = request.form['won'] #input type에 name이 won
    result = ds.dusrma(insu)
    return render_template("dusrma.html",result=result)

@app.route("/freeboard")
def freeboard():
    return render_template("freeboard/select.html")

@app.route("/Lotto")
def Lotto():
    turn = lt.turn1
    number = lt.numbersAll
    bonus = lt.bonus1
    potmoney = lt.potmoney1
    return render_template("lotto.html",turn=turn,number=number,bonus=bonus,potmoney=potmoney)

if __name__=='__main__':
    app.run(debug=True)