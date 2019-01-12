using System.Collections.Generic;
using System.IO;

namespace AnimeDL_GUI
{
    internal class ConfigurationData
    {
        public string quality;
        public List<string> animeList;

        public ConfigurationData()
        {
            quality = "1080p"; // default quality
            animeList = new List<string>();
        }

    }
}