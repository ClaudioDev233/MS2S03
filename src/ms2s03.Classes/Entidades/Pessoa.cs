namespace ms2s03.Classes.Entidades
{
	public class Pessoa
	{

		private string _nome;

		private int _altura;

		private DateTime _nascimento;

		private int _idade;

		public Pessoa() { }
        public Pessoa(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
        }

        public int Altura { get; set; }
		public DateTime Nascimento { get; set; }
		public string Nome { get; set; }
		public int Idade { get; set; }

		public string ShowPerson()
		{
			return ($"Nome: {Nome} , Idade {DateTime.Today.Year - _nascimento.Year} , altura {Altura} ");
		}


	}
}