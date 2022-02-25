// See https://aka.ms/new-console-template for more information
using ms2s03.Classes.Entidades;
Console.WriteLine("Classes");
try
{
    var pessoa1 = new Pessoa
    {
        Nome = "Claudio",
        Altura = 180,
        Nascimento = new DateTime(1994, 04, 26)
    };

    //Ex 1
    Console.WriteLine(pessoa1.ShowPerson());
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
