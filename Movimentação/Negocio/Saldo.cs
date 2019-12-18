using System;
using System.Collections.Generic;
using System.Text;

namespace Movimentação
{
    class Saldo
    {
        public int idSaldo { get; set; }
        public double saldo { get; set; }

        public Saldo(double saldo)
        {
            this.saldo = saldo;
            idSaldo = -1;
        }
        public Saldo(int v, double saldo)
        {
            this.idSaldo = v;
            this.saldo = saldo;
        }
        public void setIdSaldo(int id)
        {
            if (idSaldo == -1)
            {
                idSaldo = id;
            }
        }
    }
}
