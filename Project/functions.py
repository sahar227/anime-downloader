import datetime
import os
from requests import get

dirname = os.path.dirname(__file__)
date = time = datetime.datetime.today().strftime('%d-%m-%Y')
def downloadAndOpen(url, file_name):
    f = open(dirname + '/downloadLogs/' + date + '.txt', "a+")
    print("        downloading " + file_name + " - " + url)
    response = get(url)
    retries = 0
    while response.status_code != 200:
        response = get(url)
        print("retry number" + ++retries)
    with open(dirname + "/torrents/" + file_name, "wb") as file:
        # write to file
        file.write(response.content)
        print("        downloaded successfully")
        f.write(file_name)
        # Open file
        os.startfile(file_name)
    f.close()

#downloadAndOpen("https://nyaa.si/view/1107218/torrent", "Boogiepop wa Warawanai (2019)01.torrent")
