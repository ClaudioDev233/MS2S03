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
        public void AlunoOrdem()
        {
            Console.WriteLine("Como gostaria de ordenar os alunos?");
            Console.WriteLine("1: Ordem Ascendente");
            Console.WriteLine("2: Ordem Descendente");
            var ordem = Int32.Parse(Console.ReadLine());
            var ordemList = ordem;
            switch (ordemList)
            {
              case 1:
                
                    ListaAlunos.Sort((aluno1, aluno2) => aluno2.NomeDoAluno.CompareTo(aluno1.NomeDoAluno));
                    break;
              case 2:
                    ListaAlunos.Sort((aluno1, aluno2) => aluno1.NomeDoAluno.CompareTo(aluno2.NomeDoAluno));
                    break;
            }

           foreach(var aluno in ListaAlunos)
            {
                Console.WriteLine($"{aluno.NomeDoAluno}  {aluno.NotaDoAluno}");
            }
             
        }

        public void AlunoMaiorNota()
        {
            ListaAlunos.Sort((aluno1, aluno2)=> aluno2.NotaDoAluno.CompareTo(aluno1.NotaDoAluno));
            Console.WriteLine($"O aluno com maior nota é {ListaAlunos[0].NomeDoAluno} e sua nota é:`{ListaAlunos[0].NotaDoAluno}");
        }
        public void AlunoMenorNota()
        {
            ListaAlunos.Sort((aluno1, aluno2) => aluno1.NotaDoAluno.CompareTo(aluno2.NotaDoAluno));
            Console.WriteLine($"O aluno com menor nota é {ListaAlunos[0].NomeDoAluno} e sua nota é:`{ListaAlunos[0].NotaDoAluno}");
        }

        public void MediaAlunos()
        {
            var somaAlunos = ListaAlunos.Sum(aluno => aluno.NotaDoAluno);
            Console.WriteLine($"A média da turma é {somaAlunos / ListaAlunos.Count}");
        }

        public void AlunosReprovados()
        {
            var reprovados = ListaAlunos.FindAll(aluno => aluno.NotaDoAluno < 5);
            if (reprovados == null)
                Console.WriteLine("Nenhum reprovado!");
            foreach(var reprovado in reprovados)
            {
                Console.WriteLine($"O aluno {reprovado.NomeDoAluno} foi reprovado, pois sua nota foi: {reprovado.NotaDoAluno}");
            }
        }
    }

}
