namespace SystemUKS_with_Login
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Judul = new Label();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            contextMenuStrip1 = new ContextMenuStrip(components);
            textBoxUser = new TextBox();
            textBoxPass = new TextBox();
            checkBoxShow = new CheckBox();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            pictureBox2 = new PictureBox();
            label5 = new Label();
            checkBox1 = new CheckBox();
            label4 = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // Judul
            // 
            Judul.BackColor = Color.Transparent;
            Judul.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Judul.ImageAlign = ContentAlignment.BottomCenter;
            Judul.Location = new Point(532, 27);
            Judul.Name = "Judul";
            Judul.Size = new Size(141, 36);
            Judul.TabIndex = 0;
            Judul.Text = "Login Page";
            Judul.TextAlign = ContentAlignment.MiddleCenter;
            Judul.Click += Judul_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(450, 174);
            label1.Name = "label1";
            label1.Size = new Size(67, 17);
            label1.TabIndex = 1;
            label1.Text = "Username";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(450, 236);
            label2.Name = "label2";
            label2.Size = new Size(64, 17);
            label2.TabIndex = 2;
            label2.Text = "Password";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Control;
            button1.Location = new Point(450, 315);
            button1.Name = "button1";
            button1.Size = new Size(100, 27);
            button1.TabIndex = 3;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // textBoxUser
            // 
            textBoxUser.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxUser.Location = new Point(450, 194);
            textBoxUser.Name = "textBoxUser";
            textBoxUser.Size = new Size(293, 29);
            textBoxUser.TabIndex = 7;
            textBoxUser.TextChanged += textBoxUser_TextChanged;
            // 
            // textBoxPass
            // 
            textBoxPass.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxPass.Location = new Point(450, 256);
            textBoxPass.Name = "textBoxPass";
            textBoxPass.Size = new Size(293, 29);
            textBoxPass.TabIndex = 8;
            textBoxPass.UseSystemPasswordChar = true;
            textBoxPass.TextChanged += textBoxPass_TextChanged_1;
            // 
            // checkBoxShow
            // 
            checkBoxShow.Location = new Point(629, 307);
            checkBoxShow.Name = "checkBoxShow";
            checkBoxShow.Size = new Size(114, 19);
            checkBoxShow.TabIndex = 9;
            checkBoxShow.Text = "Show Password";
            checkBoxShow.UseVisualStyleBackColor = true;
            checkBoxShow.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(551, 66);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(95, 80);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.Control;
            label3.ForeColor = SystemColors.ControlDark;
            label3.Location = new Point(563, 149);
            label3.Name = "label3";
            label3.Size = new Size(65, 15);
            label3.TabIndex = 11;
            label3.Text = "Get Started";
            label3.Click += label3_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(-2, -83);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(386, 595);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 12;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(390, 9);
            label5.Name = "label5";
            label5.Size = new Size(37, 15);
            label5.TabIndex = 14;
            label5.Text = "-Raya";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(629, 332);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(104, 19);
            checkBox1.TabIndex = 15;
            checkBox1.Text = "Remember me";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.BackColor = SystemColors.Control;
            label4.ForeColor = SystemColors.ControlDark;
            label4.Location = new Point(612, 369);
            label4.Name = "label4";
            label4.Size = new Size(56, 26);
            label4.TabIndex = 16;
            label4.Text = "Sign Up";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            label4.Click += label4_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(532, 375);
            label6.Name = "label6";
            label6.Size = new Size(74, 15);
            label6.TabIndex = 17;
            label6.Text = "New here?   |";
            // 
            // Form1
            // 
            AcceptButton = button1;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(checkBox1);
            Controls.Add(label5);
            Controls.Add(pictureBox2);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Controls.Add(checkBoxShow);
            Controls.Add(textBoxPass);
            Controls.Add(textBoxUser);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Judul);
            Name = "Form1";
            Text = " ";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Judul;
        private Label label1;
        private Label label2;
        private Button button1;
        private ContextMenuStrip contextMenuStrip1;
        private TextBox textBoxUser;
        private TextBox textBoxPass;
        private CheckBox checkBoxShow;
        private PictureBox pictureBox1;
        private Label label3;
        private PictureBox pictureBox2;
        private Label label5;
        private CheckBox checkBox1;
        private Label label4;
        private Label label6;
    }
}
