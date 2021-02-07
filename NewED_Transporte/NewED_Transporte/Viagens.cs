using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewED_Transporte
{
    class Viagens
    {
        private Queue<Viagem> viagens;

        public void Incluir(Viagem viagem)
        {
            viagens.Enqueue(viagem);
        }
    }
}
