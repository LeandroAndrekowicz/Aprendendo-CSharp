using System.Drawing;
using System.Globalization;

namespace Banco
{
    internal class Banco
    {
        private double _deposito;
        private double _saldo;
        public int Conta
        {
            get;
            private set;
        }
        public string Titular
        {
            get;
            private set;
        }
        public Banco(int conta, string titular, double deposito)
        {
            Conta = conta;
            Titular = titular;
            _deposito = deposito;
            _saldo += deposito;
        }

        public double Deposito
        {
            get
            {
                return _deposito;            
            }
            set
            {
                if(value > 0)
                {
                    _deposito = value;
                }
            }
        }

        public double AdicionaSaldo(double deposito)
        {
            _saldo += deposito;
            return _saldo;
        }

        public double SubtraiSaldo(double saque)
        {
            if(saque > _saldo)
            {
                return _saldo;
            }

            double taxa = 5.00;

            _saldo = _saldo - saque - taxa;

            return _saldo;
        }

        public override string ToString()
        {
            if(_deposito > 0)
            {
                return
                    "\n### Depósito realizado no valor R$ : + " + _deposito.ToString("F2", CultureInfo.InvariantCulture) + " ###"
                    + "\nDados da conta: \n"
                    + "Conta: " + Conta
                    + ", Titular: " + Titular
                    + ", Saldo: R$ " + _saldo.ToString("F2", CultureInfo.InvariantCulture)
                    ;
            }

            else
            {
                return
                    "\nDados da conta: \n"
                    + "Conta: " + Conta
                    + ", Titular: " + Titular
                    + ", Saldo: R$ " + _saldo.ToString("F2", CultureInfo.InvariantCulture)
                    ;
            }

        }
    }
}
