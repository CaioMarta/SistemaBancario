using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaBancario
{
    class ContaComum
    {
        // declarar os atributos
        private int nroConta;
        private double saldo;
        private string nomeCliente;

        // contrutor SEM parâmetros
        public ContaComum()
        {
            nroConta = 0;
            saldo = 0;
            nomeCliente = null;
        }

        // construtor com parâmetros
        public ContaComum(int nroConta, double saldo, string nomeCliente)
        {
            this.nroConta = nroConta;
            this.saldo = saldo;
            this.nomeCliente = nomeCliente;
        }

        // propriedades
        public int NroConta
        {
            get { return nroConta; }
            set { nroConta = value; }
        }
        public double Saldo
        {
            get { return saldo; }
            set { saldo = value; }
        }
        public string NomeCliente
        {
            get { return nomeCliente; }
            set { nomeCliente = value; }
        }

        // metódos
        public virtual void AberturaConta()
        {
            string msg = "";
            try
            {
                Console.WriteLine("  Sistema Bancário  ");
                Console.Write("No. da Conta: ");
                NroConta = Convert.ToInt32(Console.ReadLine());
                Console.Write("Nome do Cliente: ");
                NomeCliente = Console.ReadLine();
                Console.Write("Informe o Saldo: ");
                Saldo = Convert.ToDouble(Console.ReadLine());
                msg = "Dados cadastrados com sucesso!";
            }
            catch(Exception ex)
            {
                msg = "Erro no cadastro" + ex;
            }
            finally
            {
                Console.WriteLine("msg");
            }
        }

        public virtual void Saque(double valor)
        {
            Saldo = Saldo - valor;
        }

        public virtual void Deposito(double valor)
        {
            Saldo += valor; 
        }

        public virtual void VerSaldo()
        {
            Console.WriteLine("\n No. da Conta: " + NroConta + 
                "\n Nome do Cliente: " + NomeCliente + 
                "\n Saldo R$: " + Saldo);
        }
    }
}
