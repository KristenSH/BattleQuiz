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
            if (QuestionListBox.IsDisposed == true)
                QuestionListBox = new ListBox();

            QuestionListBox.Location = new Point(20, 20);
            QuestionListBox.Name = "QuestionListBox";
            QuestionListBox.Size = new Size(200, 200);
            QuestionListBox.ScrollAlwaysVisible = false;

            foreach (var i in MainMenu.questions)
            {
                if (QuestionListBox.Items.Contains(i.Title))
                    continue;
                else
                    QuestionListBox.Items.Add(i.Title);
            }

            Controls.Add(QuestionListBox);
        }
        private void Edit_Click(object sender, EventArgs e)
        {
            // grab the index of selected item
            int selectedIndex = QuestionListBox.SelectedIndex;

            if (selectedIndex < 0) return;

            AddQuestionForm addQuestionForm = new AddQuestionForm();
            addQuestionForm.ToggleEditMode();
            addQuestionForm.EditFromList(selectedIndex);
            addQuestionForm.ShowDialog();
        }

        private void Remove_Click(object sender, EventArgs e)
        {
            if (QuestionListBox.SelectedIndex < 0) return;

            MainMenu.questions.RemoveAt(QuestionListBox.SelectedIndex);
            QuestionListBox.Items.Remove(QuestionListBox.SelectedItem);
            AddQuestionForm.totalQuestions--;
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            QuestionListBox.Refresh();
        }

        private void QuestionList_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form frm = Application.OpenForms["MainMenu"];
            frm.Enabled = true;
            Hide();
        }
    }
}
