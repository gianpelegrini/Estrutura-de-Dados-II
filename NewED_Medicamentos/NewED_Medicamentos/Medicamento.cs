using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewED_Medicamentos
{
    class Medicamento
    {
        private int id;
        private string nome;
        private string laboratorio;
        private Queue<Lote> lotes;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public string Laboratorio
        {
            get { return laboratorio; }
            set { laboratorio = value; }
        }

        public Queue<Lote> Lotes
        {
            get { return lotes; }
            set { lotes = value; }
        }

        public Medicamento()
        {
            this.id = 0;
            this.nome = "";
            this.laboratorio = "";
            this.lotes = new Queue<Lote>();
        }

        public Medicamento(int id2, string nome2, string laboratorio2)
        {
            id = id2;
            nome = nome2;
            laboratorio = laboratorio2;
        }

        public int QtdeDisponivel()
        {
            int q = 0;

            foreach(Lote lot in lotes)
            {
                q += lot.Qtde;
            }

            return q;
        }

        public void Comprar(Lote lote)
        {
            lotes.Enqueue(lote);
        }

        public bool Vender (int qtde)
        {
            if (qtde > QtdeDisponivel())
            {
                return false;
            }
            else
            {
                int qtfalta = qtde;

                int qtlotes = lotes.Count;

                for (int i = 0; i <= qtlotes; i++)
                {
                    if (qtfalta > lotes.Peek().Qtde)
                    {
                        qtfalta -= lotes.Peek().Qtde;
                        lotes.Peek().Qtde = 0;
                        lotes.Dequeue();

                    }
                    else
                    {
                        lotes.Peek().Qtde -= qtfalta;
                        qtfalta = 0;
                        break;
                    }
                }
                return true;
            }
        }

        public void MostrarLote()
        {
            foreach (Lote lot in lotes)
            {
                Console.WriteLine("Id: " + lot.Id + ", Quantidade: " + lot.Qtde + ", Vencimento: " + lot.Venc);
            }

        }

        /*public bool Equals(object obj)
        {
            return;
        }*/
    }
}
