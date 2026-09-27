namespace form1
{
    public partial class Form1 : Form
    {
        private string registeredUsername = "";
        private string registeredPassword = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void Username_Click(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        // REGISTRATION - SHOW / HIDE PASSWORD
        private void chkRegShowPassword_CheckedChanged_1(object sender, EventArgs e)
        {
            if (chkRegShowPassword.Checked)
            {
                txtRegPassword.PasswordChar = '\0';
            }
            else
            {
                txtRegPassword.PasswordChar = '*';
            }
        }

        // SIGN UP
        private void btnSignUp_Click_1(object sender, EventArgs e)
        {
            registeredUsername = txtRegUsername.Text;
            registeredPassword = txtRegPassword.Text;

            MessageBox.Show(
                "Qeydiyyatdan ugurla kecdiniz!",
                "Registration",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );

            txtRegUsername.Clear();
            txtRegPassword.Clear();
        }

        // SIGN IN - SHOW / HIDE PASSWORD
        private void chkLoginShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chkLoginShowPassword.Checked)
            {
                txtLoginPassword.PasswordChar = '\0';
            }
            else
            {
                txtLoginPassword.PasswordChar = '*';
            }
        }

        // SIGN IN
        private void btnSignIn_Click(object sender, EventArgs e)
        {
            if (txtLoginUsername.Text == registeredUsername &&
                txtLoginPassword.Text == registeredPassword)
            {
                MessageBox.Show(
                    "Ugurla daxil oldunuz!",
                    "Sign In",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
            else
            {
                MessageBox.Show(
                    "Istifadeci adi ve ya sifre yanlisdir!",
                    "Sign In",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }
    }
}

