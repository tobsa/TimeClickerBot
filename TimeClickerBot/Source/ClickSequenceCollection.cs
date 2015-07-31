using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace TimeClickerBot.Source
{
    [XmlRoot("ClickSequences")]
    public class ClickSequenceCollection
    {
        [XmlElement("ClickSequence")]
        public List<ClickSequence> ClickSequences { get; set; }
    }
}
