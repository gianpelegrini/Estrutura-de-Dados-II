using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewED_Atendimento
{
    class Guiche
    {
        private int id;
        private Queue<Senha> fatend;

        public Guiche()
        {
            id = 0;
            fatend = new Queue<Senha>();
        }

        public Guiche(int id)
        {
            this.id = id;
            fatend = new Queue<Senha>();
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public Queue<Senha> Listaatend
        {
            get { return fatend; }
            set { fatend = value; }
        }

        public bool Chamar(Queue<Senha> filasenhas)
        {
            if(filasenhas.Count > 0)
            {
                filasenhas.First().HoraAte = DateTime.Now;
                filasenhas.First().DataAte = DateTime.Today;
                fatend.Enqueue(filasenhas.First());
                filasenhas.Dequeue();
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
