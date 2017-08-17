using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/* Name: Bishnu Khanal
 * Date: July 13, 2017
 * Description: This is the SpalshForm for Cards game
 * Version:0.2 - Created Splash Form and SplashForm event Handler
 */
namespace COMP123_S2017_FinalExam_StudentID

{
    public partial class SplashFormCardGame: Form
    {
        public SplashFormCardGame()
        {
            InitializeComponent();
        }
        /// <summary>
        /// This is SplashFormTimer_Tick Event handler. Sets time for 3 seconds and replashes after 3 seconds
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SplashFormTimer_Tick(object sender, EventArgs e)
        {
            PickHighestCardForm pickHighestCardForm = new PickHighestCardForm();
            pickHighestCardForm.Show();
            this.Hide();
        }
    }
}
