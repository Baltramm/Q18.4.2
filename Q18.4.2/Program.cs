using System;
using YoutubeExplode;
using System.Threading.Tasks;

namespace Q18._4._2
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var youtubeLink = "https://www.youtube.com/watch?v=tbkLlRlTA0s";

            var downloader = new Downloader();
            var reciverClient = new YoutubeClient();

            var getinfo = new GetInfo(reciverClient);
            downloader.SetCommand(getinfo);
            await downloader.Run(youtubeLink);

            var download = new Download(reciverClient);
            downloader.SetCommand(download);
            await downloader.Run(youtubeLink);
        }
    }
}
