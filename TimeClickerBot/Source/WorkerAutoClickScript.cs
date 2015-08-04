using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace TimeClickerBot.Source
{
    public class WorkerAutoClickScript : BaseWorkerScript
    {
        private readonly Timer timer = new Timer();
        private bool _enabled;

        public override bool Enabled
        {
            get { return _enabled; }
            set
            {
                _enabled = value;
                timer.Enabled = value;
            }
        }

        public WorkerAutoClickScript(double interval)
        {
            timer.Interval = interval;
            timer.Elapsed += Execute;
        }

        public override void Execute(object source, ElapsedEventArgs args)
        {
            Mouse.Click();
        }
    }
}
