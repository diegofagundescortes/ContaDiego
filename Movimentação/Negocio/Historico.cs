using System;
using System.Collections.Generic;
using System.Text;

namespace Movimentação
{
    class Historico
    {
        public Saldo saldoAtual { get; }
        public int idConta { get; }
        public DateTime data { get; }
        public Saldo saldoAnterior { get; }

        public Historico(int idConta, Saldo saldoAtual, Saldo saldoAnterior, DateTime data)
        {
            this.idConta = idConta;
            this.saldoAtual = saldoAtual;
            this.saldoAnterior = saldoAnterior;
            this.data = data;
        }
    }
}
