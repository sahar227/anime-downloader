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
            const string animeListFile = "animeList.txt";

            animeList = new List<string>();
            try
            {
                // Create an instance of StreamReader to read from a file.
                // The using statement also closes the StreamReader.
                using (StreamReader sr = new StreamReader(animeListFile))
                {
                    string line;

                    // Read and display lines from the file until 
                    // the end of the file is reached. 
                    while ((line = sr.ReadLine()) != null)
                    {
                        animeList.Add(line);
                    }
                }

            }
            catch
            {

            }
        }
    }
}