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
            Close();
        }
    }
}
