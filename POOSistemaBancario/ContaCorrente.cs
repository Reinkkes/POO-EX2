using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOSistemaBancario
{
    public class ContaCorrente : ContaBancaria
    {
        public ContaCorrente(int numeroConta, string titular, double saldo) : base(numeroConta, titular, saldo)
        {
        }
        public override double Sacar(double valor)
        {
            if (valor > 0 && valor-5 <= Saldo)
                Saldo -= valor+5;
            return Saldo;
        }

        public override string TipoConta()
        {
            return "Conta Corrente";
        }

    }
}
