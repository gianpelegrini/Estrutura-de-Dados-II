using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewED_Locacao
{
    class Tipos
    {
        private int id;
        private string tipo;
        private List<Equipamento> itens = new List<Equipamento>();

        public Tipos()
        {
            id = 0;
            tipo = "";
            itens = new List<Equipamento>();
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }


        public List<Equipamento> Itens
        {
            get { return itens; }
            set { itens = value; }
        }

        public void incluir(Equipamento equipamento)
        {
            equipamento.Id = itens.Count + 1;
            itens.Add(equipamento);
        }

        public Equipamento buscar(int id)
        {
            Equipamento ret = new Equipamento();
            foreach (Equipamento e in itens)
            {
                if (e.Id == id)
                {
                    ret = e;
                }
            }
            return ret;
        }

        public override bool Equals(object obj)
        {
            return (this.tipo.Equals(((Tipos)obj).tipo));
        }
    }
}
