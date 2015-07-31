using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace TimeClickerBot.Source
{
    public class Click
    {
        public int X { get; set; }
        public int Y { get; set; }

        [XmlAttribute("amount")]
        public int Amount { get; set; }

        [XmlAttribute("delay")]
        public int Delay { get; set; }
    }
}
