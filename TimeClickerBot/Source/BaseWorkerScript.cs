﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace TimeClickerBot.Source
{
    public abstract class BaseWorkerScript
    {
        public virtual bool Enabled { get; set; }

        public abstract void Execute(object source, ElapsedEventArgs args);
    }
}
