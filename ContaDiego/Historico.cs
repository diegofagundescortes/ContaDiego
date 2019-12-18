using System;
using System.Collections.Generic;
using System.Text;

namespace ContaDiego
{
    class Historico
    {
        private Saldo saldoAtual { get; }
        private int idConta { get; }
        private DateTime data { get; }
        private Saldo saldoAnterior { get; }

        public Historico(int idConta, Saldo saldoAtual, Saldo saldoAnterior, DateTime data)
        {
            this.idConta = idConta;
            this.saldoAtual = saldoAtual;
            this.saldoAnterior = saldoAnterior;
            this.data = data;
        }
    }
}
