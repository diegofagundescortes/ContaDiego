using Microsoft.VisualStudio.TestTools.UnitTesting;
using Movimentação;
using System;

namespace Movimentação.Negocio
{
    [TestClass]
    public class ContaBancariaTests
    {
        private ContaBancaria contaBancaria = new ContaBancaria(01, "Diegocortes", 0, new DateTime(2019, 12, 01));
        [TestMethod]
        public void AdicionarSaldo_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            Saldo saldoAdicionado = new Saldo(14,50);
            DateTime dateTime = default(global::System.DateTime);

            // Act
            var result = contaBancaria.AdicionarSaldo(
                saldoAdicionado,
                dateTime);

            // Assert
            Assert.Equals(contaBancaria.GetSaldo(),saldoAdicionado);
        }

        [TestMethod]
        public void RetirarSaldo_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            Saldo saldoRetierado = null;
            DateTime dateTime = default(global::System.DateTime);

            // Act
            var result = contaBancaria.RetirarSaldo(
                saldoRetierado,
                dateTime);

            // Assert
            Assert.Fail();
        }

        [TestMethod]
        public void GetSaldo_StateUnderTest_ExpectedBehavior()
        {
            // Arrange

            // Act
            var result = contaBancaria.GetSaldo();

            // Assert
            Assert.Fail();
        }

        [TestMethod]
        public void NumeroConta_StateUnderTest_ExpectedBehavior()
        {
            // Arrange

            // Act
            var result = contaBancaria.NumeroConta();

            // Assert
            Assert.Fail();
        }

        [TestMethod]
        public void NomeConta_StateUnderTest_ExpectedBehavior()
        {

            // Act
            var result = contaBancaria.NomeConta();

            // Assert
            Assert.Fail();
        }

        [TestMethod]
        public void GetHistoricos_StateUnderTest_ExpectedBehavior()
        {

            // Act
            var result = contaBancaria.GetHistoricos();

            // Assert
            Assert.Fail();
        }
    }
}
