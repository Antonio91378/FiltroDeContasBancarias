using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiltroDeContas
{
    public class ContaBancaria
    {
        public ContaBancaria(string nome, double saldo, int mes)
        {
            this.Nome = nome;
            this.Saldo = saldo;
            this.Mes = mes;
        }

        public string Nome { get; }
        public double Saldo { get; }
        public int Mes { get; }


    }
}
