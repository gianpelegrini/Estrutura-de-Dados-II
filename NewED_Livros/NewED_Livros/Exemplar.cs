using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewED_Livros
{
    class Exemplar
    {
        private int tombo;
        private List<Emprestimo> emprestimos;

        public Exemplar()
        {
            tombo = 0;
            Emprestimos = new List<Emprestimo>();
        }

        public Exemplar(int val)
        {
            tombo = val;
            Emprestimos = new List<Emprestimo>();
            Emprestimos.Add(new Emprestimo());
        }

        public int Tombo
        {
            get { return tombo; }
            set { tombo = value; }
        }

        public List<Emprestimo> Emprestimos
        {
            get { return emprestimos; }
            set { emprestimos = value; }
        }

        public bool Emprestar()
        {
            bool disp = false;

            foreach (Emprestimo emp in emprestimos)
            {
                if (emp.DtEmprestimo == DateTime.MinValue && disp == false)
                {
                    emp.DtEmprestimo = DateTime.Now;
                    disp = true;
                }
            }

            return disp;
        }

        public bool Devolver()
        {
            bool disp = false;
            foreach (Emprestimo emp in emprestimos)
            {
                if (emp.DtEmprestimo != DateTime.MinValue && disp == false && emp.DtDevolucao == DateTime.MinValue)
                {
                    emp.DtDevolucao = DateTime.Now;
                    disp = true;
                }
            }

            if (disp == true)
            {
                emprestimos.Add(new Emprestimo());
            }

            return disp;

        }

        public bool Disponivel()
        {
            bool vof = false;
            foreach (Emprestimo emp in emprestimos)
            {
                if ((emp.DtEmprestimo == DateTime.MinValue && emp.DtDevolucao == DateTime.MinValue) || (emp.DtEmprestimo != DateTime.MinValue && emp.DtDevolucao != DateTime.MinValue))
                {
                    vof = true;
                }

            }
            return vof;
        }

        public int QtdeEmprestimos1()
        {
            return Emprestimos.Count;
        }

    }
}
