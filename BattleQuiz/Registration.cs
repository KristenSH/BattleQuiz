using System.Data.SqlClient;

namespace BattleQuiz
{
    public partial class Registration : Form
    {
        private SqlConnection cn;
        private SqlDataReader dr;
        private SqlCommand cmd;
        public Registration()
        {
            InitializeComponent();
        }

        private void Registration_Load(object sender, EventArgs e)
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

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            if (confirmPasswordTxt.Text != string.Empty || passwordTxt.Text != string.Empty
                || usernameTxt.Text != string.Empty)
            {
                if (passwordTxt.Text == confirmPasswordTxt.Text)
                {
                    cmd = new SqlCommand("select * from [Table] where username=@username", cn);
                    cmd.Parameters.AddWithValue("username", usernameTxt.Text);
                    dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        dr.Close();
                        MessageBox.Show("Username Already exist please try another ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        dr.Close();
                        cmd = new SqlCommand("insert into [Table] (username, password) values(@usernameSS, @passwordSS)", cn);
                        cmd.Parameters.AddWithValue("usernameSS", usernameTxt.Text);
                        cmd.Parameters.AddWithValue("passwordSS", passwordTxt.Text);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Your Account is created. Please login now.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Please enter both password same ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please enter value in all field.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            usernameTxt.Clear();
            passwordTxt.Clear();
            confirmPasswordTxt.Clear();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            BackToLogin();
        }

        private void Registration_FormClosing(object sender, FormClosingEventArgs e)
        {
            BackToLogin();
        }
    }
}