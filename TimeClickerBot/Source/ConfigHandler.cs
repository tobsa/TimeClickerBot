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

        public ConfigHandler(string filename)
        {
            this.filename = filename;
            Load();
        }

        public int TotalTimeLines { get; set; }

        public void Load()
        {
            var value = File.ReadAllText(filename);

            TotalTimeLines = int.Parse(value);
        }

        public void Save()
        {
            File.WriteAllText(filename, TotalTimeLines.ToString());
        }
    }
}
