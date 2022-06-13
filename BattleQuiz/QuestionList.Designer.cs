namespace BattleQuiz
{
    partial class QuestionList
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
            this.Remove = new System.Windows.Forms.Button();
            this.Edit = new System.Windows.Forms.Button();
            this.Refresh = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Remove
            // 
            this.Remove.Location = new System.Drawing.Point(268, 335);
            this.Remove.Name = "Remove";
            this.Remove.Size = new System.Drawing.Size(75, 23);
            this.Remove.TabIndex = 0;
            this.Remove.Text = "Remove";
            this.Remove.UseVisualStyleBackColor = true;
            this.Remove.Click += new System.EventHandler(this.Remove_Click);
            // 
            // Edit
            // 
            this.Edit.Location = new System.Drawing.Point(12, 335);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(75, 23);
            this.Edit.TabIndex = 1;
            this.Edit.Text = "Edit";
            this.Edit.UseVisualStyleBackColor = true;
            this.Edit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // Refresh
            // 
            this.Refresh.Location = new System.Drawing.Point(133, 335);
            this.Refresh.Name = "Refresh";
            this.Refresh.Size = new System.Drawing.Size(85, 23);
            this.Refresh.TabIndex = 2;
            this.Refresh.Text = "Refresh";
            this.Refresh.UseVisualStyleBackColor = true;
            this.Refresh.Click += new System.EventHandler(this.Refresh_Click);
            // 
            // QuestionList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 370);
            this.Controls.Add(this.Refresh);
            this.Controls.Add(this.Edit);
            this.Controls.Add(this.Remove);
            this.Name = "QuestionList";
            this.Text = "QuizBox";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.QuestionList_FormClosing);
            this.Load += new System.EventHandler(this.QuestionList_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Button Remove;
        private Button Edit;
        private Button Refresh;
    }
}