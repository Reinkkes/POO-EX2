using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOSistemaBancario
{
    public class ContaPoupanca : ContaBancaria
    {
        public ContaPoupanca (int numeroConta, string titular, double saldo) : base(numeroConta, titular, saldo)
        {
        }

        public override double Depositar(double valor)
        {
            
            return Saldo+=(valor*0.005)+valor;
        }
        public override string TipoConta()
        {
            return "Conta Poupança";
        }
    }
}
