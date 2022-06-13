using BattleQuiz.Models;
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
    public partial class MainMenu : Form
    {
        public static List<Question> questions = new List<Question>();

        public MainMenu()
        {
            InitializeComponent();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            if (questions.Count > 0)
            {
                BattleQuizForm battleQuizForm = new BattleQuizForm();
                battleQuizForm.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("There are no question currently. Please add them by pressing Add Question Button", "No questions",
                     MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Demo_Click(object sender, EventArgs e)
        {
            DemoForm demoForm = new DemoForm();
            demoForm.Show();
            Hide();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            AddQuestionForm addQuestionForm = new AddQuestionForm();
            addQuestionForm.Show();
            Hide();
        }

        private void QuestionListButton_Click(object sender, EventArgs e)
        {
            QuestionList questionListForm = new QuestionList();

            if (questionListForm.IsDisposed == true)
            {
                questionListForm = new QuestionList();
            }
            questionListForm.Show();
            Hide();
        }

        private void QuitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
