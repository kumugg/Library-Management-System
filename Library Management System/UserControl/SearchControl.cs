using MySql.Data.MySqlClient;
using System.Data;

namespace Library_Management_System
{
    public partial class SearchControl : UserControl
    {
        string role = LoginForm.role;
        public SearchControl()
        {
            InitializeComponent();
            dataGridView1.ReadOnly = true;

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
            using (var conn = Database.GetConnecton())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT bid AS 'Book ID', title AS 'Title', author AS 'Author', isbn AS 'ISBN', publisher AS 'Publisher', publishedyear AS 'Published Year', category AS 'Category', language AS 'Language', pages AS 'Pages', copiesavailable AS 'Copies Available' FROM books WHERE bid LIKE @search OR title LIKE @search OR author LIKE @search OR isbn LIKE @search OR category LIKE @search OR publishedyear LIKE @search", conn);
                cmd.Parameters.AddWithValue("@search", "%" + textBox1.Text + "%");
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable table = new DataTable();
                adapter.Fill(table);
                if (table.Rows.Count > 0)
                {
                    dataGridView1.DataSource = table;
                }
                else
                {
                    MessageBox.Show("No books found");
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && role == "admin")
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                int bookId = Convert.ToInt32(row.Cells["Book ID"].Value);

                AdminDashboardForm.header = "Issue Books";
                panelContainer.Controls.Clear();
                IssueControl issueControl = new IssueControl(bookId);
                issueControl.Dock = DockStyle.Fill;
                panelContainer.Controls.Add(issueControl);

            }
        }
    }
}
