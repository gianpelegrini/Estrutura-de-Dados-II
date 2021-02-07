using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewED_TP2.Models
{
    class Contato
    {
        private string email;
        private string nome;
        private string telefone;
        private Data nasc;

        public Contato()
        {
            email = "";
            nome = "";
            telefone = "";
            nasc = new Data();
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public string Telefone
        {
            get { return telefone; }
            set { telefone = value; }
        }

        public Data Nasc
        {
            get { return nasc; }
            set { nasc = value; }
        }

        public int getIdade()
        {
            DateTime hoje = DateTime.Today;
            DateTime nascimento = DateTime.Parse(Nasc.ToString());

            int idade = hoje.Year - nascimento.Year;
            if (hoje.Month <= nascimento.Month && hoje.Day <= nascimento.Day)
            {
                idade--;
            }
            return idade;
        }

        public override string ToString()
        {
            return "Nome: " + nome + " || Email: " + email + " || Telefone: " + telefone + " || Idade: " + getIdade();
        }

        public override bool Equals(object o)
        {
            return this.Nome.Equals(((Contato)o).Nome);
        }
    }
}
