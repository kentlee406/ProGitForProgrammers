using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProGitForProgrammers
{
    static class Program
    {
        /// <summary>
        /// 應用程式的主要進入點。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            Console.WriteLine("Hello World!");
            Console.WriteLine("I jsut added this in Visual Studio.");
            Console.WriteLine("I just added this in the command line repo");
            Console.WriteLine("This line add to show the stagaging area.");

        }
    }
}
