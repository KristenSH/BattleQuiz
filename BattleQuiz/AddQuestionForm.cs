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
        private string file;
        private int questionId;
        private static List<Question> questionList;
        private bool editMode = false;
        public static int totalQuestions;


        public AddQuestionForm()
        {
            InitializeComponent();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            BackToMainMenu();
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
                if (!editMode)
                {
                    Question question = new Question();
                    question.Title = titleText.Text;

                    question.Picture = Image.FromFile(file);
                    question.FilePath = file;

                    question.CorrectAnswer = correctAnswer.Text;
                    questionList = MainMenu.questions;

                    bool alreadyExist = questionList.Any(item => item.Title == question.Title);

                    if (alreadyExist)
                    {
                        MessageBox.Show("That question is already exist! Try insert new one.", "Warning",
                           MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                    else
                    {
                        questionList.Add(question);
                        totalQuestions++;
                    }

                    titleText.Clear();
                    thePicture.Clear();
                    correctAnswer.Clear();
                }

                else
                {
                    questionList[questionId].Title = titleText.Text;
                    if (file == null)
                        file = thePicture.Text;
                    
                    questionList[questionId].Picture = Image.FromFile(file);
                    questionList[questionId].FilePath = file;
                    questionList[questionId].CorrectAnswer = correctAnswer.Text;
                    
                    QuestionList.QuestionListBox.Items[questionId] = titleText.Text;

                    titleText.Clear();
                    thePicture.Clear();
                    correctAnswer.Clear();
                    ToggleEditMode();
                }
            }
        }

        public void ToggleEditMode()
        {
            if (!editMode)
            {
                editMode = true;
                CreateButton.Text = "Edit";
                AddQuestionTitle.Text = "Edit a Question";
            }
            else
            {
                editMode = false;
                CreateButton.Text = "Create";
                AddQuestionTitle.Text = "Add a new Question";
            }
        }

        public void EditFromList(int selectedIndex)
        {
            titleText.Text = questionList[selectedIndex].Title;
            thePicture.Text = questionList[selectedIndex].FilePath;
            correctAnswer.Text = questionList[selectedIndex].CorrectAnswer;

            questionId = selectedIndex;
        }

        private void AddQuestionForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            BackToMainMenu();
        }

        private void BackToMainMenu()
        {
            var frm = Application.OpenForms["MainMenu"];
            frm.Enabled = true;
            Hide();
        }
    }
}
