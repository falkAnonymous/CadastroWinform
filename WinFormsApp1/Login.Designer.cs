namespace WinFormsApp1
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            textBox1 = new TextBox();
            checkBox1 = new CheckBox();
            Llogin = new Label();
            button1 = new Button();
            textBox2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            linkLabel1 = new LinkLabel();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Window;
            textBox1.Location = new Point(246, 164);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(290, 23);
            textBox1.TabIndex = 0;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(350, 298);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(87, 19);
            checkBox1.TabIndex = 1;
            checkBox1.Text = "Salva senha";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // Llogin
            // 
            Llogin.AutoSize = true;
            Llogin.Font = new Font("Unispace", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point);
            Llogin.Location = new Point(360, 118);
            Llogin.Name = "Llogin";
            Llogin.Size = new Size(77, 25);
            Llogin.TabIndex = 2;
            Llogin.Text = "Login";
            Llogin.Click += Llogin_Click;
            // 
            // button1
            // 
            button1.Location = new Point(246, 338);
            button1.Name = "button1";
            button1.Size = new Size(290, 49);
            button1.TabIndex = 3;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(246, 254);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(290, 23);
            textBox2.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Unispace", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(360, 207);
            label1.Name = "label1";
            label1.Size = new Size(77, 25);
            label1.TabIndex = 5;
            label1.Text = "Senha";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(338, 390);
            label2.Name = "label2";
            label2.Size = new Size(118, 15);
            label2.TabIndex = 6;
            label2.Text = "Esqueceu sua Senha?";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(347, 405);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(98, 15);
            linkLabel1.TabIndex = 7;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Recuperar Senha!";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(360, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(85, 80);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 0, 192);
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(linkLabel1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(button1);
            Controls.Add(Llogin);
            Controls.Add(checkBox1);
            Controls.Add(textBox1);
            Name = "Login";
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private CheckBox checkBox1;
        private Label Llogin;
        private Button button1;
        private TextBox textBox2;
        private Label label1;
        private Label label2;
        private LinkLabel linkLabel1;
        private PictureBox pictureBox1;
    }
}