import os
from requests import get

def downloadAndOpen(url, file_name):
    response = get(url)
    retries = 0
    while response.status_code != 200:
        response = get(url)
        print("retry number" + ++retries)
    with open(file_name, "wb") as file:
        # write to file
        file.write(response.content)
        # Open file
        os.startfile(file_name)