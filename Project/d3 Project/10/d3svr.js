/*
npm init
npm i express
npm i cors
npm i oracledb
*/


var port =3000;
const _express = require('express')
const _app = _express();

//주소창에 값을 입력만 받고  fetch등 자바스크립트로 요청했을때는
//에러가 발생하는데
//자바스크립트 요청에도 응답하게 해주는 코드
var _cors = require('cors')  
_app.use(_cors())


_app.get('/', function(req,res){
  res.send('Hello World')
});

_app.get('/dog', function(req,res){
  res.json({'sound':'멍멍'})
})

_app.get('/cat', function(req, res){
  res.json({'sound':'야옹'})
})

//파람(param)사용하는 방법
_app.get('/animal/:id',function(req,res){
  const q = req.params;
  console.log(q);
  if(q.id == 'pig') {
    res.json({'id':q.id,'sound':'꿀꿀'})

  } else if(q.id == 'duck') {
    res.json({'id':q.id,'sound':'꽥꽥'})

  } else if(q.id == 'cat') {
    res.json({'id':q.id,'sound':'야용'})

  } else {
    res.json({'id':q.id,'sound':'모름'})
  }
})

//쿼리를 사용하는 방법
//http://localhost:3000/user/query?name=kim&age=100

_app.get('/user/:query', function(req,res){
  const _q = req.query;
  _name = _q.name;
  _age  = _q.age;
  _birthday = _q.birthday;

  res.json({'이름':_name,'나이':_age,'생일':_birthday})
})



_app.listen(port,()=>{
  console.log(`D3SVR listening on ${port} port`)
})