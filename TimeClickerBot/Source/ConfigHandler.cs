using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeClickerBot.Source
{
    public class ConfigHandler
    {
        private readonly string filename;

        private const int TotalTimeLinesIndex = 0;
        private const int StartPositionXIndex = 1;
        private const int StartPositionYIndex = 2;

        public ConfigHandler(string filename)
        {
            this.filename = filename;
            Load();
        }

        public int TotalTimeLines { get; set; }
        public int StartLocationX { get; set; }
        public int StartLocationY { get; set; }

        public void Load()
        {
            var lines = File.ReadAllLines(filename);
            lines = lines.Where(x => !x.StartsWith(";")).ToArray();

            TotalTimeLines = int.Parse(lines[TotalTimeLinesIndex]);
            StartLocationX = int.Parse(lines[StartPositionXIndex]);
            StartLocationY = int.Parse(lines[StartPositionYIndex]);
        }

        public void Save()
        {
            var lines = new[]
            {
                TotalTimeLines.ToString(),
                StartLocationX.ToString(),
                StartLocationY.ToString()
            };

            File.WriteAllLines(filename, lines);
        }
    }
}
