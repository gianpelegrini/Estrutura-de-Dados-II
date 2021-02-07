using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewED_Locacao
{
    class Contrato
    {
        private int id;
        private bool liberado = false;
        private DateTime dt_saida;
        private DateTime dt_retorno;
        private Stack<Tipos> itens;

        public Contrato()
        {
            id = 0;
            liberado = false;
            dt_saida = new DateTime();
            dt_retorno = new DateTime();
            itens = new Stack<Tipos>() ;
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public bool Liberado
        {
            get { return liberado; }
            set { liberado = value; }
        }

        public DateTime Dt_saida
        {
            get { return dt_saida; }
            set { dt_saida = value; }
        }

        public DateTime Dt_retorno
        {
            get { return dt_retorno; }
            set { dt_retorno = value; }
        }

        public Stack<Tipos> Itens
        {
            get { return itens; }
            set { itens = value; }
        }

        public void incluir(Tipos tipo)
        {
            tipo.Id = itens.Count + 1;
            itens.Push(tipo);
        }

        public Tipos buscar(string tipo)
        {
            Tipos o_t = new Tipos();
            foreach (Tipos t in itens)
            {
                if (t.Tipo == tipo)
                {
                    o_t = t;
                }
            }
            return o_t;
        }

        public override bool Equals(object obj)
        {
            return this.id.Equals(((Contrato)obj).id);
        }
    }
}
