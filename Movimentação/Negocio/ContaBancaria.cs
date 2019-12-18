using System;
using System.Collections.Generic;
using System.Text;

namespace Movimentação
{
    class ContaBancaria
    {
        private Conta _contaBancaria;
        private Saldo _saldoBancario;
        private Historico[] _historicos;

        public ContaBancaria(int id, string nome, double Saldo, DateTime data)
        {
            _contaBancaria.id = id;
            _contaBancaria.nome = nome;
            _saldoBancario = new Saldo(0, Saldo);
            _historicos[0] = new Historico(id, _saldoBancario, _saldoBancario, data);

        }
        public bool AdicionarSaldo(Saldo saldoAdicionado, DateTime dateTime)
        {
            bool alteração = false;

            if (!_saldoBancario.Equals(saldoAdicionado))
            {
                int IdNovo = _saldoBancario.idSaldo + 1;
                saldoAdicionado.setIdSaldo(IdNovo);
                saldoAdicionado.saldo = saldoAdicionado.saldo + _saldoBancario.saldo;
                _historicos[_historicos.Length] = new Historico(_contaBancaria.id, saldoAdicionado, _saldoBancario, dateTime);
                _saldoBancario = saldoAdicionado;
                alteração = true;
            }

            return alteração;
        }
        public bool RetirarSaldo(Saldo saldoRetierado, DateTime dateTime)
        {
            bool alteração = false;
            if (_saldoBancario.saldo > saldoRetierado.saldo)
            {
                var saldoAtual = new Saldo(_saldoBancario.idSaldo + 1, _saldoBancario.saldo - saldoRetierado.saldo);
                _historicos[_historicos.Length] = new Historico(_contaBancaria.id, saldoAtual, _saldoBancario, dateTime);
                _saldoBancario = saldoAtual;
                alteração = true;
            }

            return alteração;
        }
        public double GetSaldo()
        {
            return _saldoBancario.saldo;
        }
        public int NumeroConta()
        {
            return _contaBancaria.id;
        }
        public string NomeConta()
        {
            return _contaBancaria.nome;
        }
        public Historico[] GetHistoricos()
        {
            return _historicos;
        }
    }
}
