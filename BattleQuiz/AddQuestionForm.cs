using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BattleQuiz.Models;

namespace BattleQuiz
{
    public partial class AddQuestionForm : Form
    {
        string file;
        List<Question> list;
        public AddQuestionForm()
        {
            InitializeComponent();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Browser_Click(object sender, EventArgs e)
        {
            int size = -1;
            OpenFileDialog openFileDialog = new OpenFileDialog();
            DialogResult result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                file = openFileDialog.FileName;
                thePicture.Text = file;
                try
                {
                    string text = File.ReadAllText(file);
                    size = text.Length;
                }
                catch (IOException)
                {
                }
            }
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            if (titleText.Text == "" || thePicture.Text == "" || correctAnswer.Text == "")
            {
                MessageBox.Show("All fields are required to fill in", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                Question question = new Question();
                question.Title = titleText.Text;

                question.Picture = Image.FromFile(file);
                question.CorrectAnswer = correctAnswer.Text;

                list = BattleQuizForm.questions;
                list.Add(question);
                BattleQuizForm.totalQuestions++;

                titleText.Clear();
                thePicture.Clear();
                correctAnswer.Clear();
            }
        }
    }
}
