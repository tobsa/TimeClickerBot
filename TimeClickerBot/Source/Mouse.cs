using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeClickerBot.Source
{
    public class Mouse
    {
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        static extern bool SetCursorPos(int x, int y);

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern void mouse_event(int dwFlags, int dx, int dy, int cButtons, int dwExtraInfo);

        public static void Click()
        {
            var xpos = Cursor.Position.X;
            var ypos = Cursor.Position.Y;

            mouse_event(0x02, xpos, ypos, 0, 0);
            mouse_event(0x04, xpos, ypos, 0, 0);
        }

        public static void Click(int xpos, int ypos)
        {
            SetCursorPos(xpos, ypos);
            mouse_event(0x02, xpos, ypos, 0, 0);
            mouse_event(0x04, xpos, ypos, 0, 0);
        }
    }
}
