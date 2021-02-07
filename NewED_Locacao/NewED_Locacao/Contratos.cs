using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewED_Locacao
{
    class Contratos
    {
        private List<Contrato> o_contrato;

        public Contratos()
        {
            o_contrato = new List<Contrato>();
        }

        public List<Contrato> O_contratos
        {
            get { return o_contrato; }
            set { o_contrato = value; }
        }

        public void incluir(Contrato contrato)
        {
            contrato.Id = o_contrato.Count + 1;
            o_contrato.Add(contrato);
        }

    }
}
