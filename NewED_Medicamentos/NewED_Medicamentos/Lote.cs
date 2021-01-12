using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewED_Medicamentos
{
    class Lote
    {
        private int id;
        private int qtde;
        private DateTime venc;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public int Qtde
        {
            get { return qtde; }
            set { qtde = value; }
        }

        public DateTime Venc
        {
            get { return venc; }
            set { venc = value; }
        }

        public Lote()
        {
            this.id = 0;
            this.qtde = 0;
            this.venc = new DateTime();
        }

        public Lote(int id2, int qtde2, DateTime venc2)
        {
            id = id2;
            qtde = qtde2;
            venc = venc2;
        }

        public string Atrib()
        {
            return id + "-" + qtde + "-" + venc;
        }
    }
}
