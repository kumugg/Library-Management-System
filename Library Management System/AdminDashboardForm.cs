namespace Library_Management_System
{
    public partial class AdminDashboardForm : Form
    {
        public static string header { get; set; } = " ";

        public AdminDashboardForm()
        {
            InitializeComponent();
            label2.Text = header;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserControl searchControl = new SearchControl();
            searchControl.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(searchControl);
            label2.Text = "Search Books";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UserControl issueControl = new IssueControl(0);
            issueControl.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(issueControl);
            label2.Text = "Issue Books";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            UserControl returnControl = new ReturnControl();
            returnControl.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(returnControl);
            label2.Text = "Return Books";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            UserControl addControl = new AddControl();
            addControl.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(addControl);
            label2.Text = "Add Books";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            UserControl updatecontrol = new UpdateControl();
            updatecontrol.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(updatecontrol);
            label2.Text = "Update Books";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            UserControl deleteControl = new DeleteControl();
            deleteControl.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(deleteControl);
            label2.Text = "Delete Books";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            UserControl AddMemberControl = new AddMemberControl();
            AddMemberControl.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(AddMemberControl);
            label2.Text = "Add Members";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            UserControl UpdateMemberControl = new UpdateMemberControl();
            UpdateMemberControl.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(UpdateMemberControl);
            label2.Text = "Update Members";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            UserControl DeleteMemberControl = new DeleteMemberControl();
            DeleteMemberControl.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(DeleteMemberControl);
            label2.Text = "Delete Members";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
