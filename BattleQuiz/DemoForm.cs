namespace BattleQuiz
{
    public partial class DemoForm : Form
    {
        private string correctAnswer;
        private int questionNumber = 1;
        private int score;
        private int percentage;
        private int totalQuestions;

        public DemoForm()
        {
            InitializeComponent();

            totalQuestions = 3;

            AskQuestion(questionNumber);
        }

        private void CheckAnswerEvent(object sender, EventArgs e)
        {
            CheckAnswer();
        }

        private void CheckAnswer()
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
                string titleOfMessageBox = "Restart quiz";

                if (score == 1)
                {
                    dialogResult = MessageBox.Show(
                        "Quiz ended!" + Environment.NewLine +
                        "You have answered " + score + " question correctly." + Environment.NewLine +
                        "Your total percentage is " + percentage + "%" + Environment.NewLine +
                        "Click Yes to play again or click No to leave", titleOfMessageBox, MessageBoxButtons.YesNo
                        );
                }
                else if (score == 0)
                {
                    dialogResult = MessageBox.Show(
                        "Quiz ended!" + Environment.NewLine +
                        "You have answered no questions correctly." + Environment.NewLine +
                        "Your total percentage is " + percentage + "%" + Environment.NewLine +
                        "Click Yes to play again or click No to leave", titleOfMessageBox, MessageBoxButtons.YesNo
                        );
                }
                else
                {
                    dialogResult = MessageBox.Show(
                        "Quiz ended!" + Environment.NewLine +
                        "You have answered " + score + " questions correctly." + Environment.NewLine +
                        "Your total percentage is " + percentage + "%" + Environment.NewLine +
                        "Click Yes to play again or click No to leave", titleOfMessageBox, MessageBoxButtons.YesNo
                        );
                }

                if (dialogResult == DialogResult.Yes)
                {
                    score = 0;
                    AskQuestion(questionNumber);
                }
                else
                {
                    EndQuiz();
                }
            }

            txtAnswer.Clear();
            questionNumber++;
            AskQuestion(questionNumber);
        }

        private void AskQuestion(int qnum)
        {
            switch (qnum)
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
            }
        }

        private void EndQuiz()
        {
            Form frm = Application.OpenForms["MainMenu"];
            frm.Show();
            Hide();
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

        private void QuestionListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuestionList questionList = new QuestionList();
            questionList.ShowDialog();
        }
        private void DemoForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            EndQuiz();
        }

        private void QuitQuiz_Click(object sender, EventArgs e)
        {
            DialogResult choice;
            choice = MessageBox.Show(
               "Are you sure to leave the quiz?", "Confirm", MessageBoxButtons.YesNo
               );

            if (choice == DialogResult.Yes)
                EndQuiz();
            else
                return;
        }

        private void TxtAnswer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                CheckAnswer();
            }
        }
    }
}