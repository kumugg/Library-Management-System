using MySql.Data.MySqlClient;

namespace Library_Management_System
{
    public partial class AddMemberControl : UserControl
    {
        public AddMemberControl()
        {
            InitializeComponent();
            textBox5.UseSystemPasswordChar = true;
            textBox6.UseSystemPasswordChar = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox5.Text != textBox6.Text)
                {
                    MessageBox.Show("Passwords do not match.");
                    return;
                }
                string username = textBox1.Text;
                string firstName = textBox2.Text;
                string lastName = textBox3.Text;
                string nic = textBox4.Text;
                string password = textBox6.Text;
                string? role = null;

                if (radioButton1.Checked)
                {
                    role = "user";
                }
                else if (radioButton2.Checked)
                {
                    role = "admin";
                }

                string hash = new PasswordHasher().HashPassword(password);

                if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(role) || string.IsNullOrEmpty(nic))
                {
                    MessageBox.Show("Please fill in all fields.");
                    return;
                }

                using (var conn = Database.GetConnecton())
                {
                    conn.Open();

                    MySqlCommand cmd1 = new MySqlCommand("SELECT username FROM users WHERE username = @username", conn);
                    cmd1.Parameters.AddWithValue("@username", username);
                    var result = cmd1.ExecuteScalar();
                    if (result != null)
                    {
                        MessageBox.Show("Username already exists.");
                        return;
                    }

                    MySqlCommand cmd2 = new MySqlCommand("SELECT nic FROM users WHERE nic = @nic", conn);
                    cmd2.Parameters.AddWithValue("@nic", nic);
                    var result2 = cmd2.ExecuteScalar();
                    if (result2 != null)
                    {
                        MessageBox.Show("NIC already exists.");
                        return;
                    }

                    MySqlCommand cmd = new MySqlCommand("INSERT INTO users (username, fname, lname, nic, hash, role) VALUES (@username, @firstname, @lastname, @nic, @hash, @role)", conn);
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@firstname", firstName);
                    cmd.Parameters.AddWithValue("@lastname", lastName);
                    cmd.Parameters.AddWithValue("@nic", nic);
                    cmd.Parameters.AddWithValue("@hash", hash);
                    cmd.Parameters.AddWithValue("@role", role);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Member added successfully.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }
    }
}
