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

            if (username == "" || password == "")
            {
                MessageBox.Show("Username dan Password harus diisi!");
                return;
            }

            foreach (var user in UserStorage.Users)
            {
                if (user.Username == username)
                {
                    MessageBox.Show("Username sudah digunakan!");
                    return;
                }
            }

            UserStorage.Users.Add(new User(username, password));

            MessageBox.Show("Sign Up berhasil!");
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Confirm_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
