using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing.Imaging;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Xml.Serialization;

namespace TimeClickerBot.Source
{
    public class WorkerScript : Worker
    {
        private readonly ClickSequenceCollection collection;
        private int currentSequence;
        private int currentClick;
        private int currentAmount;
        private readonly Stopwatch watch = new Stopwatch();

        private bool _enabled;

        public event EventHandler SequenceDone;

        public WorkerScript(string filename)
        {
            var serializer = new XmlSerializer(typeof(ClickSequenceCollection));
            var reader = new StreamReader(filename);
            collection = (ClickSequenceCollection)serializer.Deserialize(reader);
            reader.Close();

            Timer.Elapsed += Execute;
        }

        public long EstimatedTime
        {
            get
            {
                var sum1 = collection.ClickSequences.Where(x => x.Time == 0).Sum(x => x.Clicks.Sum(y => y.Amount * y.Delay));
                var sum2 = collection.ClickSequences.Where(x => x.Time != 0).Sum(x => x.Time);

                return sum1 + sum2;
            }
        }

        public int TimeLines { get; set; }

        public long SessionTime { get { return watch.ElapsedMilliseconds; } }

        public override bool Enabled
        {
            get
            {
                return _enabled;
            }
            set
            {
                _enabled = value;
                Timer.Enabled = value;
                currentSequence = 0;
                currentClick = 0;
                currentAmount = 0;

                foreach (var sequence in collection.ClickSequences)
                {
                    sequence.IsDone = false;
                    sequence.IsRunning = false;
                }

                if (value)
                {
                    TimeLines = 0;
                    watch.Reset();
                    watch.Start();
                }
                else
                {
                    watch.Stop();
                }
            }
        }

        private void Reset()
        {
            currentClick = 0;
            currentAmount = 0;
        }

        public override void Execute(object source, ElapsedEventArgs args)
        {
            if (!Enabled)
                return;

            var sequence = collection.ClickSequences[currentSequence];

            if (sequence.IsDone)
            {
                Reset();
                sequence.IsRunning = false;
                sequence.IsDone = false;

                currentSequence++;

                if (currentSequence >= collection.ClickSequences.Count)
                {
                    currentSequence = 0;
                    TimeLines++;
                    watch.Restart();

                    var handler = SequenceDone;
                    if (handler != null)
                        handler(this, EventArgs.Empty);
                }

                return;
            }

            if (!sequence.IsRunning)
            {   
                Execute(sequence);
            }
        }

        private void Execute(ClickSequence sequence)
        {
            sequence.IsRunning = true;

            while (!sequence.IsDone)
            {
                if (!Enabled)
                    break;

                if (sequence.Type == null)
                {
                    if (sequence.Time == 0)
                        HandleClick(sequence);
                    else
                        HandleClickSequence(sequence, watch);
                }
                else if (sequence.Type == "screenshot")
                {
                    var sc = new ScreenCapture();
                    var img = sc.CaptureScreen();
                    
                    var handler = new ConfigHandler("Data/cf.dat");
                    var imageName = DateTime.Now.ToString("yyyy.MM.dd-H.mm.ss");
                    
                    img.Save("Data\\Images\\Image_" + imageName + "_TimeLine-" +  handler.TotalTimeLines + ".png", ImageFormat.Png);
                    break;
                }
            }

            sequence.IsDone = true;
            sequence.IsRunning = false;
        }

        private void HandleClick(ClickSequence sequence)
        {
            var click = sequence.Clicks[currentClick];
            Thread.Sleep(click.Delay);

            if (!Enabled)
                return;

            currentAmount++;
            Console.WriteLine("Click ({0}): {1} {2}", currentAmount, click.X, click.Y);
            //Mouse.Click(click.X, click.Y);

            if (currentAmount >= click.Amount)
            {
                currentClick++;
                currentAmount = 0;

                if (currentClick >= sequence.Clicks.Count)
                {
                    sequence.IsDone = true;
                }
            }
        }

        private void HandleClickSequence(ClickSequence sequence, Stopwatch watch)
        {
            long time = sequence.Time;

            while (time > 0)
            {
                if (!Enabled)
                    break;

                var click = sequence.Clicks[currentClick];
                Thread.Sleep(click.Delay);

                if (!Enabled)
                    break;

                currentAmount++;
                Console.WriteLine("Click ({0}): {1} {2}", currentAmount, click.X, click.Y);
                //Mouse.Click(click.X, click.Y);

                if (currentAmount >= click.Amount)
                {
                    currentClick++;
                    currentAmount = 0;

                    if (currentClick >= sequence.Clicks.Count)
                        currentClick = 0;
                }

                time -= watch.ElapsedMilliseconds;
                watch.Restart();
            }

            sequence.IsDone = true;
        }
    }
}
