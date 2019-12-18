using NUnit.Framework;
using System;
using Xunit;

namespace ContaDiego
{

    class Historicotest
    {
        Historico _historico;
        [Fact]
        public void TesteCriacaoHistorico()
        {
            _historico = new Historico(1, new Saldo(15.14),new Saldo(24.15), new DateTime(2019, 18, 01));
            Assert.Equals(24.15, _historico.saldoAnterior.saldo);
            Assert.Equals(15.14, _historico.saldoAtual.saldo);
        }

        [Fact]
        public void TesteRespostaHistorico()
        {
            Assert.Equals(2019, _historico.data.Year);
            Assert.Equals(-1, _historico.saldoAtual.idSaldo);
        }

    }
}
