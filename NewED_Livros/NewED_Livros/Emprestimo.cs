﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewED_Livros
{
    class Emprestimo
    {
        private DateTime dtEmprestimo;
        private DateTime dtDevolucao;

        public Emprestimo()
        {
            dtEmprestimo = new DateTime();
            dtDevolucao = new DateTime();
        }

        public DateTime DtEmprestimo
        {
            get { return dtEmprestimo; }
            set { dtEmprestimo = value; }
        }

        public DateTime DtDevolucao
        {
            get { return dtDevolucao; }
            set { dtDevolucao = value; }
        }


    }
}
