using MySql.Data.MySqlClient;
using System.Data;

namespace Library_Management_System
{
    public partial class DeleteControl : UserControl
    {
        public DeleteControl()
        {
            InitializeComponent();
            textBox1.Focus();
        }
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
                int bookID = int.Parse(textBox1.Text);

                using (var conn = Database.GetConnecton())
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand("SELECT * FROM books WHERE bid = @bookId", conn);
                    cmd.Parameters.AddWithValue("@bookId", bookID);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    dataGridView1.DataSource = table;
                    return;
                }
            }
            catch (Exception x)
            {
                MessageBox.Show("Error: " + x.Message);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) { return; }
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            int bookId = Convert.ToInt32(row.Cells["bid"].Value);
            using (var conn = Database.GetConnecton())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("DELETE FROM books WHERE bid = @bookId", conn);
                cmd.Parameters.AddWithValue("@bookId", bookId);

                var confirmation = MessageBox.Show("Are you sure you want to delete this book?", "Confirm Delete", MessageBoxButtons.YesNo);

                if (confirmation == DialogResult.Yes)
                {
                    int rowsAffected = cmd.ExecuteNonQuery();
                    MessageBox.Show(rowsAffected > 0 ? "Book deleted successfully." : "Book deletion failed.");
                }
                else
                {
                    MessageBox.Show("Book deletion canceled.");
                }
            }
        }
    }
}
