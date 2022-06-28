
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiltroDeContas
{
    internal class FiltroMesAtual : Filtro
    {
        public FiltroMesAtual() : base()
        {
        }

        public FiltroMesAtual(Filtro outroFiltro) : base(outroFiltro)
        {
        }

        public static int MesAtual { get; set; }

        public override List<ContaBancaria> Filtra(List<ContaBancaria> contas)
        {
            var listaFiltrada = new List<ContaBancaria>();
            foreach (var contaBancaria in contas)
            {
                if (contaBancaria.Mes == MesAtual)
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
