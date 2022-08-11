using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Q18._4._2
{
    class Downloader
    {
        Command command;

        public void SetCommand(Command command)
        {
            this.command = command;
        }

        public async Task Run(string youtubeLink)
        {
            await command.Run(youtubeLink);
        }
    }
}
