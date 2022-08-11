using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using YoutubeExplode;
using YoutubeExplode.Converter;

namespace Q18._4._2
{
    class GetInfo:Command
    {
        YoutubeClient client;

        public GetInfo(YoutubeClient client)
        {
            this.client = client;
        }

        public override async Task Run(string arg)
        {
            Console.WriteLine("Загрузка данных");
            var info = await client.Videos.GetAsync(arg);
            Console.WriteLine(info.Title);
            Console.WriteLine(info.Description);
        }
    }
}
