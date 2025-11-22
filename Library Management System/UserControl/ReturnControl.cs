using MySql.Data.MySqlClient;
using System.Data;

namespace Library_Management_System
{
    public partial class ReturnControl : UserControl
    {
        public ReturnControl()
        {
            InitializeComponent();
            dataGridView1.ReadOnly = true;
        }
        public int transactionID { get; private set; } = 0;

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                e.Handled = true;
                button1.PerformClick();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string username = textBox1.Text;
                using (var conn = Database.GetConnecton())
                {
                    conn.Open();
                    MySqlCommand cmd1 = new MySqlCommand("SELECT uid FROM users WHERE username = @username", conn);
                    MySqlCommand cmd2 = new MySqlCommand("SELECT bu.tid AS 'Transaction ID', bu.bid AS 'Book ID', b.title AS 'Title', b.author AS 'Author', b.isbn AS 'ISBN', b.publisher AS 'publisher', b.publishedyear AS 'Published Year', b.category AS 'Category', b.language AS 'Language', b.pages AS 'Pages', b.copiesavailable AS 'Available Copies' FROM books_users AS bu INNER JOIN books AS b ON bu.bid = b.bid WHERE status = 'issued' AND uid = @userID", conn);

                    cmd1.Parameters.AddWithValue("@username", username);
                    object? result = cmd1.ExecuteScalar();

                    if (result == null)
                    {
                        MessageBox.Show("User not found.");
                        return;
                    }

                    int userID = Convert.ToInt32(result);
                    cmd2.Parameters.AddWithValue("@userID", userID);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd2);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    if (table.Rows.Count > 0)
                    {
                        dataGridView1.DataSource = table;
                    }
                    else
                    {
                        MessageBox.Show("No books to return");
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
                if (transactionID == 0)
                {
                    MessageBox.Show("Please select a book.");
                    return;
                }

                using (var conn = Database.GetConnecton())
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand("UPDATE books_users SET status = 'returned' WHERE tid = @tid", conn);
                    cmd.Parameters.AddWithValue("@tid", transactionID);
                    cmd.ExecuteNonQuery();

                    MySqlCommand cmd2 = new MySqlCommand("UPDATE books b INNER JOIN books_users bu ON b.bid = bu.bid SET b.copiesavailable = b.copiesavailable + 1 WHERE bu.tid = @tid", conn);
                    cmd2.Parameters.AddWithValue("@tid", transactionID);
                    cmd2.ExecuteNonQuery();

                    MessageBox.Show("Book returned successfully.");
                    panel3.Controls.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                transactionID = Convert.ToInt32(row.Cells["Transaction ID"].Value);
                return;
            }

        }
    }
}
