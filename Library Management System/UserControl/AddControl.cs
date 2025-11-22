using MySql.Data.MySqlClient;

namespace Library_Management_System
{
    public partial class AddControl : UserControl
    {
        public AddControl()
        {
            InitializeComponent();
        }

        private void textBoxes_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string title = textBox1.Text;
            string author = textBox2.Text;
            string isbn = textBox3.Text;
            string publisher = textBox4.Text;
            string publicationYear = textBox5.Text;
            string category = textBox6.Text;
            string language = textBox7.Text;
            string pages = textBox8.Text;
            string copiesavailable = textBox9.Text;

            if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text) || string.IsNullOrWhiteSpace(textBox3.Text) || string.IsNullOrWhiteSpace(textBox4.Text) || string.IsNullOrWhiteSpace(textBox5.Text) || string.IsNullOrWhiteSpace(textBox6.Text) || string.IsNullOrWhiteSpace(textBox7.Text) || string.IsNullOrWhiteSpace(textBox8.Text) || string.IsNullOrWhiteSpace(textBox9.Text))
            {
                MessageBox.Show("Please fill in all fields before saving.");
                return;
            }


            using (var conn = Database.GetConnecton())
            {
                conn.Open();

                string query = "INSERT INTO books (title, author, isbn, publisher, publishedyear, category, language, pages, copiesavailable) VALUES (@title, @author, @isbn, @publisher, @publishedyear, @category, @language, @pages, @copiesavailable)";

                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@title", textBox1.Text);
                    cmd.Parameters.AddWithValue("@author", textBox2.Text);
                    cmd.Parameters.AddWithValue("@isbn", textBox3.Text);
                    cmd.Parameters.AddWithValue("@publisher", textBox4.Text);
                    cmd.Parameters.AddWithValue("@publishedyear", textBox5.Text);
                    cmd.Parameters.AddWithValue("@category", textBox6.Text);
                    cmd.Parameters.AddWithValue("@language", textBox7.Text);
                    cmd.Parameters.AddWithValue("@pages", Convert.ToInt32(textBox8.Text));
                    cmd.Parameters.AddWithValue("@copiesavailable", Convert.ToInt32(textBox9.Text));

                    int rows = cmd.ExecuteNonQuery();
                    if (rows > 0)
                    {
                        MessageBox.Show("Book added successfully!");
                    }
                    else
                    {
                        MessageBox.Show("Failed to add book.");
                    }
                }
            }
        }
    }
}