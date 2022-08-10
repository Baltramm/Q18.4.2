using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Q18._4._2
{
    public abstract class Command
    {
        public abstract Task Run(string arg);
    }
}
