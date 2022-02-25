namespace ms2s03.Classes.Entidades
{
	public class Pessoa
	{

		private string _nome;

		private int _altura;

		private DateTime _nascimento;


		public int Altura { get; set; }
		public DateTime Nascimento { get; set; }
		public string Nome { get; set; }

		public string ShowPerson()
		{
			return ($"Nome: {Nome} , Idade {DateTime.Today.Year - _nascimento.Year} , altura {Altura} ");
		}


	}
}