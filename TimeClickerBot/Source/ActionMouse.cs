using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace TimeClickerBot.Source
{
    public class ActionMouse : Action
    {
        [XmlAttribute("x")]
        public int X { get; set; }

        [XmlAttribute("y")]
        public int Y { get; set; }

        [XmlAttribute("amount")]
        public int Amount { get; set; }

        [XmlAttribute("delay")]
        public int Delay { get; set; }

        public override void Execute(IActionData data = null)
        {
            for (var i = 0; i < Amount; i++)
            {
                Mouse.Click(X, Y);
                //Mouse.SetPosition(X, Y);
                //Console.WriteLine("Click {0}: {1} {2}", i + 1, X, Y);
                Thread.Sleep(Delay);

                if (State != ActionState.Running)
                    break;
            }
        }
    }
}
