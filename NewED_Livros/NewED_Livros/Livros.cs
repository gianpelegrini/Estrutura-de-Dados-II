using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewED_Livros
{
    class Livros
    {
        private List<Livro> acervo;

        public Livros()
        {
            acervo = new List<Livro>();
        }

        public List<Livro> Acervo
        {
            get { return acervo; }
            set { acervo = value; }
        }

        public void Adicionar(Livro livro)
        {
            Acervo.Add(livro);
        }

        public Livro Pesquisar(Livro livro)
        {
            Livro encontrado = new Livro();

            foreach (Livro ac in acervo)
            {
                if (ac.Isbn == livro.Isbn)
                {
                    encontrado = ac;
                }
            }
            return encontrado;

        }

    }
}
