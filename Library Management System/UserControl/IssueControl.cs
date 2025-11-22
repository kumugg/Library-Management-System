using MySql.Data.MySqlClient;

namespace Library_Management_System
{
    public partial class IssueControl : UserControl
    {
        public IssueControl(int bookID)
        {
            InitializeComponent();
            textBox1.Text = bookID.ToString();
            textBox1.AcceptsReturn = false;
            label2.Text = "";
            label4.Text = "";
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1.PerformClick();
                e.SuppressKeyPress = true;
            }
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button2.PerformClick();
                e.SuppressKeyPress = true;
            }
        }
        public int bookid { get; private set; } = 0;
        public int userid { get; private set; } = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                bookid = Convert.ToInt32(textBox1.Text);

                using (var conn = Database.GetConnecton())
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand("SELECT title FROM books WHERE bid = @bid", conn);
                    cmd.Parameters.AddWithValue("@bid", bookid);
                    var result = cmd.ExecuteScalar();
                    label2.Text = result != null ? result.ToString() : "Book not found.";
                }

            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid book ID format.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string username = textBox2.Text;
            if (string.IsNullOrWhiteSpace(username))
            {
                MessageBox.Show("Please enter a username.");
                return;
            }
            try
            {
                using (var conn = Database.GetConnecton())
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand("SELECT uid,fname, lname FROM users WHERE username = @username", conn);
                    cmd.Parameters.AddWithValue("@username", username);
                    var result = cmd.ExecuteReader();
                    if (result.Read())
                    {
                        string fname = result.GetString("fname");
                        string lname = result.GetString("lname");
                        userid = result.GetInt32("uid");
                        label4.Text = $"{fname} {lname}";
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
            try
            {
                if (string.IsNullOrWhiteSpace(label2.Text) || label2.Text == "Book not found.")
                {
                    MessageBox.Show("Please search for a valid book first.");
                    return;
                }

                if (string.IsNullOrWhiteSpace(label4.Text))
                {
                    MessageBox.Show("Please search for a valid user first.");
                    return;
                }

                using (var conn = Database.GetConnecton())
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand("INSERT INTO books_users(bid, uid, status) VALUES (@bid, @uid, @status)", conn);
                    cmd.Parameters.AddWithValue("@bid", bookid);
                    cmd.Parameters.AddWithValue("@uid", userid);
                    cmd.Parameters.AddWithValue("@status", "issued");
                    cmd.ExecuteNonQuery();

                    MySqlCommand updateCmd = new MySqlCommand("UPDATE books SET copiesAvailable = copiesAvailable - 1 WHERE bid = @bid", conn);
                    updateCmd.Parameters.AddWithValue("@bid", bookid);
                    updateCmd.ExecuteNonQuery();

                    MessageBox.Show("Book issued successfully.");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
    }
}
