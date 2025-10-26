//using Siticone.Desktop.UI.WinForms;

namespace Library_Management_System
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            label3 = new Label();
            SuspendLayout();
            this.AcceptButton = button1;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Left;
            textBox1.Location = new Point(234, 182);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(307, 23);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Left;
            textBox2.Location = new Point(234, 239);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(307, 23);
            textBox2.TabIndex = 1;
            textBox2.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Location = new Point(234, 161);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 2;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Location = new Point(234, 221);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 3;
            label2.Text = "Password";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Left;
            button1.BackColor = Color.LightBlue;
            button1.Font = new Font("Segoe UI", 9F);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(234, 286);
            button1.Name = "button1";
            button1.Size = new Size(307, 39);
            button1.TabIndex = 4;
            button1.Text = "Log In";
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Candara", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ImageAlign = ContentAlignment.TopLeft;
            label3.Location = new Point(163, 39);
            label3.Name = "label3";
            label3.RightToLeft = RightToLeft.Yes;
            label3.Size = new Size(474, 45);
            label3.TabIndex = 5;
            label3.Text = "Library Management System";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(785, 440);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "login";
            Text = "Library Management System";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private Label label1;
        private Label label2;
        private Button button1;
        private Label label3;
    }
}
