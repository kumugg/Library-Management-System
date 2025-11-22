using MySql.Data.MySqlClient;

namespace Library_Management_System
{
    public partial class PasswordChangeControl : UserControl
    {
        private string username { get; set; } = "";
        public PasswordChangeControl(string username)
        {
            InitializeComponent();
            textBox1.UseSystemPasswordChar = true;
            textBox2.UseSystemPasswordChar = true;
            this.username = username;
            label3.Text = "Change the password for user: " + username;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!(string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text)))
            {
                if (textBox1.Text == textBox2.Text)
                {
                    PasswordHasher hasher = new PasswordHasher();
                    string hash = hasher.HashPassword(textBox1.Text);
                    using (var conn = Database.GetConnecton())
                    {
                        conn.Open();
                        MySqlCommand cmd = new MySqlCommand("UPDATE users SET hash = @hash WHERE username = @username", conn);
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@hash", hash);
                        if (cmd.ExecuteNonQuery() > 0)
                        {
                            MessageBox.Show("Password updated successfully.");
                        }
                        else
                        {
                            MessageBox.Show("Failed to update password.");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Passwords do not match.");
                }
            }
            else
            {
                MessageBox.Show("Please fill in all fields.");
            }
        }
    }
}
