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

    //Ex2

    var prato1 = new Menu
    {
        NomeDoPrato = "Coiso",
        Preco = 2,
    };

    //Ex3

    var coiso1 = new Area();
    Console.WriteLine("Digite a altura do quadrilátero");
    coiso1.Altura = int.Parse(Console.ReadLine());
    Console.WriteLine("Digite a largura do quadrilátero");
    coiso1.Largura = int.Parse(Console.ReadLine());
    Console.WriteLine(coiso1.MostraDados());

    Console.WriteLine(coiso1.CalculaArea());
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
