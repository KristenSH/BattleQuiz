using BattleQuiz.Models;

namespace BattleQuiz
{
    public partial class BattleQuizForm : Form
    {

        string correctAnswer;
        int questionNumber = 1;
        int score;
        int percentage;
        public static int totalQuestions;

        public static List<Question> questions = new List<Question>();

        public BattleQuizForm()
        {
            InitializeComponent();

            AskQuestion(questionNumber);

            totalQuestions = 3;
        }

        private void BattleQuizForm_Load(object sender, EventArgs e)
        {

        }

        private void CheckAnswerEvent(object sender, EventArgs e)
        {
            if (txtAnswer.Text == correctAnswer)
            {
                score++;
            }
            
            if (questionNumber == totalQuestions)
            {
                questionNumber = 0;

                // calculate the precentage
                percentage = (int)Math.Round((double)(score * 100) / totalQuestions);

                DialogResult dialogResult;

                if (score == 1)
                {
                    dialogResult = MessageBox.Show(
                        "Quiz ended!" + Environment.NewLine + 
                        "You have answered " + score + " question correctly." + Environment.NewLine +
                        "Your total percentage is " + percentage + "%" + Environment.NewLine +
                        "Click Yes to play again or click No to leave", "Confirm", MessageBoxButtons.YesNo
                        );
                }
                else if (score == 0)
                {
                    dialogResult= MessageBox.Show(
                        "Quiz ended!" + Environment.NewLine +
                        "You have answered no questions correctly." + Environment.NewLine +
                        "Your total percentage is " + percentage + "%" + Environment.NewLine +
                        "Click Yes to play again or click No to leave", "Confirm", MessageBoxButtons.YesNo
                        );
                }
                else
                {
                    dialogResult = MessageBox.Show(
                        "Quiz ended!" + Environment.NewLine +
                        "You have answered " + score + " questions correctly." + Environment.NewLine +
                        "Your total percentage is " + percentage + "%" + Environment.NewLine +
                        "Click Yes to play again or click No to leave", "Confirm", MessageBoxButtons.YesNo
                        );
                }

                if (dialogResult == DialogResult.Yes)
                {
                    score = 0;
                    AskQuestion(questionNumber);
                }
                else
                {
                    Application.Exit();
                }

            }

            txtAnswer.Clear();
            questionNumber++;
            AskQuestion(questionNumber);
        }

        private void AskQuestion(int qnum)
        {
            switch(qnum)
            {
                case 1:
                    pictureBox.Image = Properties.Resources.eldenLord;

                    lblQuestion.Text = "Which game is that man came from?";

                    correctAnswer = "Elden Ring";

                    break;

                case 2:
                    pictureBox.Image = Properties.Resources._1064722;

                    lblQuestion.Text = "Which game is this?";

                    correctAnswer = "Final Fantasy VII";

                    break;
                
                case 3:
                    pictureBox.Image = Properties.Resources.wp5478770_street_fighter_v_champion_edition_wallpapers;

                    lblQuestion.Text = "Which game is this?";

                    correctAnswer = "Street Fighter V";

                    break;

                default:
                    if (questions != null)
                    {
                        // temponary question numbers.
                        int tempQnum = qnum - 4;
                        foreach (var i in questions)
                        {
                            int index = questions.IndexOf(i);

                            pictureBox.Image = i.Picture;
                            lblQuestion.Text = i.Title;
                            correctAnswer = i.CorrectAnswer;

                            if (qnum < 5)
                                break;
                            else if (qnum >= 5)
                            {
                                if (index == tempQnum)
                                    break;
                                else
                                    continue;
                            }
                        }
                    }
                    break;
            }
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AddAQuestionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddQuestionForm addQuestionForm = new AddQuestionForm();
            addQuestionForm.ShowDialog();
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm aboutForm = new AboutForm();
            aboutForm.ShowDialog();
        }
    }
}