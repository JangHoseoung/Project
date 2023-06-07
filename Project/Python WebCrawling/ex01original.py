from selenium import webdriver
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


text = ""
img = html.find_all('div',{'class','pension_table','pension_box1 pension_box'})
for item in img:
    temp = re.sub('\n\n\n',"",item.text)
    # print(temp)
    text += temp




# wb = Workbook()
# ws = wb.active



# ws.append(["노령연금"])
# ws.append(["10년","15년","20년","25년","30년","35년","40년"])
# ws.append([text[6],text[8],text[11],text[14],text[17],text[20],numbers])

# wb.save('yungum.xlsx')
# wb.close




# years10 = html.find('div',{'class','pension_table th1_1 dd'})
# print(years10) #안됨...



