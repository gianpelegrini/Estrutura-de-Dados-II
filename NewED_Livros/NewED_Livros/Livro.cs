using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewED_Livros
{
    class Livro
    {
        private int isbn;
        private string titulo;
        private string autor;
        private string editora;
        private List<Exemplar> exemplares = new List<Exemplar>();

        public Livro()
        {
            this.isbn = 0;
            this.titulo = "";
            this.autor = "";
            this.editora = "";
            exemplares = new List<Exemplar>();
        }

        public int Isbn
        {
            get { return isbn; }
            set { isbn = value; }
        }

        public string Titulo
        {
            get { return titulo; }
            set { titulo = value; }
        }

        public string Autor
        {
            get { return autor; }
            set { autor = value; }
        }

        public string Editora
        {
            get { return editora; }
            set { editora = value; }
        }

        public List<Exemplar> Exemplares
        {
            get { return exemplares; }
            set { exemplares = value; }
        }

        public void AdicionarExemplar(Exemplar exem)
        {
            Exemplares.Add(exem);

        }

        public int QtdeExemplares()
        {
            return Exemplares.Count;
        }

        public int QtdeDisponiveis()
        {
            int i = 0;

            Emprestimo emp = new Emprestimo();
            foreach (Exemplar exem in exemplares)
            {
                emp = exem.Emprestimos.Last();

                if ((emp.DtEmprestimo == DateTime.MinValue && emp.DtDevolucao == DateTime.MinValue) || (emp.DtEmprestimo != DateTime.MinValue && emp.DtDevolucao != DateTime.MinValue))
                {

                    i++;
                }

            }
            return i;
        }

        public int QtdeEmprestimos2()
        {
            int qdt = 0;
            Emprestimo o_emp = new Emprestimo();

            foreach (Exemplar exem in exemplares)
            {
                o_emp = exem.Emprestimos.Last();
                if (o_emp.DtEmprestimo != DateTime.MinValue && o_emp.DtDevolucao == DateTime.MinValue)
                {
                    qdt++;
                }
            }

            return qdt;


        }

        public double PercDisponibilidade()
        {
            int valor = 0;
            double cent = 100.00;

            Emprestimo emp = new Emprestimo();
            foreach (Exemplar exem in exemplares)
            {
                if ((emp.DtEmprestimo == DateTime.MinValue && emp.DtDevolucao == DateTime.MinValue) || (emp.DtEmprestimo != DateTime.MinValue && emp.DtDevolucao != DateTime.MinValue))
                {
                    valor++;
                }
            }
            if (valor != 0)
            {
                cent = (valor / Exemplares.Count()) * 100;
            }

            return cent;
        }

    }
}
