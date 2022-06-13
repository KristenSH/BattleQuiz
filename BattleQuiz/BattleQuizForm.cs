using BattleQuiz.Models;

namespace BattleQuiz
{
    public partial class BattleQuizForm : Form
    {
        private string correctAnswer;
        private int questionNumber = 1;
        private int score;
        private int percentage;
        private int total;

        public BattleQuizForm()
        {
            InitializeComponent();

            total = AddQuestionForm.totalQuestions;

            AskQuestion(questionNumber);
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

            if (questionNumber == total)
            {
                questionNumber = 0;

                // calculate the precentage
                percentage = (int)Math.Round((double)(score * 100) / total);

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
                    dialogResult = MessageBox.Show(
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
                    EndQuiz();
                }
            }

            txtAnswer.Clear();
            questionNumber++;
            AskQuestion(questionNumber);
        }

        private void AskQuestion(int qnum)
        {
            var allQuestions = MainMenu.questions;
            int currentQnum = qnum - 1;
            foreach (var i in allQuestions)
            {
                int index = allQuestions.IndexOf(i);

                pictureBox.Image = i.Picture;
                lblQuestion.Text = i.Title;
                correctAnswer = i.CorrectAnswer;

                if (index == currentQnum)
                    break;
                else
                    continue;
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

        private void BattleQuizForm_FormClosing(object sender, FormClosingEventArgs e)
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
    }
}