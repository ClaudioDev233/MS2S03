using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ms2s03.Classes.Entidades
{
    public class Exame
    {
        public List<Aluno> ListaAlunos { get; set; }

        public void AdicionarAlunos(List<Aluno> aluno)
        {
            if (ListaAlunos == null)
                ListaAlunos = new List<Aluno>();
            ListaAlunos.AddRange(aluno);
        }
        public void AlunoMaiorNota()
        {
            ListaAlunos.Sort((aluno1, aluno2) => aluno2.NomeDoAluno.CompareTo(aluno1.NomeDoAluno));

           foreach(var aluno in ListaAlunos)
            {
                Console.WriteLine($"{aluno.NomeDoAluno}  {aluno.NotaDoAluno}");
            }
            
           
        }
    }

}
