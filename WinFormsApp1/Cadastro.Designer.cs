namespace WinFormsApp1
{
    partial class Cadastro
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
            Conteiner_1 = new Panel();
            label4 = new Label();
            lista_Cadastro = new ListBox();
            btn_Limpar = new Button();
            btn_Excluir = new Button();
            btn_Cadastro = new Button();
            groupBox1 = new GroupBox();
            radioO = new RadioButton();
            radioF = new RadioButton();
            radioM = new RadioButton();
            checNDeficiencia = new CheckBox();
            checkDeficiencia = new CheckBox();
            mask_Telefone = new MaskedTextBox();
            ListaCivil = new ComboBox();
            label5 = new Label();
            data_Nascimento = new DateTimePicker();
            Telefone = new Label();
            label3 = new Label();
            textoNome = new TextBox();
            label2 = new Label();
            label1 = new Label();
            Conteiner_1.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // Conteiner_1
            // 
            Conteiner_1.Controls.Add(label4);
            Conteiner_1.Controls.Add(lista_Cadastro);
            Conteiner_1.Controls.Add(btn_Limpar);
            Conteiner_1.Controls.Add(btn_Excluir);
            Conteiner_1.Controls.Add(btn_Cadastro);
            Conteiner_1.Controls.Add(groupBox1);
            Conteiner_1.Controls.Add(checNDeficiencia);
            Conteiner_1.Controls.Add(checkDeficiencia);
            Conteiner_1.Controls.Add(mask_Telefone);
            Conteiner_1.Controls.Add(ListaCivil);
            Conteiner_1.Controls.Add(label5);
            Conteiner_1.Controls.Add(data_Nascimento);
            Conteiner_1.Controls.Add(Telefone);
            Conteiner_1.Controls.Add(label3);
            Conteiner_1.Controls.Add(textoNome);
            Conteiner_1.Controls.Add(label2);
            Conteiner_1.Controls.Add(label1);
            Conteiner_1.Dock = DockStyle.Fill;
            Conteiner_1.Location = new Point(0, 0);
            Conteiner_1.Name = "Conteiner_1";
            Conteiner_1.Size = new Size(1008, 681);
            Conteiner_1.TabIndex = 0;
            Conteiner_1.Click += Conteiner_1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.Window;
            label4.Location = new Point(379, 317);
            label4.Name = "label4";
            label4.Size = new Size(149, 15);
            label4.TabIndex = 19;
            label4.Text = "Possui alguma deficiência?";
            // 
            // lista_Cadastro
            // 
            lista_Cadastro.BackColor = SystemColors.ControlDark;
            lista_Cadastro.FormattingEnabled = true;
            lista_Cadastro.ItemHeight = 15;
            lista_Cadastro.Location = new Point(251, 587);
            lista_Cadastro.Name = "lista_Cadastro";
            lista_Cadastro.Size = new Size(555, 94);
            lista_Cadastro.TabIndex = 18;
            lista_Cadastro.MouseClick += lista_Cadastro_MouseClick;
            // 
            // btn_Limpar
            // 
            btn_Limpar.Location = new Point(733, 493);
            btn_Limpar.Name = "btn_Limpar";
            btn_Limpar.Size = new Size(209, 82);
            btn_Limpar.TabIndex = 17;
            btn_Limpar.Text = "Limpar";
            btn_Limpar.UseVisualStyleBackColor = true;
            btn_Limpar.Click += btn_Limpar_Click;
            // 
            // btn_Excluir
            // 
            btn_Excluir.Location = new Point(429, 493);
            btn_Excluir.Name = "btn_Excluir";
            btn_Excluir.Size = new Size(209, 82);
            btn_Excluir.TabIndex = 16;
            btn_Excluir.Text = "Excluir";
            btn_Excluir.UseVisualStyleBackColor = true;
            btn_Excluir.Click += btn_Excluir_Click;
            // 
            // btn_Cadastro
            // 
            btn_Cadastro.Location = new Point(125, 493);
            btn_Cadastro.Name = "btn_Cadastro";
            btn_Cadastro.Size = new Size(209, 82);
            btn_Cadastro.TabIndex = 15;
            btn_Cadastro.Text = "Cadastrar / Alterar";
            btn_Cadastro.UseVisualStyleBackColor = true;
            btn_Cadastro.Click += btn_Cadastro_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioO);
            groupBox1.Controls.Add(radioF);
            groupBox1.Controls.Add(radioM);
            groupBox1.ForeColor = SystemColors.Window;
            groupBox1.Location = new Point(377, 362);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(319, 125);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            groupBox1.Text = "Sexo";
            // 
            // radioO
            // 
            radioO.AutoSize = true;
            radioO.ForeColor = SystemColors.Window;
            radioO.Location = new Point(14, 79);
            radioO.Name = "radioO";
            radioO.Size = new Size(61, 19);
            radioO.TabIndex = 2;
            radioO.TabStop = true;
            radioO.Text = "Outros";
            radioO.UseVisualStyleBackColor = true;
            // 
            // radioF
            // 
            radioF.AutoSize = true;
            radioF.ForeColor = SystemColors.Window;
            radioF.Location = new Point(14, 51);
            radioF.Name = "radioF";
            radioF.Size = new Size(75, 19);
            radioF.TabIndex = 1;
            radioF.TabStop = true;
            radioF.Text = "Feminino";
            radioF.UseVisualStyleBackColor = true;
            // 
            // radioM
            // 
            radioM.AutoSize = true;
            radioM.ForeColor = SystemColors.Window;
            radioM.Location = new Point(15, 23);
            radioM.Name = "radioM";
            radioM.Size = new Size(80, 19);
            radioM.TabIndex = 0;
            radioM.TabStop = true;
            radioM.Text = "Masculino";
            radioM.UseVisualStyleBackColor = true;
            // 
            // checNDeficiencia
            // 
            checNDeficiencia.AutoSize = true;
            checNDeficiencia.ForeColor = SystemColors.Window;
            checNDeficiencia.Location = new Point(502, 337);
            checNDeficiencia.Name = "checNDeficiencia";
            checNDeficiencia.Size = new Size(144, 19);
            checNDeficiencia.TabIndex = 13;
            checNDeficiencia.Text = "Não Tenho Deficiência";
            checNDeficiencia.UseVisualStyleBackColor = true;
            // 
            // checkDeficiencia
            // 
            checkDeficiencia.AutoSize = true;
            checkDeficiencia.ForeColor = SystemColors.Window;
            checkDeficiencia.Location = new Point(377, 337);
            checkDeficiencia.Name = "checkDeficiencia";
            checkDeficiencia.Size = new Size(119, 19);
            checkDeficiencia.TabIndex = 12;
            checkDeficiencia.Text = "Tenho Deficiência";
            checkDeficiencia.UseVisualStyleBackColor = true;
            // 
            // mask_Telefone
            // 
            mask_Telefone.Location = new Point(377, 284);
            mask_Telefone.Mask = "(99) 99999-9999";
            mask_Telefone.Name = "mask_Telefone";
            mask_Telefone.Size = new Size(319, 23);
            mask_Telefone.TabIndex = 11;
            // 
            // ListaCivil
            // 
            ListaCivil.FormattingEnabled = true;
            ListaCivil.ImeMode = ImeMode.NoControl;
            ListaCivil.Location = new Point(377, 228);
            ListaCivil.Name = "ListaCivil";
            ListaCivil.Size = new Size(319, 23);
            ListaCivil.TabIndex = 10;
            ListaCivil.Text = "Selecione uma opção";
            ListaCivil.KeyPress += ListaCivil_KeyPress;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Unispace", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.Window;
            label5.Location = new Point(383, 134);
            label5.Name = "label5";
            label5.Size = new Size(189, 19);
            label5.TabIndex = 8;
            label5.Text = "Data de Nascimento";
            // 
            // data_Nascimento
            // 
            data_Nascimento.ImeMode = ImeMode.NoControl;
            data_Nascimento.Location = new Point(377, 164);
            data_Nascimento.Name = "data_Nascimento";
            data_Nascimento.RightToLeft = RightToLeft.No;
            data_Nascimento.Size = new Size(319, 23);
            data_Nascimento.TabIndex = 7;
            data_Nascimento.Value = new DateTime(2023, 7, 16, 0, 0, 0, 0);
            // 
            // Telefone
            // 
            Telefone.AutoSize = true;
            Telefone.Font = new Font("Unispace", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            Telefone.ForeColor = SystemColors.Window;
            Telefone.Location = new Point(383, 262);
            Telefone.Name = "Telefone";
            Telefone.Size = new Size(89, 19);
            Telefone.TabIndex = 5;
            Telefone.Text = "Telefone";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Unispace", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.Window;
            label3.Location = new Point(383, 198);
            label3.Name = "label3";
            label3.Size = new Size(129, 19);
            label3.TabIndex = 3;
            label3.Text = "Estado Civíl";
            // 
            // textoNome
            // 
            textoNome.AllowDrop = true;
            textoNome.ForeColor = SystemColors.WindowText;
            textoNome.ImeMode = ImeMode.NoControl;
            textoNome.Location = new Point(377, 100);
            textoNome.Name = "textoNome";
            textoNome.Size = new Size(319, 23);
            textoNome.TabIndex = 2;
            textoNome.Text = "Nome Completo";
            textoNome.Enter += textBox1_Enter;
            textoNome.Leave += textBox1_Leave;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Unispace", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Window;
            label2.Location = new Point(383, 70);
            label2.Name = "label2";
            label2.Size = new Size(139, 19);
            label2.TabIndex = 1;
            label2.Text = "Nome Completo";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Unispace", 23.9999962F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Window;
            label1.Location = new Point(461, 9);
            label1.Name = "label1";
            label1.Size = new Size(177, 39);
            label1.TabIndex = 0;
            label1.Text = "Cadastro";
            // 
            // Cadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 0, 64);
            ClientSize = new Size(1008, 681);
            Controls.Add(Conteiner_1);
            Name = "Cadastro";
            Text = "Cadastro";
            Conteiner_1.ResumeLayout(false);
            Conteiner_1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel Conteiner_1;
        private Label label1;
        private Label label3;
        private TextBox textoNome;
        private Label label2;
        private Label label5;
        private DateTimePicker data_Nascimento;
        private Label Telefone;
        private ComboBox ListaCivil;
        private MaskedTextBox mask_Telefone;
        private CheckBox checNDeficiencia;
        private CheckBox checkDeficiencia;
        private Button btn_Limpar;
        private Button btn_Excluir;
        private Button btn_Cadastro;
        private GroupBox groupBox1;
        private RadioButton radioO;
        private RadioButton radioF;
        private RadioButton radioM;
        private ListBox lista_Cadastro;
        private Label label4;
    }
}