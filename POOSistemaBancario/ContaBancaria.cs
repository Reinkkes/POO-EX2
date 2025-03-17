using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace POOSistemaBancario
{
    public class ContaBancaria
    {
        private int _numeroConta;
        private string _titular;
        private double _saldo;

        public int NumeroConta
        {
            get { return _numeroConta; }
            set 
            {
                if (value.ToString().Length == 7)
                    _numeroConta = value;
                else
                    throw new Exception("Número da conta deve ter 7 dígitos");
            }
        }
        public string Titular
        {
            get { return _titular; }
            set 
            { 
                if (!string.IsNullOrEmpty(value))
                    _titular = value;
            }
        }
        public double Saldo
        {
            get { return _saldo; }
            set
            {
                if (value >= 0)
                    _saldo = value;
            }
        }

        public ContaBancaria(int numeroConta, string titular, double saldo)
        {
            NumeroConta = numeroConta;
            Titular = titular;
            Saldo = saldo;
        }

        public virtual double Depositar(double valor)
        {
            if (valor > 0)
                Saldo += valor;
            return Saldo;
        }

        public virtual double Sacar(double valor)
        {
            if (valor > 0 && valor <= Saldo)
                Saldo -= valor;
            return Saldo;
        }

        public void ExibirSaldo()
        {           
            Console.Write($"{TipoConta()} - {this.Titular} |");
            Console.WriteLine($"Saldo: {Saldo.ToString("C", new CultureInfo("pt-BR"))}");
        }

        public virtual string TipoConta()
        {
            return "Conta";
        }
    }
}
