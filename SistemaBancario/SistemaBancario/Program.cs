using System;

namespace SistemaBancario
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaEspecial especial1 = new ContaEspecial();
            ContaEspecial especial2 = new ContaEspecial(1236, 1200, "Valéria", 5000);

            especial1.AberturaConta();

            especial1.VerSaldo();
            especial2.VerSaldo();

            especial1.Saque(200);
            especial2.Deposito(500);

            especial1.VerSaldo();
            especial2.VerSaldo();

        }
    }
}
