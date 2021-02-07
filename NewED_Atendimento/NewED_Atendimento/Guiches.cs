using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewED_Atendimento
{
    class Guiches
    {
        private List<Guiche> listaguiches;

        public Guiches()
        {
            listaguiches = new List<Guiche>();
        }

        public List<Guiche> Listaguiches
        {
            get { return listaguiches; }
            set { listaguiches = value; }
        }

        public void Adc(Guiche guiche)
        {
            Listaguiches.Add(guiche);
        }
    }
}
