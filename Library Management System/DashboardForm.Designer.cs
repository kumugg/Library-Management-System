namespace Library_Management_System
{
    partial class DashboardForm
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
            panel1 = new Panel();
            button1 = new Button();
            label1 = new Label();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            label2 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightCyan;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1103, 66);
            panel1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.BackColor = Color.AliceBlue;
            button1.ForeColor = Color.DarkBlue;
            button1.Location = new Point(960, 10);
            button1.Name = "button1";
            button1.Size = new Size(130, 45);
            button1.TabIndex = 1;
            button1.Text = "Administration";
            button1.UseVisualStyleBackColor = false;
            if (LoginForm.role != "admin") { button1.Enabled = false; }
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.MenuText;
            label1.Location = new Point(9, 8);
            label1.Name = "label1";
            label1.Size = new Size(448, 45);
            label1.TabIndex = 0;
            label1.Text = "Library Management System";
            // 
            // button2
            // 
            button2.BackColor = Color.LightGoldenrodYellow;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.Black;
            button2.Location = new Point(13, 154);
            button2.Name = "button2";
            button2.Size = new Size(224, 60);
            button2.TabIndex = 1;
            button2.Text = "Searh Books";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.LightGoldenrodYellow;
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.Black;
            button3.Location = new Point(13, 257);
            button3.Name = "button3";
            button3.Size = new Size(224, 60);
            button3.TabIndex = 2;
            button3.Text = "Issued Books";
            button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.LightGoldenrodYellow;
            button4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.Black;
            button4.Location = new Point(13, 372);
            button4.Name = "button4";
            button4.Size = new Size(224, 60);
            button4.TabIndex = 3;
            button4.Text = "Return Books";
            button4.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Light", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.MenuText;
            label2.Location = new Point(570, 20);
            label2.Name = "label2";
            label2.Size = new Size(264, 30);
            label2.TabIndex = 2;
            label2.Text = $"Hello, {LoginForm.fname}";
            // 
            // DashboardForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuBar;
            BackgroundImage = Properties.Resources._5467433_17271;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1103, 569);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(panel1);
            DoubleBuffered = true;
            Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "DashboardForm";
            RightToLeft = RightToLeft.No;
            StartPosition = FormStartPosition.CenterParent;
            Text = " Library Management System";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Label label2;
    }
}