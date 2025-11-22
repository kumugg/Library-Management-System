namespace Library_Management_System
{
    partial class AdminDashboardForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelNav = new Panel();
            button10 = new Button();
            label1 = new Label();
            panelFunctions = new Panel();
            button9 = new Button();
            button8 = new Button();
            button7 = new Button();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            panelHeader = new Panel();
            label2 = new Label();
            panelContainer = new Panel();
            panelNav.SuspendLayout();
            panelFunctions.SuspendLayout();
            panelHeader.SuspendLayout();
            SuspendLayout();
            // 
            // panelNav
            // 
            panelNav.BackColor = Color.LightCyan;
            panelNav.Controls.Add(button10);
            panelNav.Controls.Add(label1);
            panelNav.Dock = DockStyle.Top;
            panelNav.Location = new Point(0, 0);
            panelNav.Name = "panelNav";
            panelNav.Size = new Size(1523, 69);
            panelNav.TabIndex = 0;
            // 
            // button10
            // 
            button10.Anchor = AnchorStyles.Right;
            button10.BackColor = Color.LightCoral;
            button10.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button10.ForeColor = Color.Black;
            button10.Location = new Point(1451, 16);
            button10.Name = "button10";
            button10.Size = new Size(60, 38);
            button10.TabIndex = 13;
            button10.Text = "Exit";
            button10.UseVisualStyleBackColor = false;
            button10.Click += button10_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.MenuText;
            label1.Location = new Point(6, 16);
            label1.Name = "label1";
            label1.Size = new Size(458, 38);
            label1.TabIndex = 1;
            label1.Text = "Library Management System";
            // 
            // panelFunctions
            // 
            panelFunctions.BackColor = Color.LightCyan;
            panelFunctions.Controls.Add(button9);
            panelFunctions.Controls.Add(button8);
            panelFunctions.Controls.Add(button7);
            panelFunctions.Controls.Add(button6);
            panelFunctions.Controls.Add(button5);
            panelFunctions.Controls.Add(button4);
            panelFunctions.Controls.Add(button3);
            panelFunctions.Controls.Add(button2);
            panelFunctions.Controls.Add(button1);
            panelFunctions.Dock = DockStyle.Left;
            panelFunctions.Location = new Point(0, 69);
            panelFunctions.Name = "panelFunctions";
            panelFunctions.Size = new Size(200, 707);
            panelFunctions.TabIndex = 3;
            // 
            // button9
            // 
            button9.BackColor = Color.LightGoldenrodYellow;
            button9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button9.ForeColor = Color.Black;
            button9.Location = new Point(0, 613);
            button9.Name = "button9";
            button9.Size = new Size(200, 56);
            button9.TabIndex = 12;
            button9.Text = "Delete Members";
            button9.UseVisualStyleBackColor = false;
            button9.Click += button9_Click;
            // 
            // button8
            // 
            button8.BackColor = Color.LightGoldenrodYellow;
            button8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button8.ForeColor = Color.Black;
            button8.Location = new Point(0, 542);
            button8.Name = "button8";
            button8.Size = new Size(200, 56);
            button8.TabIndex = 11;
            button8.Text = "Update Members";
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click;
            // 
            // button7
            // 
            button7.BackColor = Color.LightGoldenrodYellow;
            button7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button7.ForeColor = Color.Black;
            button7.Location = new Point(0, 471);
            button7.Name = "button7";
            button7.Size = new Size(200, 56);
            button7.TabIndex = 10;
            button7.Text = "Add Members";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.LightGoldenrodYellow;
            button6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button6.ForeColor = Color.Black;
            button6.Location = new Point(0, 400);
            button6.Name = "button6";
            button6.Size = new Size(200, 56);
            button6.TabIndex = 9;
            button6.Text = "Delete Books";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.LightGoldenrodYellow;
            button5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.ForeColor = Color.Black;
            button5.Location = new Point(0, 329);
            button5.Name = "button5";
            button5.Size = new Size(200, 56);
            button5.TabIndex = 8;
            button5.Text = "Update Books";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.LightGoldenrodYellow;
            button4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.Black;
            button4.Location = new Point(0, 258);
            button4.Name = "button4";
            button4.Size = new Size(200, 56);
            button4.TabIndex = 7;
            button4.Text = "Add Books";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.LightGoldenrodYellow;
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.Black;
            button3.Location = new Point(0, 187);
            button3.Name = "button3";
            button3.Size = new Size(200, 56);
            button3.TabIndex = 6;
            button3.Text = "Return Books";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.LightGoldenrodYellow;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.Black;
            button2.Location = new Point(0, 116);
            button2.Name = "button2";
            button2.Size = new Size(200, 56);
            button2.TabIndex = 5;
            button2.Text = "Issue Books";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.LightGoldenrodYellow;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(0, 45);
            button1.Name = "button1";
            button1.Size = new Size(200, 56);
            button1.TabIndex = 4;
            button1.Text = "Searh Books";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panelHeader
            // 
            panelHeader.Controls.Add(label2);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(200, 69);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1323, 57);
            panelHeader.TabIndex = 4;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(625, 12);
            label2.Name = "label2";
            label2.Size = new Size(72, 30);
            label2.TabIndex = 0;
            label2.Text = "label2";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelContainer
            // 
            panelContainer.Dock = DockStyle.Fill;
            panelContainer.Location = new Point(200, 126);
            panelContainer.Name = "panelContainer";
            panelContainer.Size = new Size(1323, 650);
            panelContainer.TabIndex = 5;
            // 
            // AdminDashboardForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1523, 776);
            Controls.Add(panelContainer);
            Controls.Add(panelHeader);
            Controls.Add(panelFunctions);
            Controls.Add(panelNav);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "AdminDashboardForm";
            Text = "Library Management System (LMS)";
            panelNav.ResumeLayout(false);
            panelNav.PerformLayout();
            panelFunctions.ResumeLayout(false);
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelNav;
        private Label label1;
        private Button button10;
        private Panel panelFunctions;
        private Button button9;
        private Button button8;
        private Button button7;
        private Button button6;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private Panel panelHeader;
        private Panel panelContainer;
        private Label label2;
    }
}