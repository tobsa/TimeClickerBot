using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeClickerBot.Source
{
    public class ActionScreenshot : Action
    {
        public override void Execute(IActionData data = null)
        {
            var sc = new Screen();
            var img = sc.CaptureScreen();

            var handler = new ConfigHandler("Data/cf.dat");
            var imageName = DateTime.Now.ToString("yyyy.MM.dd-H.mm.ss");

            img.Save("Data\\Images\\Image_" + imageName + "_TimeLine-" + handler.TotalTimeLines + ".png", ImageFormat.Png);
        }
    }
}
