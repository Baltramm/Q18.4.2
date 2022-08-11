using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using YoutubeExplode;
using YoutubeExplode.Converter;

namespace Q18._4._2
{
    class Download : Command
    {
        YoutubeClient client;

        public Download(YoutubeClient client)
        {
            this.client = client;
        }

        public override async Task Run(string arg)
        {
            Console.WriteLine("Загрузка видео");
            await client.Videos.DownloadAsync(arg, $"{Guid.NewGuid()}.mp4",
                builder => builder.SetPreset(ConversionPreset.UltraFast));
            Console.WriteLine("Видео загружено");
        }
    }
}
