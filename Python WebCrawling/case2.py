from bs4 import BeautifulSoup
import requests
from bs4 import BeautifulSoup
from openpyxl import Workbook
import re

url  = 'https://www.nps.or.kr/jsppage/app/etc/simpleExpect.jsp?yyyy=2022&status=cal&max=471600&min=29700&insu=90000&inquiry=%BF%B9%BB%F3%BF%AC%B1%DD%BE%D7+%C1%B6%C8%B8%C7%CF%B1%E2'
req = requests.get(url)
req.encoding = "utf-8"

html = BeautifulSoup(req.content,"html.parser")


text = ""
img = html.find_all('div',{'class','pension_table'})
for item in img:
    temp = re.sub('\n\n\n',"",item.text)
    print(temp)
    text += temp
    print(text[3]) #왜 갑자기 단어 1개씩??
    atemp = list(temp) #list형 변환해서 확인
    print(atemp) #????


