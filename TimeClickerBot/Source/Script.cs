using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace TimeClickerBot.Source
{
    [XmlRoot("script")]
    public class Script
    {
        [XmlArray("actions")]
        [XmlArrayItem("mouse", typeof(ActionMouse))]
        [XmlArrayItem("keyboard", typeof(ActionKeyboard))]
        [XmlArrayItem("loop", typeof(ActionLoop))]
        [XmlArrayItem("screenshot", typeof(ActionScreenshot))]
        public List<Action> Actions { get; set; }
    }
}
