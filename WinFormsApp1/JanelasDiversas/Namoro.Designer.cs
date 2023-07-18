namespace WinFormsApp1.JanelasDiversas
{
    partial class Namoro
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
            Btn_Sim = new Button();
            Btn_Nao = new Button();
            Texto_Namoro = new Label();
            SuspendLayout();
            // 
            // Btn_Sim
            // 
            Btn_Sim.Location = new Point(288, 225);
            Btn_Sim.Name = "Btn_Sim";
            Btn_Sim.Size = new Size(75, 23);
            Btn_Sim.TabIndex = 0;
            Btn_Sim.Text = "Sim";
            Btn_Sim.UseVisualStyleBackColor = true;
            Btn_Sim.Click += Btn_Sim_Click;
            // 
            // Btn_Nao
            // 
            Btn_Nao.Location = new Point(420, 225);
            Btn_Nao.Name = "Btn_Nao";
            Btn_Nao.Size = new Size(75, 23);
            Btn_Nao.TabIndex = 1;
            Btn_Nao.Text = "Não";
            Btn_Nao.UseVisualStyleBackColor = true;
            Btn_Nao.Click += Btn_Nao_Click;
            // 
            // Texto_Namoro
            // 
            Texto_Namoro.AutoSize = true;
            Texto_Namoro.Font = new Font("Audiowide", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            Texto_Namoro.Location = new Point(195, 114);
            Texto_Namoro.Name = "Texto_Namoro";
            Texto_Namoro.Size = new Size(466, 45);
            Texto_Namoro.TabIndex = 3;
            Texto_Namoro.Text = "Quer Namorar Comigo?";
            // 
            // Namoro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Texto_Namoro);
            Controls.Add(Btn_Nao);
            Controls.Add(Btn_Sim);
            Name = "Namoro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Namoro";
            Load += Namoro_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Btn_Sim;
        private Button Btn_Nao;
        private Label Texto_Namoro;
    }
}