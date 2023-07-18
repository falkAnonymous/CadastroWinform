using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class Pessoa
    {
        public string? Nome { get; set; }
        public string? Data_Nascimento { get; set;}
        public string? Estado_Civil { get; set;}
        public string? Telefone { get; set;}
        public bool TDeficiencia { get; set;}//bool
        public bool NDeficiencia { get; set;}//bool
        public char Sexo { get; set; }


        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(Nome+", ");
            sb.Append(Data_Nascimento + ", ");
            sb.Append(Estado_Civil + ", ");
            sb.Append(Telefone + ", ");
            if (TDeficiencia)
            {
                sb.Append("Com deficiência ");
            }
            else if (NDeficiencia)
            {
                sb.Append("Sem deficiência ");
            }
            else
            {
                sb.Append("Não informado ");
            }
            sb.Append(Sexo);
            return sb.ToString();
        }

    }
}
