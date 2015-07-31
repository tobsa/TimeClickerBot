using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace TimeClickerBot.Source
{
    public abstract class Worker
    {
        protected Timer Timer = new Timer();

        private bool _enabled;
        public virtual bool Enabled
        {
            get
            {
                return _enabled;
            }
            set
            {
                _enabled = value;
                Timer.Enabled = value;
            }
        }

        public abstract void Execute(object source, ElapsedEventArgs args);
    }
}
