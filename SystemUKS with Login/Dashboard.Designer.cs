namespace SystemUKS_with_Login
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            panelside = new Panel();
            pictureBox1 = new PictureBox();
            panelup = new Panel();
            button5 = new Button();
            label1 = new Label();
            mainpanel = new Panel();
            panelside.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelup.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.DimGray;
            button1.BackgroundImageLayout = ImageLayout.Zoom;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Century", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(0, 140);
            button1.Name = "button1";
            button1.RightToLeft = RightToLeft.No;
            button1.Size = new Size(200, 30);
            button1.TabIndex = 2;
            button1.Text = "Petugas";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.DimGray;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Century", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(100, 390);
            button2.Name = "button2";
            button2.Size = new Size(100, 30);
            button2.TabIndex = 4;
            button2.Text = "  Log out";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackgroundImageLayout = ImageLayout.Zoom;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Century", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.White;
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(0, 176);
            button3.Name = "button3";
            button3.Size = new Size(200, 30);
            button3.TabIndex = 9;
            button3.Text = "Pasien";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.DimGray;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Century", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.White;
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.ImageAlign = ContentAlignment.MiddleLeft;
            button4.Location = new Point(0, 212);
            button4.Name = "button4";
            button4.Size = new Size(200, 30);
            button4.TabIndex = 10;
            button4.Text = "Ruang Logistik";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // panelside
            // 
            panelside.BackColor = Color.DimGray;
            panelside.Controls.Add(pictureBox1);
            panelside.Controls.Add(button4);
            panelside.Controls.Add(button2);
            panelside.Controls.Add(button3);
            panelside.Controls.Add(button1);
            panelside.Dock = DockStyle.Left;
            panelside.Location = new Point(0, 30);
            panelside.Name = "panelside";
            panelside.Size = new Size(200, 420);
            panelside.TabIndex = 11;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(200, 113);
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // panelup
            // 
            panelup.BackColor = Color.Gray;
            panelup.Controls.Add(button5);
            panelup.Controls.Add(label1);
            panelup.Dock = DockStyle.Top;
            panelup.Location = new Point(0, 0);
            panelup.Name = "panelup";
            panelup.Size = new Size(800, 30);
            panelup.TabIndex = 12;
            // 
            // button5
            // 
            button5.BackColor = Color.DimGray;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Century", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.ForeColor = Color.White;
            button5.Location = new Point(721, 4);
            button5.Name = "button5";
            button5.Size = new Size(33, 23);
            button5.TabIndex = 1;
            button5.Text = "X";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // label1
            // 
            label1.BackColor = Color.DimGray;
            label1.Font = new Font("Century", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Transparent;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(200, 30);
            label1.TabIndex = 0;
            label1.Text = "Dashboard";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // mainpanel
            // 
            mainpanel.Dock = DockStyle.Fill;
            mainpanel.Location = new Point(200, 30);
            mainpanel.Name = "mainpanel";
            mainpanel.Size = new Size(600, 420);
            mainpanel.TabIndex = 13;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(mainpanel);
            Controls.Add(panelside);
            Controls.Add(panelup);
            Name = "Dashboard";
            Text = "Dashboard";
            Load += Dashboard_Load;
            panelside.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelup.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Panel panelside;
        private Panel panelup;
        private Panel mainpanel;
        private PictureBox pictureBox1;
        private Label label1;
        private Button button5;
    }
}