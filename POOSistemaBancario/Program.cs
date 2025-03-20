using static System.Net.Mime.MediaTypeNames;

namespace POOSistemaBancario
{
    public class Program
    {
        private static void Main(string[] args)
        {
            List<ContaBancaria> contaUsuario = new List<ContaBancaria>();

            while (true)
            {
                Console.Clear();
                Console.WriteLine("===================================");
                Console.WriteLine("         SISTEMA BANCÁRIO          ");
                Console.WriteLine("===================================");
                Console.WriteLine("1. Criar conta");
                Console.WriteLine("2. Depositar");
                Console.WriteLine("3. Sacar");
                Console.WriteLine("4. Exibir saldo");
                Console.WriteLine("5. Sair");
                Console.WriteLine("===================================");
                Console.Write("Escolha uma opção: ");
                string opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        CriarConta(contaUsuario);
                        break;
                    case "2":
                        Operacao(contaUsuario, "depositar");
                        break;
                    case "3":
                        Operacao(contaUsuario, "sacar");
                        break;
                    case "4":
                        ExibirSaldo(contaUsuario);
                        break;
                    case "5":
                        Console.WriteLine("Saindo do sistema...");
                        return;
                    default:
                        Console.WriteLine("Opção inválida.");
                        break;
                }
                Console.WriteLine("Pressione qualquer tecla para continuar...");
                Console.ReadKey();
            }
        }

        private static void CriarConta(List<ContaBancaria> contaUsuario)
        {
            Console.Write("Número da conta: ");
            int numeroConta = int.Parse(Console.ReadLine());
            Console.Write("Titular da conta: ");
            string titular = Console.ReadLine();
            double saldo = 0;
            ContaBancaria novaConta = new ContaBancaria(numeroConta, titular, saldo);
            contaUsuario.Add(novaConta);
            Console.WriteLine("Conta criada com sucesso!");
        }

        private static void Operacao(List<ContaBancaria> contas, string operacao)
        {
            Console.Write("Número da conta: ");
            int numeroConta = int.Parse(Console.ReadLine());
            ContaBancaria conta = contas.FirstOrDefault(c => c.NumeroConta == numeroConta);

            if (conta == null)
            {
                Console.WriteLine("Conta não encontrada.");
                return;
            }

            Console.Write($"Valor para {operacao}: ");
            double valor = double.Parse(Console.ReadLine());

            if (operacao == "depositar")
            {
                conta.Depositar(valor);
                Console.WriteLine("Depósito realizado com sucesso!");
            }
            else if (operacao == "sacar")
            {
                if (conta.Sacar(valor) < conta.Saldo)
                {
                    Console.WriteLine("Saque realizado com sucesso!");
                }
                else
                {
                    Console.WriteLine("Saldo insuficiente.");
                }
            }
        }

        private static void ExibirSaldo(List<ContaBancaria> contaUsuario)
        {
            Console.Write("Número da conta: ");
            int numeroConta = int.Parse(Console.ReadLine());
            ContaBancaria conta = contaUsuario.FirstOrDefault(c => c.NumeroConta == numeroConta);

            if (conta != null)
            {
                conta.ExibirSaldo();
            }
            else
            {
                Console.WriteLine("Conta não encontrada.");
            }
        }
    }
}
