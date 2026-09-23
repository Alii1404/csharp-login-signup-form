using System;
using System.Drawing;
using System.Windows.Forms;

namespace signinsignupkod
{
    public partial class Form1 : Form
    {
        TextBox txtLoginUsername;
        TextBox txtLoginPassword;

        TextBox txtSignupUsername;
        TextBox txtSignupPassword;

        CheckBox chkLoginPassword;
        CheckBox chkSignupPassword;

        Button btnSignIn;
        Button btnSignUp;

        string registeredUsername = "admin";
        string registeredPassword = "admin12";

        public Form1()
        {
            InitializeComponent();

            CreateLoginPage();
        }

        private void CreateLoginPage()
        {
            this.Text = "Giriş";
            this.Size = new Size(700, 350);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.Teal;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            GroupBox signInGroup = new GroupBox();
            signInGroup.Text = "Giriş";
            signInGroup.ForeColor = Color.White;
            signInGroup.Font = new Font("Arial", 11, FontStyle.Bold);
            signInGroup.Location = new Point(15, 20);
            signInGroup.Size = new Size(278, 260);

            this.Controls.Add(signInGroup);

            Label lblLoginUsername = new Label();
            lblLoginUsername.Text = "İstifadəçi adı";
            lblLoginUsername.ForeColor = Color.White;
            lblLoginUsername.Font = new Font("Arial", 10, FontStyle.Bold);
            lblLoginUsername.Location = new Point(25, 35);
            lblLoginUsername.AutoSize = true;

            signInGroup.Controls.Add(lblLoginUsername);

            txtLoginUsername = new TextBox();
            txtLoginUsername.Location = new Point(23, 58);
            txtLoginUsername.Size = new Size(230, 28);
            txtLoginUsername.Font = new Font("Arial", 11);

            signInGroup.Controls.Add(txtLoginUsername);

            Label lblLoginPassword = new Label();
            lblLoginPassword.Text = "Şifrə";
            lblLoginPassword.ForeColor = Color.White;
            lblLoginPassword.Font = new Font("Arial", 10, FontStyle.Bold);
            lblLoginPassword.Location = new Point(25, 110);
            lblLoginPassword.AutoSize = true;

            signInGroup.Controls.Add(lblLoginPassword);

            txtLoginPassword = new TextBox();
            txtLoginPassword.Location = new Point(23, 133);
            txtLoginPassword.Size = new Size(230, 28);
            txtLoginPassword.Font = new Font("Arial", 11);
            txtLoginPassword.UseSystemPasswordChar = true;

            signInGroup.Controls.Add(txtLoginPassword);

            chkLoginPassword = new CheckBox();
            chkLoginPassword.Text = "Şifrəni göstər";
            chkLoginPassword.ForeColor = Color.White;
            chkLoginPassword.Font = new Font("Arial", 10, FontStyle.Bold);
            chkLoginPassword.Location = new Point(23, 173);
            chkLoginPassword.AutoSize = true;

            chkLoginPassword.CheckedChanged += LoginPassword_CheckedChanged;

            signInGroup.Controls.Add(chkLoginPassword);

            btnSignIn = new Button();
            btnSignIn.Text = "Giriş et";
            btnSignIn.Location = new Point(42, 210);
            btnSignIn.Size = new Size(190, 35);
            btnSignIn.BackColor = Color.Navy;
            btnSignIn.ForeColor = Color.White;
            btnSignIn.FlatStyle = FlatStyle.Flat;
            btnSignIn.Font = new Font("Arial", 10, FontStyle.Bold);
            btnSignIn.Cursor = Cursors.Hand;

            btnSignIn.Click += BtnSignIn_Click;

            signInGroup.Controls.Add(btnSignIn);

            GroupBox signUpGroup = new GroupBox();
            signUpGroup.Text = "Qeydiyyat";
            signUpGroup.ForeColor = Color.White;
            signUpGroup.Font = new Font("Arial", 11, FontStyle.Bold);
            signUpGroup.Location = new Point(355, 20);
            signUpGroup.Size = new Size(278, 260);

            this.Controls.Add(signUpGroup);

            Label lblSignupUsername = new Label();
            lblSignupUsername.Text = "İstifadəçi adı";
            lblSignupUsername.ForeColor = Color.White;
            lblSignupUsername.Font = new Font("Arial", 10, FontStyle.Bold);
            lblSignupUsername.Location = new Point(25, 35);
            lblSignupUsername.AutoSize = true;

            signUpGroup.Controls.Add(lblSignupUsername);

            txtSignupUsername = new TextBox();
            txtSignupUsername.Location = new Point(23, 58);
            txtSignupUsername.Size = new Size(230, 28);
            txtSignupUsername.Font = new Font("Arial", 11);

            signUpGroup.Controls.Add(txtSignupUsername);

            Label lblSignupPassword = new Label();
            lblSignupPassword.Text = "Şifrə";
            lblSignupPassword.ForeColor = Color.White;
            lblSignupPassword.Font = new Font("Arial", 10, FontStyle.Bold);
            lblSignupPassword.Location = new Point(25, 110);
            lblSignupPassword.AutoSize = true;

            signUpGroup.Controls.Add(lblSignupPassword);

            txtSignupPassword = new TextBox();
            txtSignupPassword.Location = new Point(23, 133);
            txtSignupPassword.Size = new Size(230, 28);
            txtSignupPassword.Font = new Font("Arial", 11);
            txtSignupPassword.UseSystemPasswordChar = true;

            signUpGroup.Controls.Add(txtSignupPassword);

            chkSignupPassword = new CheckBox();
            chkSignupPassword.Text = "Şifrəni göstər";
            chkSignupPassword.ForeColor = Color.White;
            chkSignupPassword.Font = new Font("Arial", 10, FontStyle.Bold);
            chkSignupPassword.Location = new Point(23, 173);
            chkSignupPassword.AutoSize = true;

            chkSignupPassword.CheckedChanged += SignupPassword_CheckedChanged;

            signUpGroup.Controls.Add(chkSignupPassword);

            btnSignUp = new Button();
            btnSignUp.Text = "Qeydiyyatdan keç";
            btnSignUp.Location = new Point(42, 210);
            btnSignUp.Size = new Size(190, 35);
            btnSignUp.BackColor = Color.Navy;
            btnSignUp.ForeColor = Color.White;
            btnSignUp.FlatStyle = FlatStyle.Flat;
            btnSignUp.Font = new Font("Arial", 10, FontStyle.Bold);
            btnSignUp.Cursor = Cursors.Hand;

            btnSignUp.Click += BtnSignUp_Click;

            signUpGroup.Controls.Add(btnSignUp);
        }

