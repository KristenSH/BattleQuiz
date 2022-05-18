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
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();

            aboutLabel.Text = "Copyright (c) 2022 Kristen Skogholt Haave";
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
