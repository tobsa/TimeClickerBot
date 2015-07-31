using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace TimeClickerBot.Source
{
    public class WorkerAutoClickScript : Worker
    {
        public WorkerAutoClickScript(double interval)
        {
            Timer.Interval = interval;
            Timer.Elapsed += Execute;
        }

        public override void Execute(object source, ElapsedEventArgs args)
        {
            Mouse.Click();
        }
    }
}
