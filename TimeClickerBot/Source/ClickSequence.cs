﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace TimeClickerBot.Source
{
    public class ClickSequence
    {
        public List<Click> Clicks { get; set; }

        [XmlAttribute("time")]
        public int Time { get; set; }

        [XmlAttribute("type")]
        public string Type { get; set; }

        [XmlIgnore]
        public bool IsDone { get; set; }

        [XmlIgnore]
        public bool IsRunning { get; set; }
    }
}
