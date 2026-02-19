using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SystemUKS_with_Login
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            Form1 login = new Form1();
            login.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;
            string ConfirmPassword = Confirm.Text;

            if (username == "" || password == "" || ConfirmPassword == "")
            {
                MessageBox.Show("Username dan Password harus diisi twin");
                return;
            }

            if (password != ConfirmPassword)
            {
                MessageBox.Show("Password tidak sama bro");
                return;
            }


            foreach (var user in UserStorage.Users)
            {
                if (user.Username == username)
                {
                    MessageBox.Show("Username sudah digunakan dawg");
                    return;
                }
            }

            UserStorage.Users.Add(new User(username, password));

            MessageBox.Show("Sign Up berhasil");

            Form1 login = new Form1();
            login.Show();
            this.Hide();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Confirm_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtPassword.UseSystemPasswordChar = false;
                Confirm.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
                Confirm.UseSystemPasswordChar = true;
            }
        }
    }
}
