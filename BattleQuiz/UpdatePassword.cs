using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
namespace BattleQuiz
{
    public partial class UpdatePassword : Form
    {
        private SqlConnection cn;
        private SqlDataReader dr;
        private SqlCommand cmd;
        public UpdatePassword()
        {
            InitializeComponent();
        }

        private void UpdatePassword_Load(object sender, EventArgs e)
        {
            string connectionString = @"" + Environment.GetEnvironmentVariable("DATASOURCE");
            cn = new SqlConnection(connectionString);
            cn.Open();
        }

        private void BackToLogin()
        {
            Hide();
            Form frm = Application.OpenForms["Login"];
            frm.Show();
        }

        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            bool exist = false;
            if (txtUsername.Text != string.Empty || txtNewPassword.Text != string.Empty || txtConfirmPassword.Text != string.Empty)
            {
                if (txtNewPassword.Text == txtConfirmPassword.Text)
                {
                    using (cmd = new SqlCommand("select count(*) from [Table] where username = @username", cn))
                    {
                        cmd.Parameters.AddWithValue("username", txtUsername.Text);
                        exist = (int)cmd.ExecuteScalar() > 0;
                    }

                    if (!exist)
                        MessageBox.Show("The user doesn't exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                    {
                        cmd = new SqlCommand("update [Table] set password = @newPassword where username = @username", cn);
                        cmd.Parameters.AddWithValue("newPassword", txtNewPassword.Text);
                        cmd.Parameters.AddWithValue("username", txtUsername.Text);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Your password is now changed. Please login now", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Please enter both password same.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please enter value in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            txtUsername.Clear();
            txtNewPassword.Clear();
            txtConfirmPassword.Clear();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            BackToLogin();
        }

        private void UpdatePassword_FormClosing(object sender, FormClosingEventArgs e)
        {
            BackToLogin();
        }
    }
}
