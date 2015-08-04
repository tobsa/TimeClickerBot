using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace TimeClickerBot.Source
{
    public class ActionMouseCircle : Action
    {
        [XmlAttribute("x")]
        public int X { get; set; }

        [XmlAttribute("y")]
        public int Y { get; set; }

        [XmlAttribute("radius")]
        public int Radius { get; set; }

        [XmlAttribute("time")]
        public long Time { get; set; }

        public override void Execute(IActionData actionData = null)
        {
            var data = actionData as ActionMouseCircleData;
            if (data == null)
                return;

            var time = Time;
            var watch = new Stopwatch();

            while (data.ParentAction.State == ActionState.Running && time > 0)
            {
                const double min = -Math.PI;
                const double max = +Math.PI;

                var amount = time / (double)Time;
                var angle = min + (max - min) * amount;

                var x = X + Math.Cos(angle) * Radius;
                var y = Y + Math.Sin(angle) * Radius;

                Mouse.Click((int)x, (int)y);
                //Mouse.SetPosition((int)x, (int)y);
                //Console.WriteLine("Click: {0} {1}", X, Y);

                time -= watch.ElapsedMilliseconds;
                watch.Restart();

                Thread.Sleep(1);
            }
        }
    }
}
