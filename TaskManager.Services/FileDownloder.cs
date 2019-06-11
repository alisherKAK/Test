using System.Net;

namespace TaskManager.Services
{
    public class FileDownloder
    {
        public void DownloadFile(string url)
        {
            using(var client = new WebClient())
            {
                client.DownloadFile(url, url.Split('\\')[url.Split('\\').Length - 1]);
            }
        }
    }
}
