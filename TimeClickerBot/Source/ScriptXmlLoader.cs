using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace TimeClickerBot.Source
{
    public class ScriptXmlLoader : IScriptLoader
    {
        public Script Load(string filename)
        {
            using (var reader = new StreamReader(filename))
            {
                var serializer = new XmlSerializer(typeof(Script));
                return (Script)serializer.Deserialize(reader);
            }
        }
    }
}
