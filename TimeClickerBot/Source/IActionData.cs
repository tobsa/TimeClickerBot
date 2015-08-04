using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeClickerBot.Source
{
    public interface IActionData
    {
    }

    public class ActionMouseCircleData : IActionData
    {
        public Action ParentAction { get; set; }
    }

    public class ActionKeyboardData : IActionData
    {
        public Action ParentAction { get; set; }
    }
}