        private void LoginPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtLoginPassword.UseSystemPasswordChar =
                !chkLoginPassword.Checked;
        }

        private void SignupPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtSignupPassword.UseSystemPasswordChar =
                !chkSignupPassword.Checked;
        }

        private void BtnSignIn_Click(object sender, EventArgs e)
        {
            string username = txtLoginUsername.Text;
            string password = txtLoginPassword.Text;

            if (username == "" || password == "")
            {
                MessageBox.Show(
                    "İstifadəçi adı və şifrəni daxil edin.",
                    "Xəbərdarlıq",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            if (username == registeredUsername &&
                password == registeredPassword)
            {
                MessageBox.Show(
                    "Giriş uğurludur!",
                    "Uğurlu",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(
                    "İstifadəçi adı və ya şifrə yanlışdır.",
                    "Xəta",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void BtnSignUp_Click(object sender, EventArgs e)
        {
            string username = txtSignupUsername.Text;
            string password = txtSignupPassword.Text;

            if (username == "" || password == "")
            {
                MessageBox.Show(
                    "İstifadəçi adı və şifrəni daxil edin.",
                    "Xəbərdarlıq",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            registeredUsername = username;
            registeredPassword = password;

            MessageBox.Show(
                "Qeydiyyat uğurla tamamlandı!",
                "Uğurlu",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            txtSignupUsername.Clear();
            txtSignupPassword.Clear();
        }
    }
}