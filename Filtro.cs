
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiltroDeContas
{
    public abstract class Filtro
    {
        public Filtro OutroFiltro { get; set; }
        public Filtro(Filtro outroFiltro)
        {
            this.OutroFiltro = outroFiltro;
        }
        public Filtro()
        {
            this.OutroFiltro = null;
        }

        public abstract List<ContaBancaria> Filtra(List<ContaBancaria> contas);
    }
}
