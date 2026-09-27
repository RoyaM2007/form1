namespace form1
{
    partial class Form1
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
            btnSignUp = new Button();
            txtRegUsername = new TextBox();
            Username = new Label();
            groupBox1 = new GroupBox();
            label1 = new Label();
            txtRegPassword = new TextBox();
            chkRegShowPassword = new CheckBox();
            label2 = new Label();
            groupBox2 = new GroupBox();
            chkLoginShowPassword = new CheckBox();
            label3 = new Label();
            btnSignIn = new Button();
            txtLoginPassword = new TextBox();
            txtLoginUsername = new TextBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // btnSignUp
            // 
            btnSignUp.BackColor = Color.White;
            btnSignUp.Font = new Font("Segoe UI Historic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSignUp.Location = new Point(30, 268);
            btnSignUp.Name = "btnSignUp";
            btnSignUp.Size = new Size(94, 29);
            btnSignUp.TabIndex = 0;
            btnSignUp.Text = "sign up";
            btnSignUp.UseVisualStyleBackColor = false;
            btnSignUp.Click += btnSignUp_Click_1;
            // 
            // txtRegUsername
            // 
            txtRegUsername.Location = new Point(18, 80);
            txtRegUsername.Name = "txtRegUsername";
            txtRegUsername.PlaceholderText = "username";
            txtRegUsername.Size = new Size(176, 27);
            txtRegUsername.TabIndex = 1;
            // 
            // Username
            // 
            Username.AutoSize = true;
            Username.Location = new Point(18, 48);
            Username.Name = "Username";
            Username.Size = new Size(75, 20);
            Username.TabIndex = 2;
            Username.Text = "Username";
            Username.Click += Username_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtRegPassword);
            groupBox1.Controls.Add(chkRegShowPassword);
            groupBox1.Controls.Add(txtRegUsername);
            groupBox1.Controls.Add(btnSignUp);
            groupBox1.Controls.Add(Username);
            groupBox1.ForeColor = SystemColors.ActiveCaptionText;
            groupBox1.Location = new Point(26, 21);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(250, 339);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Registiration";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 134);
            label1.Name = "label1";
            label1.Size = new Size(70, 20);
            label1.TabIndex = 5;
            label1.Text = "Password";
            label1.Click += label1_Click;
            // 
            // txtRegPassword
            // 
            txtRegPassword.Location = new Point(18, 168);
            txtRegPassword.Name = "txtRegPassword";
            txtRegPassword.PasswordChar = '*';
            txtRegPassword.PlaceholderText = "password";
            txtRegPassword.Size = new Size(176, 27);
            txtRegPassword.TabIndex = 4;
            txtRegPassword.TextChanged += textBox2_TextChanged;
            // 
            // chkRegShowPassword
            // 
            chkRegShowPassword.AutoSize = true;
            chkRegShowPassword.Location = new Point(18, 215);
            chkRegShowPassword.Name = "chkRegShowPassword";
            chkRegShowPassword.Size = new Size(157, 24);
            chkRegShowPassword.TabIndex = 3;
            chkRegShowPassword.Text = "show me password";
            chkRegShowPassword.UseVisualStyleBackColor = true;
            chkRegShowPassword.CheckedChanged += chkRegShowPassword_CheckedChanged_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(39, 48);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 4;
            label2.Text = "Username";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(chkLoginShowPassword);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(btnSignIn);
            groupBox2.Controls.Add(txtLoginPassword);
            groupBox2.Controls.Add(txtLoginUsername);
            groupBox2.Controls.Add(label2);
            groupBox2.Location = new Point(324, 21);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(250, 339);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Sign In";
            // 
            // chkLoginShowPassword
            // 
            chkLoginShowPassword.AutoSize = true;
            chkLoginShowPassword.Location = new Point(39, 215);
            chkLoginShowPassword.Name = "chkLoginShowPassword";
            chkLoginShowPassword.Size = new Size(157, 24);
            chkLoginShowPassword.TabIndex = 9;
            chkLoginShowPassword.Text = "show me password";
            chkLoginShowPassword.UseVisualStyleBackColor = true;
            chkLoginShowPassword.CheckedChanged += chkLoginShowPassword_CheckedChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(39, 134);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 8;
            label3.Text = "Password";
            label3.Click += label3_Click;
            // 
            // btnSignIn
            // 
            btnSignIn.Location = new Point(53, 268);
            btnSignIn.Name = "btnSignIn";
            btnSignIn.Size = new Size(94, 29);
            btnSignIn.TabIndex = 7;
            btnSignIn.Text = "Sign in";
            btnSignIn.UseVisualStyleBackColor = true;
            btnSignIn.Click += btnSignIn_Click;
            // 
            // txtLoginPassword
            // 
            txtLoginPassword.Location = new Point(39, 168);
            txtLoginPassword.Name = "txtLoginPassword";
            txtLoginPassword.PasswordChar = '*';
            txtLoginPassword.PlaceholderText = "password";
            txtLoginPassword.Size = new Size(125, 27);
            txtLoginPassword.TabIndex = 6;
            // 
            // txtLoginUsername
            // 
            txtLoginUsername.Location = new Point(39, 80);
            txtLoginUsername.Name = "txtLoginUsername";
            txtLoginUsername.PlaceholderText = "username";
            txtLoginUsername.Size = new Size(125, 27);
            txtLoginUsername.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Teal;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnSignUp;
        private TextBox txtRegUsername;
        private Label Username;
        private GroupBox groupBox1;
        private CheckBox chkRegShowPassword;
        private Label label1;
        private TextBox txtRegPassword;
        private Label label2;
        private GroupBox groupBox2;
        private Label label3;
        private Button btnSignIn;
        private TextBox txtLoginPassword;
        private TextBox txtLoginUsername;
        private CheckBox chkLoginShowPassword;
    }
}
