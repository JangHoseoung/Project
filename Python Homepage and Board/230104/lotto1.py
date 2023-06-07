import requests
from bs4 import BeautifulSoup

url ="https://dhlottery.co.kr/gameResult.do?method=byWin&drwNo="

req = requests.get(url)

req.encoding="euc-kr"

bs = BeautifulSoup(req.text,"html.parser")

turn =bs.select("#article > div:nth-child(2) > div > div.win_result > h4 > strong") #회차
numbers= bs.select("#article > div:nth-child(2) > div > div.win_result > div > div.num.win > p > span") #번호
bonus= bs.select("#article > div:nth-child(2) > div > div.win_result > div > div.num.bonus > p > span") #보너스 번호
potmoney = bs.select("#article > div:nth-child(2) > div > table > tbody > tr:nth-child(1) > td:nth-child(4)") #당첨금

turn1 = turn[0].text;
numbers1 = numbers[0].text;
numbers2 = numbers[1].text;
numbers3 = numbers[2].text;
numbers4 = numbers[3].text;
numbers5 = numbers[4].text;
numbers6 = numbers[5].text;
numbersAll = [numbers1,numbers2,numbers3,numbers4,numbers5,numbers6];
bonus1 = bonus[0].text;
potmoney1 = potmoney[0].text;
