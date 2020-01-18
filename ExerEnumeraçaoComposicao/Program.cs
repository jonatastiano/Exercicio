using System;
using ExerEnumeraçaoComposicao.Entidades;
using ExerEnumeraçaoComposicao.Entidades.Enumeraçao;
using System.Globalization;

namespace ExerEnumeraçaoComposicao {
    class Program {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com os dados do cliente:");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Data de nascimento(DD/MM/YYYY): ");
            DateTime dataNascimento = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Entre com a ordem dos dados: ");
            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());

            Cliente cliente = new Cliente(nome, email, dataNascimento);
            Ordem ordem = new Ordem(DateTime.Now, status, cliente);

            Console.Write("Numero da ordem dos items: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Entre #{i} dados do item:");
                Console.Write("Nome do produto: ");
                string nome1 = Console.ReadLine();
                Console.Write("Preço do produto: ");
                double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Produto produto = new Produto(nome1, preco);

                Console.Write("Quantidade: ");
                int quantidade = int.Parse(Console.ReadLine());

                OrdemItem item = new OrdemItem(quantidade, preco, produto);
                ordem.AddItems(item);
            }

            Console.WriteLine();
            Console.WriteLine("RESUMO DA ORDEM:");
            Console.WriteLine(ordem);
        }
    }
}
