using System;

public class Class1
{
	public Pessoa()
	{
		int private _nascimento;
		int private _altura;

		string private _nome;

		public int Altura{ get; set; };
		public int Nascimento { get; set; };
	public string Nome { get; set; };	

	public ShowPerson()
    {
		return ($"Nome: {_nome} , Idade {_nascimento - 2022} , altura {_altura} ")
    }
}
}
