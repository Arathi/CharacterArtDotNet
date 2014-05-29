using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CharacterArtDotNet
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            //ImageContainer ic = new ImageContainer(@"D:\tmp\charart\reimu.jpg", 10);
            //ic.load();
            //ic.split();
            //ic.saveSplitedImages(@"D:\tmp\charart\Splited\");
            //return;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
