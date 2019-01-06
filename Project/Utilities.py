import os
from bs4 import BeautifulSoup
from requests import get
import Constants as consts

# finds the page with links to all existing anime shows
def getIndexPage():
    showsPage = get(consts.URL + "/shows/")
    ####### TODO: implement recovery mechanism
    print("entered shows page!")
    return BeautifulSoup(showsPage.content, "html.parser")

# downloads and opens file
def downloadAndOpen(url, file_name):
    print("        downloading " + file_name + " - " + url)
    try:
        response = get(url)
    except:
        print("Failed to download, retrying")
        downloadAndOpen(url, file_name)
        return False

    with open(consts.TorrentsDirPath + file_name, "wb") as file:
        # write to file
        file.write(response.content)
        print("        downloaded successfully")
        logFile = open(consts.LogsDirPath + consts.date + '.txt', "a+")
        logFile.write(file_name + "\n")
        # Open file
        os.startfile(consts.TorrentsDirPath + file_name)
        print("opened")
    logFile.close()

# Checks if logs already registered this episode
##### TODO: in the future, should be used on Json file!
def HasDownloaded(episodeName):
    if(consts.logFile != None):
        for line in consts.logFile:
            if episodeName in line:
                print("file " + episodeName + " already downloaded")
                return True
    return False
