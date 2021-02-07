using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewED_Transporte
{
    class Veiculos
    {
        private List<Veiculo> veiculos = new List<Veiculo>();

        public List<Veiculo> O_Veiculos
        {
            get { return veiculos; }
            set { veiculos = value; }
        }

        public void Incluir(Veiculo veiculo)
        {
            veiculos.Add(veiculo);
        }

        public void Mostrar()
        {
                foreach(Veiculo v in veiculos)
                { 
                    Console.WriteLine("------------------------");
                    Console.WriteLine("ID: " + v.Id);
                    Console.WriteLine("PLACA: " + v.Placa);
                    Console.WriteLine("LOTACAO: " + v.Lotacao);
                    Console.WriteLine("------------------------");
                }

        }
    }
}

