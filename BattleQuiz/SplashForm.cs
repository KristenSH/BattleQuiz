namespace BattleQuiz
{
    public partial class SplashForm : Form
    {

        public SplashForm()
        {
            InitializeComponent();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            timer.Enabled = true;
            progressBar.Increment(2);
            if (progressBar.Value == 100)
            {
                timer.Enabled = false;
                Login login = new Login();
                login.Show();
                Hide();
            }
        }

        private void SplashForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(1);
        }
    }
}
