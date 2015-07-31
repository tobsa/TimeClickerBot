using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeClickerBot.Source
{
    public class GlobalHotKey
    {
        public static int Code = 0x0312;

        public static Keys GetKey(Message m)
        {
            return (Keys)((m.LParam.ToInt32()) >> 16);
        }

        public int Modifier { get; set; }
        public int Key { get; set; }
    }

    public class GlobalHotKeyHandler
    {
        private readonly List<GlobalHotKey> hotKeys = new List<GlobalHotKey>();

        [DllImport("user32.dll")]
        public static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vlc);

        public void Register(IntPtr hWnd, int id, Keys key, int fsModifier = 0x0000)
        {
            hotKeys.Add(new GlobalHotKey()
            {
                Modifier = fsModifier,
                Key = (int)key
            });

            RegisterHotKey(hWnd, id, fsModifier, (int)key);
        }

        public void Reload(IntPtr hWnd, int id)
        {
            foreach (var hotKey in hotKeys)
            {
                RegisterHotKey(hWnd, id, hotKey.Modifier, hotKey.Key);
            }
        }
    }
}
