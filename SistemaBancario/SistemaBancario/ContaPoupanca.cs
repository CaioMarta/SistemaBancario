using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaBancario
{
    class ContaPoupanca : ContaComum
    {
        private double taxa;

        public void Rendimento(double taxa)
        {
            this.taxa = taxa;
            base.Saldo = base.Saldo + base.Saldo * (this.taxa / 100);
        }
    }
}
