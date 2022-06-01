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
    public partial class QuestionList : Form
    {
        public static ListBox QuestionListBox = new ListBox();
        public QuestionList()
        {
            InitializeComponent();
        }
        
        private void QuestionList_Load(object sender, EventArgs e)
        {
            QuestionListBox.Location = new Point(20, 20);
            QuestionListBox.Name = "QuestionListBox";
            QuestionListBox.Size = new Size(200, 200);
            QuestionListBox.ScrollAlwaysVisible = false;

            foreach (var i in BattleQuizForm.questions)
            {
                if (QuestionListBox.Items.Contains(i.Title))
                    continue;
                else
                    QuestionListBox.Items.Add(i.Title);
            }

            this.Controls.Add(QuestionListBox);
        }
        private void Edit_Click(object sender, EventArgs e)
        {
            // grab the index of selected item
            int index = QuestionListBox.SelectedIndex;

            if (index < 0) return;

            AddQuestionForm addQuestionForm = new AddQuestionForm();
            addQuestionForm.ToggleEditMode();
            addQuestionForm.EditFromList(index);
            addQuestionForm.ShowDialog();
        }

        private void Remove_Click(object sender, EventArgs e)
        {
            if (QuestionListBox.SelectedIndex < 0) return;

            BattleQuizForm.questions.RemoveAt(QuestionListBox.SelectedIndex);
            QuestionListBox.Items.Remove(QuestionListBox.SelectedItem);
            BattleQuizForm.totalQuestions--;
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            QuestionListBox.Refresh();
        }
    }
}
