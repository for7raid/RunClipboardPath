using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RunClipboardPath
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application. d:\temp\1.pdf
        /// </summary>
        [STAThread]
        static void Main()
        {
            var path = Clipboard.GetText();
            if (!string.IsNullOrEmpty(path) && (System.IO.Directory.Exists(path) || System.IO.File.Exists(path)))
                System.Diagnostics.Process.Start(path);
        }
    }
}
