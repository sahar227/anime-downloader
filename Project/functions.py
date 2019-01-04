import os
from requests import get

def downloadAndOpen(url, file_name):
    print("        downloading " + file_name + " - " + url)
    response = get(url)
    print("test")
    retries = 0
    while response.status_code != 200:
        response = get(url)
        print("retry number" + ++retries)
    with open(file_name, "wb") as file:
        # write to file
        file.write(response.content)
        # Open file
        os.startfile(file_name)

#downloadAndOpen("https://nyaa.si/view/1107218/torrent", "Boogiepop wa Warawanai (2019)01.torrent")