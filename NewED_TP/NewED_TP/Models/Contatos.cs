using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewED_TP.Models
{
    class Contatos
    {
        private List<Contato> agenda;

        public List<Contato> Agenda
        {
            get { return agenda; }
            set { agenda = value; }
        }

        public Contatos(int limite)
        {
            agenda = new List<Contato>();
        }

        public bool adicionar(Contato contato)
        {
            bool adiciona = false;

            foreach(Contato cont in agenda)
            {
                if (cont.Nome == contato.Nome)
                {
                    adiciona = true;
                }
            }
            if (adiciona == false)
            {
                agenda.Add(contato);
            }

            return adiciona;
        }

        public Contato pesquisar(Contato contato)
        {
            Contato pesquisa = new Contato();
            Boolean achado = false;

            foreach (Contato c in agenda)
            {
                achado = c.Equals(contato);
                if(achado == true)
                {
                    pesquisa = c;
                    achado = false;
                }
            }
            return pesquisa;
        }

        public bool remover(Contato contato)
        {
            Contato achado = new Contato();
            bool achou = false;

            foreach(Contato c in agenda)
            {
                if(c.Equals(contato))
                {
                    achado = c;
                    achou = true;
                }
            }

            if (achou == true)
            {
                agenda.Remove(achado);
            }

            return achou;
        }

        public bool alterar(Contato contato)
        {
            bool achou = false;
            foreach (Contato c in agenda)
            {
                if(c.Equals(contato))
                {
                    c.Nome = contato.Nome;
                    c.Telefone = contato.Telefone;
                    c.Email = contato.Email;
                    c.Nasc = contato.Nasc;
                    achou = true;
                }
            }

            return achou;
        }

    }
}
