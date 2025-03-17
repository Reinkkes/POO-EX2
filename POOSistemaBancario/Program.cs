namespace POOSistemaBancario
{
    public class Program
    {
        static void Main(string[] args)
        {
            ContaPoupanca contaPoupanca = new ContaPoupanca(1234567, "Cleide", 2000);
            ContaCorrente contaCorrente = new ContaCorrente(7654321, "Robson", 1000);
            contaCorrente.Depositar(500);
            contaCorrente.Sacar(200);
            contaCorrente.ExibirSaldo();
            contaPoupanca.Depositar(1000);
            contaPoupanca.Sacar(500);
            contaPoupanca.ExibirSaldo();
        }
    }
}
