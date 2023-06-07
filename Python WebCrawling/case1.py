from bs4 import BeautifulSoup
import requests
from bs4 import BeautifulSoup
from openpyxl import Workbook
import re

inputvalue = '납입보험료 입력'

url  = 'https://www.nps.or.kr/jsppage/app/etc/simpleExpect.jsp?yyyy=2022&status=cal&max=471600&min=29700&insu=90000&inquiry=%BF%B9%BB%F3%BF%AC%B1%DD%BE%D7+%C1%B6%C8%B8%C7%CF%B1%E2'
req = requests.get(url)
req.encoding = "utf-8"

html = BeautifulSoup(req.content,"html.parser")
div = html.find('div',{'class','pension_table'}) #소득기준 100만원에 9만원납부 연금계산

years10 = div.select('.th1_1>span') #노령연금
print(years10)
years10value = div.select('dd>span') 
print(years10value)

years10 = html.find('div',{'class','pension_table th1_1 dd'})
print(years10)  #none으로 나옴...

#years10 변수에 할당된 값이 None으로 출력될 수 있는 이유는 아래와 같습니다.

#웹 페이지의 HTML 소스 코드에 div 태그 중 class 속성이 "pension_table th1_1 dd"인 태그가 존재하지 않기 때문일 수 있습니다. 그런 경우, html.find() 메서드는 일치하는 태그가 없으므로 None을 반환합니다.

#div 변수에 할당된 값이 None일 수 있습니다. 이는 웹 페이지의 HTML 소스 코드에 div 태그 중 class 속성이 "pension_table"인 태그가 존재하지 않거나, 그 태그가 여러 개 있기 때문일 수 있습니다. 이 경우, html.find() 메서드는 일치하는 태그가 없어서