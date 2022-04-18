using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimMod_8._1
{
    public partial class Form1 : Form
    {
        const double POSITIVE_ANSWER_CHANCE = 0.5;
        const string POSITIVE_ANSWER_TEXT = "Yes";
        const string NEGATIVE_ANSWER_TEXT = "No";

        public Form1()
        {
            InitializeComponent();
        }

        private void btnGetAnswer_Click(object sender, EventArgs e)
        {
            if (inputQuestion.Text == String.Empty)
            {
                textAnswer.Text = "Write your question first";
            }
            else
            {
                //seed based on current time
                var rng = new Random((int)DateTime.Now.Ticks);

                var randomNumber = rng.NextDouble();

                textAnswer.Text = (randomNumber < POSITIVE_ANSWER_CHANCE) ? POSITIVE_ANSWER_TEXT : NEGATIVE_ANSWER_TEXT;
            }
        }
    }
}
