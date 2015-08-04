using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace TimeClickerBot.Source
{
    public enum ActionState
    {
        Idle,
        Running,
        Completed
    }

    [XmlInclude(typeof(ActionMouse))]
    [XmlInclude(typeof(ActionKeyboard))]
    public abstract class Action
    {
        [XmlIgnore]
        public ActionState State { get; set; }

        public abstract void Execute(IActionData data = null);
    }
}
