using MySql.Data.MySqlClient;

namespace Library_Management_System
{
    public partial class UpdateMemberControl : UserControl
    {
        private protected string username { get; set; } = "";
        public UpdateMemberControl()
        {
            InitializeComponent();
            TextBoxStatus(false);
        }

        public void TextBoxStatus(bool status)
        {
            textBox2.Enabled = status;
            textBox3.Enabled = status;
            radioButton1.Enabled = status;
            radioButton2.Enabled = status;
            button2.Enabled = status;
            button3.Enabled = status;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                username = textBox1.Text;
                TextBoxStatus(false);

                using (var conn = Database.GetConnecton())
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand("SELECT * FROM users WHERE username = @username LIMIT 1", conn);
                    cmd.Parameters.AddWithValue("@username", username);
                    var result = cmd.ExecuteReader();
                    if (result.Read())
                    {
                        textBox2.Text = result.GetString("fname");
                        textBox3.Text = result.GetString("lname");
                        TextBoxStatus(true);
                    }

                    else
                    {
                        MessageBox.Show("Member not found.");
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                username = textBox1.Text;
                string fname = textBox2.Text;
                string lname = textBox3.Text;
                string role = "";

                if (radioButton1.Checked)
                {
                    role = "user";
                }
                else if (radioButton2.Checked)
                {
                    role = "admin";
                }
                else
                {
                    MessageBox.Show("Please select a role.");
                    return;
                }

                using (var conn = Database.GetConnecton())
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand("UPDATE users SET fname = @fname, lname = @lname, role = @role WHERE username = @username", conn);
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@fname", fname);
                    cmd.Parameters.AddWithValue("@lname", lname);
                    cmd.Parameters.AddWithValue("@role", role);

                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Member updated successfully.");
                    }
                    else
                    {
                        MessageBox.Show("Failed to update member.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            UserControl passwordchangecontrol = new PasswordChangeControl(username);
            passwordchangecontrol.Dock = DockStyle.Fill;
            panel2.Controls.Clear();
            panel2.Controls.Add(passwordchangecontrol);
        }
    }
}
