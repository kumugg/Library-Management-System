namespace Library_Management_System
{
    public partial class UserDashboardForm : Form
    {
        public UserDashboardForm()
        {
            InitializeComponent();
            panelContainer.Controls.Clear();
            UserControl searchcontrol = new SearchControl();
            searchcontrol.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(searchcontrol);
        }

        private void UserDashboardForm_Load(object sender, EventArgs e)
        {
            label2.Text = $"Hi, {LoginForm.fname}";
            label2.AutoSize = true;
            int newWidth = label2.PreferredWidth;
            label2.Left = label2.Right - newWidth;
            label2.Width = newWidth;
        }
    }
}
