using System;
using System.IO;
using System.Net;

namespace MyCodeLibrary
{
    public class Scrape
    {
        public string ScrapeWebpage(string URL)
        {
            WebClient client = new WebClient();            
            return client.DownloadString(URL);
        }

        public string ScrapeWebpage(string URL, string Filepath)
        {
            WebClient client = new WebClient();
            string reply = client.DownloadString(URL);
            File.WriteAllText(Filepath, reply);
            return client.DownloadString(URL);

        }
    }
}
