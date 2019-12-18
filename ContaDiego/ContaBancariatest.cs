using NUnit.Framework;
using System;

namespace ContaDiego
{

    class ContaBancariatest
    {

        [Test]
        public void CriarContaAdicionandoValor()
        {
            var conta = new ContaBancaria(0, "diego", 0, new DateTime(2019, 12, 13, 11, 00, 00));
            double valorAdicionado = 14.50;
            conta.AdicionarSaldo(new Saldo(valorAdicionado), new DateTime(2019, 12, 13, 12, 00, 00));
            Assert.Equals(valorAdicionado, conta.GetSaldo());
        }

        [Test]
        public void CriarContaRetirandoValor()
        {
            var conta = new ContaBancaria(0, "diego", 0, new DateTime(2019, 12, 13, 11, 00, 00));
            double valorRetirado = 14.50;
            var RetiroSaldo = conta.RetirarSaldo(new Saldo(valorRetirado), new DateTime(2019, 12, 13, 11, 00, 00));
            bool _ = Assert.Equals(RetiroSaldo, false);
        }

    }
}
