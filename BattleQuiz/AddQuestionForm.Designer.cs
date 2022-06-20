namespace BattleQuiz
{
    partial class AddQuestionForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddQuestionForm));
            this.AddQuestionTitle = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.titleText = new System.Windows.Forms.TextBox();
            this.correctAnswer = new System.Windows.Forms.TextBox();
            this.CreateButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.Browser = new System.Windows.Forms.Button();
            this.thePicture = new System.Windows.Forms.TextBox();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.SuspendLayout();
            // 
            // AddQuestionTitle
            // 
            this.AddQuestionTitle.AutoSize = true;
            this.AddQuestionTitle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AddQuestionTitle.Location = new System.Drawing.Point(304, 57);
            this.AddQuestionTitle.Name = "AddQuestionTitle";
            this.AddQuestionTitle.Size = new System.Drawing.Size(191, 25);
            this.AddQuestionTitle.TabIndex = 0;
            this.AddQuestionTitle.Text = "Add a new Question";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Title:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Picture:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 283);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Correct answer:";
            // 
            // titleText
            // 
            this.titleText.Location = new System.Drawing.Point(216, 133);
            this.titleText.Name = "titleText";
            this.titleText.Size = new System.Drawing.Size(304, 23);
            this.titleText.TabIndex = 4;
            // 
            // correctAnswer
            // 
            this.correctAnswer.Location = new System.Drawing.Point(216, 283);
            this.correctAnswer.Name = "correctAnswer";
            this.correctAnswer.Size = new System.Drawing.Size(304, 23);
            this.correctAnswer.TabIndex = 5;
            // 
            // CreateButton
            // 
            this.CreateButton.Location = new System.Drawing.Point(117, 389);
            this.CreateButton.Name = "CreateButton";
            this.CreateButton.Size = new System.Drawing.Size(75, 23);
            this.CreateButton.TabIndex = 6;
            this.CreateButton.Text = "Create";
            this.CreateButton.UseVisualStyleBackColor = true;
            this.CreateButton.Click += new System.EventHandler(this.CreateButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(486, 389);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 7;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // Browser
            // 
            this.Browser.Location = new System.Drawing.Point(535, 209);
            this.Browser.Name = "Browser";
            this.Browser.Size = new System.Drawing.Size(77, 23);
            this.Browser.TabIndex = 8;
            this.Browser.Text = "Browse...";
            this.Browser.UseVisualStyleBackColor = true;
            this.Browser.Click += new System.EventHandler(this.Browser_Click);
            // 
            // thePicture
            // 
            this.thePicture.Location = new System.Drawing.Point(216, 210);
            this.thePicture.Name = "thePicture";
            this.thePicture.Size = new System.Drawing.Size(304, 23);
            this.thePicture.TabIndex = 9;
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // AddQuestionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.thePicture);
            this.Controls.Add(this.Browser);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.CreateButton);
            this.Controls.Add(this.correctAnswer);
            this.Controls.Add(this.titleText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AddQuestionTitle);
            this.Name = "AddQuestionForm";
            this.Text = "Add a new Question";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddQuestionForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label AddQuestionTitle;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button CreateButton;
        private Button CancelButton;
        private Button Browser;
        public TextBox titleText;
        public TextBox correctAnswer;
        public TextBox thePicture;
        private PrintPreviewDialog printPreviewDialog1;
    }
}