using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;

namespace BattleQuiz
{
    public partial class Login : Form
    {
        private SqlConnection cn;
        private SqlDataReader dr;
        private SqlCommand cmd;

        private bool closePending = false;
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            string connectionString = @"" + Environment.GetEnvironmentVariable("DATASOURCE");
            cn = new SqlConnection(connectionString);
            cn.Open();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (password.Text != string.Empty || username.Text != string.Empty)
            {
                cmd = new SqlCommand("select * from [Table] where username='" + username.Text + "' and password='" + password.Text + "'", cn);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    dr.Close();
                    Hide();
                    MainMenu mainMenu = new MainMenu();
                    mainMenu.Show();
                }
                else
                {
                    dr.Close();
                    MessageBox.Show("No Account avilable with this username and password",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please enter value value in all field", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Btn_signup_Click(object sender, EventArgs e)
        {
            Hide();
            Registration registration = new Registration();
            registration.ShowDialog();
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialogResult;
            dialogResult = MessageBox.Show("Are you sure to quit the application? ", "Quit",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                closePending = true;
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();    
        }
    }
}