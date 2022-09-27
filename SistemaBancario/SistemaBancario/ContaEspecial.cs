using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaBancario
{
    class ContaEspecial : ContaComum // Herança
    {
        // atributos
        private double limite;

        // construtor sem parâmetros
        // vai chamar o construtor da classe ContaComum
        public ContaEspecial() : base()
        {
            limite = 0;
        }

        // construtor com parâmetros
        // vai chamar o construtor da classe ContaComum
        //sobrecarga (overlord)
        public ContaEspecial(int nroConta, double saldo, string nomeCliente, double limite)
            : base(nroConta, saldo, nomeCliente)
        {
            this.limite = limite;
        }

        // propriedade
        public double Limite
        {
            get { return limite; }
            set { limite = value; }
        }

        // sobreeescrever os metódos (override)
        public override void AberturaConta()
        {
            base.AberturaConta();
            try
            {
                Console.Write("Limite R$: ");
                Limite = Convert.ToDouble(Console.ReadLine());
            }
            catch(Exception ex)
            {
                Console.WriteLine("Erro ao cadastrar Limite " + ex);
            }
        }

        public override void Deposito(double valor)
        {
            base.Deposito(valor);
        }

        public override void Saque(double valor)
        {
            if(valor <= (base.Saldo + Limite))
            {
                base.Saque(valor);
            }
            else
            {
                Console.WriteLine("Saldo Insuficiente");
            }
        }

        public override void VerSaldo()
        {
            base.VerSaldo();
            Console.WriteLine("\n Limite R$: " + Limite +
                "\n Total da Conta R$: " + (base.Saldo + Limite));
        }
    }


}
