using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WinFormsApp1.JanelasDiversas
{
    public partial class Namoro : Form
    {
        public Namoro()
        {
            InitializeComponent();
        }

        private void Btn_Sim_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ebaa estamos \u0022NAMORANDO\u0022");
            Close();

        }
        private void Namoro_Load(object sender, EventArgs e)
        {

        }

        private void Btn_Nao_Click(object sender, EventArgs e)
        {
            Posicao pos = new Posicao();
            Random ran = new Random();
            pos.x = ran.Next(0, this.ClientSize.Width - Btn_Nao.Width);
            pos.y = ran.Next(0, this.ClientSize.Height - Btn_Nao.Height);
            Btn_Nao.Location = new Point(pos.x, pos.y);

            Texto_Namoro.Visible = false;
        }
    }
}
