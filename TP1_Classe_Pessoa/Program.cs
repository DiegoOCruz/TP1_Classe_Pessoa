using System.Reflection;

namespace TP1_Classe_Pessoa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa p1 = new Pessoa();
            p1.Nome = "Diego";
            p1.Idade = 34;
            p1.Cpf = "123.456.789-10";
            Console.WriteLine("Nome: " + p1.Nome);
            Console.WriteLine("Idade: " + p1.Idade);
            Console.WriteLine("CPF: " + p1.Cpf);
            Console.WriteLine("---------------------");


            string opcao;
            List <Pessoa> list = new List<Pessoa>();

            do
            {
                Console.WriteLine("\n" +
                    "=-=-= MENU -=-=-=\n" +
                    "\n" +
                    "1. Adicionar pessoa\n" +
                    "2. Imprimir lista\n" +
                    "3. sair");
                opcao = Console.ReadLine();

                switch (opcao) 
                {
                    case "1":
                        Console.WriteLine("Nome: ");
                        string nome = Console.ReadLine();
                        Console.WriteLine("Idade: ");
                        int idade = int.Parse(Console.ReadLine());
                        Console.WriteLine("CPF: ");
                        string cpf = Console.ReadLine();
                        Pessoa pessoa = new Pessoa(nome, idade, cpf);
                        list.Add(pessoa);
                        break;

                    case "2":
                        foreach (var item in list)
                        {
                            Console.WriteLine($"Nome: {item.Nome}\n" + $"Idade: {item.Idade}\n" + $"CPF: {item.Cpf}\n" + $"-------------------");
                        }
                        break;
                    case "3":
                        Console.WriteLine("Fim.");
                        break;
             
                    default:
                        Console.WriteLine("Opção inválida");
                        break;

                }



            } while (opcao != "3");
        }
    }
}
