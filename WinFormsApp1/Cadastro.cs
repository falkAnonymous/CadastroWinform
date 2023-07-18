using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Cadastro : Form
    {
        List<Pessoa> pessoas;
        public Cadastro()
        {
            InitializeComponent();
            pessoas = new List<Pessoa>();

            ListaCivil.Items.Add("Solteiro(a)");
            ListaCivil.Items.Add("Casado(a)");
            ListaCivil.Items.Add("Viúvo(a)");
            ListaCivil.Items.Add("Divorciado(a)");
            ListaCivil.Items.Add("União estáve");
        }


        #region Botoes
        private void btn_Cadastro_Click(object sender, EventArgs e)
        {
            int index = -1;
            string Nome = "Preencha o campo Nome";
            string Telefone = "Preencha o campo Telefone";

            foreach (Pessoa obj in pessoas)
            {
                if (obj.Nome == textoNome.Text)
                {
                    index = pessoas.IndexOf(obj);
                }
            }

            if (textoNome.Text == string.Empty)
            {
                MessageBox.Show(Nome);
                textoNome.Focus();
                return;//Serve para finalizar a execução do metodo
            }

            if (mask_Telefone.Text == "(  )      -")
            {
                MessageBox.Show(Telefone);
                mask_Telefone.Focus();
                return;
            }
            if (ListaCivil.SelectedItem == null)
            {
                MessageBox.Show("Ta de Sacanagem 06");
                ListaCivil.Focus();
                return;
            }

            char sexo;

            if (radioM.Checked)
            {
                sexo = 'M';
            }
            else if (radioF.Checked)
            {
                sexo = 'F';
            }
            else
            {
                sexo = 'o';
            }

            Pessoa pessoa = new Pessoa();
            pessoa.Nome = textoNome.Text;
            pessoa.Data_Nascimento = data_Nascimento.Text;
            pessoa.Estado_Civil = ListaCivil.SelectedItem.ToString();//SelectItms referece ao item selecionado na lista
            pessoa.Telefone = mask_Telefone.Text;
            pessoa.TDeficiencia = checkDeficiencia.Checked;
            pessoa.NDeficiencia = checNDeficiencia.Checked;
            pessoa.Sexo = sexo;


            if (index < 0) // Novo Cadastro
            {
                pessoas.Add(pessoa);
            }
            else//Pessoa Já cadastrado
            {
                pessoas[index] = pessoa;
            }

            btn_Limpar_Click(btn_Limpar, EventArgs.Empty);
            RlistaCadastro();
        }

        private void btn_Excluir_Click(object sender, EventArgs e)// Excluir da lista de Cadastro
        {
            int indice = lista_Cadastro.SelectedIndex;

            if (indice > -1)
            {
                pessoas.RemoveAt(indice);

            }
            RlistaCadastro();

        }

        private void btn_Limpar_Click(object sender, EventArgs e)
        {
            textoNome.Text = "Nome Completo";
            data_Nascimento.Text = string.Empty; // Volta para o valor atual
            ListaCivil.SelectedItem = null;
            ListaCivil.Text = "Selecione uma opção";
            mask_Telefone.Text = string.Empty;
            checkDeficiencia.Checked = false;
            checNDeficiencia.Checked = false;
            radioF.Checked = false;
            radioM.Checked = false;
            radioO.Checked = false;
        }

        #endregion

        #region Eventos
        //Se o Mouse  clicar dentro do textbox o Placeholder vai sumir
        private void textBox1_Enter(object sender, EventArgs e)
        {

            if (textoNome.Text == "Nome Completo")
            {
                textoNome.Text = string.Empty;
            }
        }
        //Se o Mouse  clicar fora do textbox o Placeholder vai aparecer
        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textoNome.Text == string.Empty)
            {
                textoNome.Text = "Nome Completo";

            }


        }
        //Se Clicarem fora dos campos de preenchimento nenhum campo sera selecionado para ação
        private void Conteiner_1_Click(object sender, EventArgs e)
        {
            Conteiner_1.Focus();
        }
        // Esse método impede que o usuario possa alterar o que esta sendo exibido no comboBox
        private void ListaCivil_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true; // Essa ação impede que o usuario possa alterar o que esta sendo exibido no comboBox
        }
        //Esse evento faz com que ao clicar na lista na conta criada, os dados possam aparecer nos campos de preenchimentos
        private void lista_Cadastro_MouseClick(object sender, MouseEventArgs e)
        {
            int index = lista_Cadastro.SelectedIndex;
            Pessoa list_pessoa = pessoas[index];

            if (index > -1)
            {

                textoNome.Text = list_pessoa.Nome;
                data_Nascimento.Text = list_pessoa.Data_Nascimento;
                ListaCivil.SelectedItem = list_pessoa.Estado_Civil;
                mask_Telefone.Text = list_pessoa.Telefone;
                checkDeficiencia.Checked = list_pessoa.TDeficiencia;
                checNDeficiencia.Checked = list_pessoa.NDeficiencia;

            }

            switch (list_pessoa.Sexo)
            {
                case 'F':
                    radioF.Checked = true;
                    break;

                case 'M':
                    radioM.Checked = true;
                    break;

                case 'O':
                    radioO.Checked = true;
                    break;

                default:
                    radioF.Checked = false;
                    radioM.Checked = false;
                    radioO.Checked = false;
                    break;
            }



        }

        #endregion

        #region Métodos Ação Individual
        private void RlistaCadastro()//Retorna as informações cadastradas
        {
            lista_Cadastro.Items.Clear();
            foreach (Pessoa obj in pessoas)
            {
                lista_Cadastro.Items.Add(obj + ".");
            }
        }

        #endregion
    }
}
