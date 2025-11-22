using MySql.Data.MySqlClient;

namespace Library_Management_System
{
    public partial class LoginForm : Form
    {
        public bool IsAuthenticated { get; private set; } = false;
        public string username { get; private set; } = string.Empty;
        public static string role { get; private set; } = string.Empty;
        public static string fname { get; private set; } = string.Empty;

        public LoginForm()
        {
            InitializeComponent();
            this.AcceptButton = button1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            username = this.textBox1.Text;
            string password = this.textBox2.Text;

            using (var conn = Database.GetConnecton())
            {
                try
                {
                    conn.Open();

                    MySqlCommand cmd = new MySqlCommand($"SELECT * FROM users WHERE username = @username", conn);
                    cmd.Parameters.AddWithValue("@username", username);

                    using (MySqlDataReader result = cmd.ExecuteReader())
                    {
                        if (result.Read())
                        {
                            username = result["username"].ToString() ?? string.Empty;
                            fname = result["fname"].ToString() ?? string.Empty;
                            role = result["role"].ToString() ?? string.Empty;

                            string? hash = result["hash"].ToString();
                            if (!string.IsNullOrEmpty(hash))
                            {
                                var isValid = new PasswordHasher().VerifyPassword(password, hash);
                                if (isValid)
                                {
                                    IsAuthenticated = true;
                                    this.Close();
                                }
                                else
                                {
                                    MessageBox.Show("Password is incorrect.");
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Username is not exists.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
    }
}
