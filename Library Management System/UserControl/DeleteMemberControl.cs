using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Management_System
{
    public partial class DeleteMemberControl : UserControl
    {
        public DeleteMemberControl()
        {
            InitializeComponent();
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            textBox4.Enabled = false;
            textBox5.Enabled = false;
            button2.Enabled = false;
        }

        private void ClearTextBoxes()
        {
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            try
            {
                using (var conn = Database.GetConnecton())
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand("SELECT uid, nic, fname, lname FROM users WHERE username = @username", conn);
                    cmd.Parameters.AddWithValue("username", username);
                    var result = cmd.ExecuteReader();
                    if (result.Read())
                    {
                        textBox2.Text = result["uid"].ToString();
                        textBox3.Text = result["nic"].ToString();
                        textBox4.Text = result["fname"].ToString();
                        textBox5.Text = result["lname"].ToString();
                        button2.Enabled = true;
                    }
                    else
                    {
                        ClearTextBoxes();
                        MessageBox.Show("Username is not exits.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;

            if (MessageBox.Show("Are you sure you want to delete this user?", "Confirm Delete", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return;
            }

            try
            {
                using (var conn = Database.GetConnecton())
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand("DELETE FROM users WHERE username = @username", conn);
                    cmd.Parameters.AddWithValue("username", username);
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("User deleted successfully.");
                        ClearTextBoxes();
                    }
                    else
                    {
                        MessageBox.Show("User not found.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
        }
    }
}
