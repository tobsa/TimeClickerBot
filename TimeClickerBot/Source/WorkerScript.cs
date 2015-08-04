using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace TimeClickerBot.Source
{
    public class WorkerScript : BaseWorkerScript
    {
        private readonly Timer timer = new Timer();
        private readonly Stopwatch watch = new Stopwatch();
        private readonly Script script;
        
        private int currentAction;

        public event EventHandler Completed;


        public WorkerScript(Script script)
        {
            this.script = script;

            timer.Elapsed += Execute;
        }

        public override void Execute(object source, ElapsedEventArgs args)
        {
            if (!Enabled)
                return;

            var action = script.Actions[currentAction];

            switch (action.State)
            {
                case ActionState.Completed:
                    action.State = ActionState.Idle;
                    currentAction++;

                    if (currentAction >= script.Actions.Count)
                    {
                        currentAction = 0;
                        TimeLines++;
                        watch.Restart();

                        if (Completed != null)
                            Completed(this, EventArgs.Empty);
                    }

                    break;
                case ActionState.Idle:
                    action.State = ActionState.Running;
                    action.Execute();
                    action.State = ActionState.Completed;
                    break;
            }
        }

        private bool enabled;
        public override bool Enabled
        {
            get { return enabled; }
            set
            {
                enabled = value;
                timer.Enabled = value;

                currentAction = 0;

                foreach (var action in script.Actions)
                    action.State = ActionState.Idle;

                if (value)
                {
                    watch.Reset();
                    watch.Start();
                    TimeLines = 0;
                }
                else 
                {
                    watch.Stop();
                }
            }
        }

        public long EstimatedTime
        {
            get
            {
                var sum1 = script.Actions.Where(x => x.GetType() == typeof(ActionMouse)).Cast<ActionMouse>().Sum(x => x.Amount * x.Delay);
                var sum2 = script.Actions.Where(x => x.GetType() == typeof(ActionKeyboard)).Cast<ActionKeyboard>().Sum(x => x.Amount * x.Delay);
                var sum3 = script.Actions.Where(x => x.GetType() == typeof(ActionLoop)).Cast<ActionLoop>().Sum(x => x.Time);

                return sum1 + sum2 + sum3;
            }
        }

        public long SessionTime
        {
            get { return watch.ElapsedMilliseconds; }
        }

        public int TimeLines { get; set; }
    }
}
