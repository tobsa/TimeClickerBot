using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeClickerBot.Source
{
    public interface IScriptLoader
    {
        Script Load(string filename);
    }
}
