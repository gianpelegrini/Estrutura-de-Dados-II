using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewED_Locacao
{
    class Equipamentos
    {
        private List<Tipos> estoque;

        public Equipamentos()
        {
            estoque = new List<Tipos>();
        }

        public List<Tipos> Estoque
        {
            get { return estoque; }
            set { estoque = value; }
        }

        public void incluir(Tipos tipo)
        {
            tipo.Id = estoque.Count + 1;
            estoque.Add(tipo);
        }

        public Tipos buscar(string tipo)
        {
            Tipos o_t = new Tipos();

            foreach (Tipos t in estoque)
            {
                if (t.Tipo == tipo)
                {
                    o_t = t;
                }
            }
            return o_t;
        }

    }
}
