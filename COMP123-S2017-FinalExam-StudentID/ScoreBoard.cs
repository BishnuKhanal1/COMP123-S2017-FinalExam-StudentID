using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/* Name: Bishnu Khanal
* Date: July 13, 2017
* Description: This is the SecondBoardClas
* Version:0.3 - Added private Inastance variables and public properties to SecondBoard class
*/
namespace COMP123_S2017_FinalExam_StudentID
{
    /// <summary>
    /// This is the SecondBoardClass
    /// </summary>
    public class ScoreBoard
    {
       //Private instance variables   
        private TextBox _finalScoreTextBox;
        private int _score;
        private TextBox _scoreTextBox;
        private int _time;
        private TextBox _timeTextBox;

        //Public Properties

        public TextBox FinalScoreTextBox 
        {
            get
            {
                return this._finalScoreTextBox;
            }
            set
            {
                this.FinalScoreTextBox = value;
            }
        }

        public int Score
        {
            get
            {
                return this._score;            }
            set
            {
                this._score = value;
                ScoreTextBox.Text = this._score.ToString();
            }
        }
        public TextBox ScoreTextBox
        {
            get
            {
                return this._scoreTextBox;
            }
            set
            {
                this._scoreTextBox = value;
            }
        
        }
        public int Time
        {
            get
            {
                return this._time;
            }
            set
            {
                this._time = value;
                TimeTextBox.Text = this._time.ToString();
            }
        }
        public TextBox TimeTextBox
        {
            get
            {
                return this._timeTextBox;
            }
            set
            {
                this._timeTextBox = value;


            }
        } 
        /// <summary>
        /// this UpdateTime method updates the time to the current time
        /// </summary>
         public void UpdateTime()
        {

        }
    }
}
