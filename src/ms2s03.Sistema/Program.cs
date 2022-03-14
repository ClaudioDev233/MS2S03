// See https://aka.ms/new-console-template for more information
using ms2s03.Classes.Entidades;
Console.WriteLine("Classes");
try
{
    //ex1
    var pessoa1 = new Pessoa
    {
        Nome = "Claudio",
        Altura = 180,
        Nascimento = new DateTime(1994, 04, 26)
    };

    Console.WriteLine("Exercicio 1");
    Console.WriteLine(pessoa1.ShowPerson());

    //Ex2 Menu
    var batata = new Ingrediente("batata");
    var oleo = new Ingrediente("Oleo");
    var batataFrita = new Prato("Batata Frita", 15.93M);
    batataFrita.AdicionaIngrediente(new List<Ingrediente>()
    {
        oleo,
        batata,
    });
    //batataFrita.MostrarIngredientes();
    var menuCoiso = new Menu("Coiso");
    menuCoiso.AdicionaPratoAoMenu(batataFrita);
    menuCoiso.RetornaMenu();
   

    //Ex3

    var coiso1 = new Area();
    Console.WriteLine("Digite a altura do quadrilátero");
    coiso1.Altura = int.Parse(Console.ReadLine());
    Console.WriteLine("Digite a largura do quadrilátero");
    coiso1.Largura = int.Parse(Console.ReadLine());
    Console.WriteLine(coiso1.MostraDados());

    Console.WriteLine(coiso1.CalculaArea());

    //Ex4 Pessoas

    var pessoas = new Pessoas();
    pessoas.AdicionarPessoas();

    //Ex5
    //var calcular1 = new Calculadora();
    //Console.WriteLine("Digite o valor");
    //calcular1.Valor1 = int.Parse(Console.ReadLine());
    //Console.WriteLine("digite o segundo valor");
    //calcular1.Valor2= int.Parse(Console.ReadLine());
    //Console.WriteLine("Qual operação deseja fazer?");
    //calcular1.Operacao = Console.ReadLine();
    //Console.WriteLine($"{calcular1.Valor1} , {calcular1.Valor2} e {calcular1.Operacao}");
    //Console.WriteLine(calcular1.Calcular());

    //Ex 6 

    var pedido1 = new Pedido(new DateOnly(2022, 03, 12));
    pedido1.AdicionaPrato(batataFrita);
    pedido1.AdicionaPrato(batataFrita);
    pedido1.AdicionaPrato(batataFrita);
    Console.WriteLine(pedido1.QuantidadeDeItens());
    Console.WriteLine(pedido1.ValorDoPedido());
    
    //Ex7-8
    var aluno1 = new Aluno("Claudio1", 8.3M);
    
    var aluno2 = new Aluno("Claudio2", 3.3M);
    var aluno3 = new Aluno("Claudio3", 9.3M);
    var aluno4 = new Aluno("Claudio4", 9.9M);
    var aluno5 = new Aluno("Claudio5", 9.5M);
    var exame = new Exame();
    exame.AdicionarAlunos(new List<Aluno>() { aluno1,
    aluno2, aluno3,aluno4,aluno5
    });
   exame.AlunoMaiorNota();
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
