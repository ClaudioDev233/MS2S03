using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ms2s03.Classes.Entidades
{
    public class Aluno
    {
        public Aluno(string nomeDoAluno, decimal notaDoAluno)
        {
            NomeDoAluno = nomeDoAluno;
            NotaDoAluno = notaDoAluno;
        }

        public string NomeDoAluno { get; set; }
        public decimal NotaDoAluno { get; set; }
    }
}
