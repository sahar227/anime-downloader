import os
import datetime
import json
from selenium.webdriver.chrome.options import Options
from selenium import webdriver


#settings
LogsDirName = "downloadLogs"
TorrentsDirName = "torrents"

# Web driver configuration
chrome_options = Options()
chrome_options.add_argument("--headless")

#WebScrape hard-coded values
URL = "https://horriblesubs.info"
AllEpisodeContainerClass = "hs-shows"
SingleEpisodeContainerClass = "rls-info-container"
EpisodeNumberTag = "strong"
ReleaseDateClass = "rls-date"
QualityOptionsClass = "rls-link"
DownloadMirrorsClass = "dl-type"
torrentIndex = 0 # use magnet link
QualityDictionary = {"480p" : 0, "720p" : 1, "1080p" : 2}


# Initialize constants
OriginDirPath = os.path.dirname(__file__)
LogsDirPath = OriginDirPath + '/' + LogsDirName + '/'
TorrentsDirPath = OriginDirPath + '/' + TorrentsDirName + '/'
date = datetime.datetime.today().strftime('%d-%m-%Y')

# open files
# temporary hard-coded path. Needs to change to relative path!
try:
    configurationFile = open("C:\\Users\\Sahar\\Documents\\Projects\\anime-downloader\\AnimeDL GUI\\AnimeDL GUI\\bin\\Debug\\configuration.json", "r")

except:# configuration file does not exist
    print("Please use anime-downloader GUI to setup the program")
    exit()
try:
    logFile = open(LogsDirPath + date + '.txt', "r")
except:
    print("No episode was downloaded yet today")
    logFile = None
driver = webdriver.Chrome(chrome_options=chrome_options)

configuration = json.load(configurationFile)
animeList = configuration["animeList"]
quality = configuration["quality"]

def CloseFiles():
    configurationFile.close()
    driver.close()
    if(logFile != None):
        logFile.close()
