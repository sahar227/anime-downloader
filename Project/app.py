from bs4 import BeautifulSoup
import requests
from selenium import webdriver
from selenium.webdriver.chrome.options import Options
import time
import functions as functions

animeFile = open("C:\\Users\\Sahar\\Documents\\Projects\\visual studio 2017\\AnimeDL GUI\\AnimeDL GUI\\bin\\Debug\\animeList.txt","r")

# Web driver configuration
chrome_options = Options()
chrome_options.add_argument("--headless")
driver = webdriver.Chrome(chrome_options=chrome_options)

URL = "https://horriblesubs.info"
showsPage = requests.get(URL + "/shows/")
####### TODO: implement recovery mechanism
if showsPage.status_code != 200:
    exit(0)
#######
print("entered shows page!")
showsPageSoup = BeautifulSoup(showsPage.content, "html.parser")
for anime in animeFile:
    animeName = anime.replace("\n", "")
    print("Scanning " + animeName + ":")
    link = showsPageSoup.find("a", title= animeName)

    ####### TODO: implement recovery mechanism
    driver.get(URL + link.get('href'))
    ######
    time.sleep(5)
    print("    got " + animeName + " site")####################################################################deleteME
    p_element = driver.find_element_by_class_name("hs-shows")
    for element in p_element.find_elements_by_class_name("rls-info-container"):
        # download episodes that were uploaded today
        if element.find_element_by_class_name("rls-date").text == "Today":
            element.find_element_by_class_name("rls-date").click()
            time.sleep(5)
            url = element.find_elements_by_class_name("rls-link")[2].find_elements_by_class_name("dl-type")[1].find_element_by_tag_name("a").get_attribute("href")
            fileName = animeName + element.find_element_by_tag_name("strong").text + ".torrent" #anime name + number
            functions.downloadAndOpen(url, fileName)
        else:
            break
