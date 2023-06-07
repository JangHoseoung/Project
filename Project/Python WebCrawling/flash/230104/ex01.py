from flask import Flask, render_template,request
import dusrma as ds

app = Flask(__name__)

@app.route("/")
def hello():
    return render_template('hello.html')


@app.route("/dusrma",methods=['POST','GET'])
def dusrma():
    insu = 33000 #초기값으로 초기화
    if request.method == 'POST': #폼태그 형식이 post
        insu = request.form['won'] 
    result = ds.dusrma(insu)
    return render_template("dusrma.html",result=result)

if __name__=='__main__':
    app.run(debug=True)