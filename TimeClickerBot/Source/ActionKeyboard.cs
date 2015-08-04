using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace TimeClickerBot.Source
{
    public class ActionKeyboard : Action
    {
        [XmlAttribute("key")]
        public string Key { get; set; }

        [XmlAttribute("amount")]
        public int Amount { get; set; }

        [XmlAttribute("delay")]
        public int Delay { get; set; }

        public override void Execute(IActionData actionData = null)
        {
            var actionTime = Delay;
            var data = actionData as ActionKeyboardData;
            if (data != null)
            {
                var action = data.ParentAction as ActionLoop;
                if (action == null)
                    return;

                if (Delay > action.Time)
                    actionTime = (int)action.Time;
            }

            for (var i = 0; i < Amount; i++)
            {
                SendKeys.SendWait(Key);
                //Console.WriteLine("Keyboard: " + Key);

                Thread.Sleep(actionTime);

                if (State != ActionState.Running)
                    break;
            }
        }
    }
}
