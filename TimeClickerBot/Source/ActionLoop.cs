using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Xml.Serialization;

namespace TimeClickerBot.Source
{
    public class ActionLoop : Action
    {
        [XmlArray("actions")]
        [XmlArrayItem("mouse", typeof(ActionMouse))]
        [XmlArrayItem("keyboard", typeof(ActionKeyboard))]
        [XmlArrayItem("loop", typeof(ActionLoop))]
        public List<Action> Actions { get; set; }

        [XmlArray("async")]
        [XmlArrayItem("mousecircle", typeof(ActionMouseCircle))]
        public List<Action> AsyncActions { get; set; }
        
        [XmlAttribute("time")]
        public long Time { get; set; }

        [XmlIgnore]
        private Thread thread;

        public override void Execute(IActionData actionData = null)
        {
            var watch = new Stopwatch();
            var currentAction = 0;
            var time = Time;

            var data = new ActionKeyboardData()
            {
                ParentAction = this
            };

            if (AsyncActions.Count > 0)
            {
                thread = new Thread(ExecuteAsyncActions);
                thread.Start();
            }

            while (time > 0 && State == ActionState.Running)
            {
                if (Actions.Count > 0)
                {
                    var action = Actions[currentAction];
                    action.Execute(data);

                    currentAction++;
                    if (currentAction >= Actions.Count)
                        currentAction = 0;
                }

                time -= watch.ElapsedMilliseconds;
                watch.Restart();
            }
        }

        private void ExecuteAsyncActions()
        {
            var currentAction = 0;

            var data = new ActionMouseCircleData()
            {
                ParentAction = this
            };

            while (State == ActionState.Running)
            {
                var action = AsyncActions[currentAction];
                action.Execute(data);

                currentAction++;
                if (currentAction >= AsyncActions.Count)
                    currentAction = 0;
            }
        }
    }
}
