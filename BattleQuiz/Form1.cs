namespace BattleQuiz
{
    public partial class Form1 : Form
    {

        string correctAnswer;
        int questionNumber = 1;
        int score;
        int percentage;
        int totalQuestions = 3;

        public Form1()
        {
            InitializeComponent();

            askQuestion(questionNumber);

            totalQuestions = 3;
        }

        private void checkAnswerEvent(object sender, EventArgs e)
        {
            if (txtAnswer.Text == correctAnswer)
            {
                score++;
                txtAnswer.Clear();
            }
            
            if (questionNumber == totalQuestions)
            {
                // calculate the precentage
                percentage = (int)Math.Round((double)(score * 100) / totalQuestions);

                MessageBox.Show(
                    "Quiz ended!" + Environment.NewLine + 
                    "You have answered " + score + " question correctly." + Environment.NewLine +
                    "Your total percentage is " + percentage + "%" + Environment.NewLine +
                    "Click OK to play again"
                    );

                score = 0;
                questionNumber = 0;
                askQuestion(questionNumber);
            }
            
            questionNumber++;
            askQuestion(questionNumber);
        }

        private void askQuestion(int qnum)
        {
            switch(qnum)
            {
                case 1:
                    pictureBox1.Image = Properties.Resources.eldenLord;

                    lblQuestion.Text = "Which game is that man came from?";

                    correctAnswer = "Elden Ring";

                    break;

                case 2:
                    pictureBox1.Image = Properties.Resources._1064722;

                    lblQuestion.Text = "Which game is this?";

                    correctAnswer = "Final Fantasy VII";

                    break;
                
                case 3:
                    pictureBox1.Image = Properties.Resources.wp5478770_street_fighter_v_champion_edition_wallpapers;

                    lblQuestion.Text = "Which game is this?";

                    correctAnswer = "Street Fighter V";

                    break;
            }
        }
    }
}