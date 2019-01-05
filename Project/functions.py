import datetime
import os
from requests import get

# Global variables
OriginDirName = os.path.dirname(__file__)
DownloadLogsDirName = OriginDirName + '/downloadLogs/'
TorrentsDirName = OriginDirName + '/torrents/'
animeFile = open("C:\\Users\\Sahar\\Documents\\Projects\\visual studio 2017\\AnimeDL GUI\\AnimeDL GUI\\bin\\Debug\\animeList.txt","r")
date = time = datetime.datetime.today().strftime('%d-%m-%Y')

def downloadAndOpen(url, file_name):
    logFile = open(DownloadLogsDirName + date + '.txt', "a+")
    print("        downloading " + file_name + " - " + url)
    try:
        response = get(url)
    except:
        print("Failed to download, retrying")
        downloadAndOpen(url, file_name)
        return False

    with open(TorrentsDirName + file_name, "wb") as file:
        # write to file
        file.write(response.content)
        print("        downloaded successfully")
        logFile.write(file_name + "\n")
        # Open file
        os.startfile(TorrentsDirName + file_name)
        print("opened")
    logFile.close()

# Checks if logs already registered this episode
##### TODO: in the future, should be used on Json file!
def HasDownloaded(episodeName):
    try:
        logFile = open(OriginDirName + '/downloadLogs/' + date + '.txt', "r")
    except:# file doesn't exist
        return False
    for line in logFile:
        if episodeName in line:
            logFile.close()
            print("file " + episodeName + " already downloaded")
            return True
    logFile.close()
    return False

#downloadAndOpen("https://nyaa.si/view/1107218/torrent", "Boogiepop wa Warawanai (2019)01.torrent")
