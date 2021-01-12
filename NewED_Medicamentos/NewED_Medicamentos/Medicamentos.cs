using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewED_Medicamentos
{
    class Medicamentos
    {
        private List<Medicamento> listaMedicamentos = new List<Medicamento>();

        public void Adicionar(Medicamento medicamento)
        {
            listaMedicamentos.Add(medicamento);

        }

        public void Mostrar()
        {

            foreach (Medicamento med in listaMedicamentos)
            {
                Console.WriteLine("-------------------------------");
                Console.WriteLine("Id: " + med.Id);
                Console.WriteLine("Nome: " + med.Nome);
                Console.WriteLine("Laboratorio: " + med.Laboratorio);
                Console.WriteLine("-------------------------------");

            }

        }

        /*public bool Deletar(Medicamento medicamento)
        {
            return;
        }*/

        public Medicamento Pesquisar(Medicamento medicamento)
        {
            Medicamento encontrado = new Medicamento();

            foreach (Medicamento med in listaMedicamentos)
            {
                if (med.Id == medicamento.Id)
                {
                    encontrado = med;
                    return encontrado;
                }
            }

            Medicamento vazio = new Medicamento();
            return vazio;
        }
        
    }
}
