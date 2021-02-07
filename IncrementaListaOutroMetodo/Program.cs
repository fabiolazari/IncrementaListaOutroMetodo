using System;
using System.Collections.Generic;

namespace IncrementaListaOutroMetodo
{
	public class Program
	{
		public static void Main(string[] args)
		{
			
			//Teste 1 - incluindo 1 item na lista dentro de outro método
			List<Cliente> clientes = new List<Cliente>
			{
				new Cliente() {Id = 1, Nome = "Fabio Lazari", Telefone = "14997963272" },
				new Cliente() {Id = 2, Nome = "Tatiana Meiado Lazari", Telefone = "14987197765" },
				new Cliente() {Id = 3, Nome = "Fulano de Tal", Telefone = "12945852154" },
				new Cliente() {Id = 4, Nome = "Ciclano de Oliveira", Telefone = "11996542145" },
				new Cliente() {Id = 5, Nome = "Beltrano Shultz", Telefone = "21981457425" }
			};

			Imprime(clientes);
			
			Console.WriteLine();
			clientes.ForEach(cli => Console.WriteLine(cli));

			Console.WriteLine();
			Console.WriteLine();
			//Teste 2 - Incluindo 1 dado em uma classe dentro de outro método

			Cliente cliente = new Cliente() { Id = 1, Nome = "Fabio Lazari", Telefone = "14997963272" };

			ImprimeOne(cliente);

			Console.WriteLine();
			Console.WriteLine(cliente);

			Console.ReadKey();
		}

		public static void Imprime(List<Cliente> clientes)
		{
			clientes.ForEach(cli => Console.WriteLine(cli));

			clientes.Add(new Cliente() { Id = 6, Nome = "Locha Cunha", Telefone = "11987543265" });
		}

		public static void ImprimeOne(Cliente cliente)
		{
			Console.WriteLine(cliente);

			cliente.Nome = "Fabio Lazari Costa";
		}
	}
}
