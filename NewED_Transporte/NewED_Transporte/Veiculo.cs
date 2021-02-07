using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewED_Transporte
{
    class Veiculo
    {
        private int id;
        private string placa;
        private int lotacao;

        public Veiculo()
        {
            this.id = 0;
            this.placa = "";
            this.lotacao= 0;
        }

        public Veiculo(int id2, string placa2, int lotacao2)
        {
            id = id2;
            placa = placa2;
            lotacao = lotacao2;
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Placa
        {
            get { return placa; }
            set { placa = value; }
        }
        public int Lotacao
        {
            get { return lotacao; }
            set { lotacao = value; }
        }
    }
}
