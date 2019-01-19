import time
import Utilities as Utils
import Constants as consts


showsPageSoup = Utils.getIndexPage()
for anime in consts.animeList:
    animeName = anime.replace("\n", "")
    print("Scanning " + animeName + ":")

    link = showsPageSoup.find("a", title=animeName)

    ####### TODO: implement recovery mechanism
    try:
        consts.driver.get(consts.URL + link.get('href'))
    except:
        print("No anime called " + anime + " found")
        continue
    ######
    time.sleep(5)
    print("    got " + animeName + " site")
    p_element = consts.driver.find_element_by_class_name(consts.AllEpisodeContainerClass)
    for element in p_element.find_elements_by_class_name(consts.SingleEpisodeContainerClass):
        fileName = animeName + " " + element.find_element_by_tag_name(consts.EpisodeNumberTag).text + ".torrent"  # anime name + number.torrent
        # download episodes that were uploaded today and were not already downloaded
        if element.find_element_by_class_name(consts.ReleaseDateClass).text == "Today" and not Utils.HasDownloaded(fileName):
            element.find_element_by_class_name(consts.ReleaseDateClass).click() # click to reveal episode links
            time.sleep(5)
            # find our link
            url = element.find_elements_by_class_name(consts.QualityOptionsClass)[consts.QualityDictionary[consts.quality]].find_elements_by_class_name(consts.DownloadMirrorsClass)[consts.torrentIndex].find_element_by_tag_name("a").get_attribute("href")
            Utils.downloadAndOpen(url, fileName)
        else:
            break

consts.CloseFiles()