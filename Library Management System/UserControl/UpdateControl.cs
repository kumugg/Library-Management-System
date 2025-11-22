using MySql.Data.MySqlClient;

namespace Library_Management_System
{
    public partial class UpdateControl : UserControl
    {
        private int BookID;
        public UpdateControl()
        {
            InitializeComponent();
            TextBoxEnabled(false);
        }

        private void textBoxes_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        public void TextBoxEnabled(bool status)
        {
            textBox1.Enabled = status;
            textBox2.Enabled = status;
            textBox3.Enabled = status;
            textBox4.Enabled = status;
            textBox5.Enabled = status;
            textBox6.Enabled = status;
            textBox7.Enabled = status;
            textBox8.Enabled = status;
            textBox9.Enabled = status;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                BookID = int.Parse(textBox10.Text);

                using (var conn = Database.GetConnecton())
                {
                    conn.Open();
                    string query = "SELECT * FROM books WHERE bid = @bookid";
                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@bookid", BookID);
                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                textBox1.Text = reader["title"].ToString();
                                textBox2.Text = reader["author"].ToString();
                                textBox3.Text = reader["isbn"].ToString();
                                textBox4.Text = reader["publisher"].ToString();
                                textBox5.Text = reader["publishedyear"].ToString();
                                textBox6.Text = reader["category"].ToString();
                                textBox7.Text = reader["language"].ToString();
                                textBox8.Text = reader["pages"].ToString();
                                textBox9.Text = reader["copiesavailable"].ToString();
                                TextBoxEnabled(true);
                            }
                            else
                            {
                                MessageBox.Show("Book not found.");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var conn = Database.GetConnecton())
            {
                conn.Open();
                string query2 = "UPDATE books SET title = @title, author = @author, isbn = @isbn, publisher = @publisher, publishedyear = @publishedyear, category = @category, language = @language, pages = @pages, copiesavailable = @copiesavailable WHERE bid = @bookid";
                using (var cmd = new MySqlCommand(query2, conn))
                {
                    cmd.Parameters.AddWithValue("@title", textBox1.Text);
                    cmd.Parameters.AddWithValue("@author", textBox2.Text);
                    cmd.Parameters.AddWithValue("@isbn", textBox3.Text);
                    cmd.Parameters.AddWithValue("@publisher", textBox4.Text);
                    cmd.Parameters.AddWithValue("@publishedyear", textBox5.Text);
                    cmd.Parameters.AddWithValue("@category", textBox6.Text);
                    cmd.Parameters.AddWithValue("@language", textBox7.Text);
                    cmd.Parameters.AddWithValue("@pages", textBox8.Text);
                    cmd.Parameters.AddWithValue("@copiesavailable", textBox9.Text);
                    cmd.Parameters.AddWithValue("@bookid", BookID);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Book updated successfully!");
                }
            }
        }
    }
}
