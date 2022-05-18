using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BattleQuiz
{
    public partial class SplashForm : Form
    {

        public SplashForm()
        {
            InitializeComponent();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            timer.Enabled = true;
            progressBar.Increment(2);
            if (progressBar.Value == 100)
            {
                timer.Enabled = false;
                BattleQuizForm battleQuizForm = new BattleQuizForm();
                battleQuizForm.Show();
                this.Hide();
            }
        }

        private void SplashForm_FormClosing(Object sender, FormClosingEventArgs e)
        {
            Environment.Exit(1);
        }
    }
}
