using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiltroDeContas
{
    internal class FiltroSaldoAlto : Filtro
    {
        public FiltroSaldoAlto() : base()
        {
        }

        public FiltroSaldoAlto(Filtro outroFiltro) : base(outroFiltro)
        {
        }

        public override List<ContaBancaria> Filtra(List<ContaBancaria> contas)
        {
            var listaFiltrada = new List<ContaBancaria>();
            foreach (var contaBancaria in contas)
            {
                if (contaBancaria.Saldo > 500000.0)
                {
                    listaFiltrada.Add(contaBancaria);
                }
            }
            if (OutroFiltro != null)
            {
                return listaFiltrada.Concat(OutroFiltro.Filtra(contas)).ToList();
            }
            else
            {
                return listaFiltrada;
            }
        }
    }
}
