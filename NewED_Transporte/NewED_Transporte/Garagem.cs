using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewED_Transporte
{
    class Garagem
    {
        private int id;
        private string local;
        private Stack<Veiculo> veiculos;

        public Garagem()
        {
            this.id = 0;
            this.local = "";
            this.veiculos = new Stack<Veiculo>();
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Local
        {
            get { return local; }
            set { local = value; }
        }

        public void Incluir(Veiculo veiculo)
        {
            veiculos.Push(veiculo);
        }

        public int QtdDeVeiculos(Veiculo veiculo)
        {
           return veiculos.Count;
        }

        public int PotencialDeTransporte()
        {
            return veiculos.Count;
        }

        public override bool Equals(object obj)
        {
            return this.local.Equals(((Garagem)obj).local);
        }
    }
}
