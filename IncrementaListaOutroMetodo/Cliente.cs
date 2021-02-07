namespace IncrementaListaOutroMetodo
{
	public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }

        public Cliente()
        {
        }

        public Cliente(int id, string nome, string telefone)
        {
            Id = id;
            Nome = nome;
            Telefone = telefone;
        }

		public override string ToString()
		{
            return "Id: " +
                    Id +
                    " Nome: " +
                    Nome +
                    " Telefone: " +
                    Telefone;
		}
	}
}
