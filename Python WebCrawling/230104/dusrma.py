from bs4 import BeautifulSoup
import requests

def dusrma(insu):
    url  = f'https://www.nps.or.kr/jsppage/app/etc/simpleExpect.jsp?yyyy=2022&status=cal&max=471600&min=29700&insu={insu}&inquiry=%BF%B9%BB%F3%BF%AC%B1%DD%BE%D7+%C1%B6%C8%B8%C7%CF%B1%E2'
    req = requests.get(url)
    req.encoding = "utf-8"
    html = BeautifulSoup(req.content,"html.parser")
    
    data_1 = html.select("span.data")

    years10 = data_1[0].string
    years15 = data_1[1].string
    years20 = data_1[2].string
    years25 = data_1[3].string
    years30 = data_1[4].string
    years35 = data_1[5].string
    years40 = data_1[6].string
    b = [years10,years15,years20,years25,years30,years35,years40]
    return b
    #get_text도 가능