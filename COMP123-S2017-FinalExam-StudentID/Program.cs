using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

/* Name: Bishnu Khanal
 * Student ID: 300924228
 * Date: July 13, 2017
 * Description: This is the Program Class
 * Version:0.1 - Created FinalTest project ScoreBoard CardGame
 */

namespace COMP123_S2017_FinalExam_StudentID
{
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new SplashFormCardGame());
        }
    }
}
