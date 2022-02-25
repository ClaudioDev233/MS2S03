public class Pessoa
{
	
		 private int _nascimento;
		private int  _altura;

		private string _nome;

		public int Altura{ get; set; }
		public int Nascimento { get; set; }
		public string Nome { get; set; }	

	public ShowPerson()
    {
		return ($"Nome: {_nome} , Idade {_nascimento - 2022} , altura {_altura} ");
    }

}
