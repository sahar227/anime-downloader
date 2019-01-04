from bs4 import BeautifulSoup
import requests
from selenium import webdriver
from selenium.webdriver.chrome.options import Options
import time
import urllib.request
import shutil


animeFile = open("C:\\Users\\Sahar\\Documents\\Projects\\visual studio 2017\\AnimeDL GUI\\AnimeDL GUI\\bin\\Debug\\animeList.txt","r")


chrome_options = Options()
chrome_options.add_argument("--headless")
driver = webdriver.Chrome(chrome_options=chrome_options)

URL = "https://horriblesubs.info"
showsPage = requests.get(URL + "/shows/")
####### TODO: implement recovery mechanism
if showsPage.status_code != 200:
    exit(0)
showsPageSoup = BeautifulSoup(showsPage.content, "html.parser")
for anime in animeFile:
    for link in showsPageSoup.find_all("a", title=anime.replace("\n", "")):
        animePage = requests.get(URL + link.get('href'))
        ####### TODO: implement recovery mechanism
        if animePage.status_code != 200:
            exit(0)
        driver.get(URL + link.get('href'))
        time.sleep(5)
        print("got site")####################################################################deleteME
        p_element = driver.find_element_by_class_name("hs-shows")
        for element in p_element.find_elements_by_class_name("rls-info-container"):
            if element.find_element_by_class_name("rls-date").text == "12/29/18":#remember to change date to "Today"
                print("im in")
                element.find_element_by_class_name("rls-date").click()
                time.sleep(5)
                url = element.find_elements_by_class_name("rls-link")[2].find_elements_by_class_name("dl-type")[1].find_element_by_tag_name("a").get_attribute("href")
