
namespace FiltroDeContas
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Nessa implementacao esperasse ter a conta 1, 2 e 3 em 
            // uma nova lista, direcionada para uma analise hipotetica expecifica.
            var conta1 = new ContaBancaria("Antonio", 30.0, 6);
            var conta2 = new ContaBancaria("Laura", 600000.0, 6);
            var conta3 = new ContaBancaria("Lucas", 600.0, 6);
            var conta4 = new ContaBancaria("Andre", 600.0, 3);
            var listaParaSerAnalizada = new List<ContaBancaria>();
            listaParaSerAnalizada.Add(conta1);
            listaParaSerAnalizada.Add(conta2);
            listaParaSerAnalizada.Add(conta3);
            listaParaSerAnalizada.Add(conta4);
            FiltroMesAtual.MesAtual = 6; // Não quis perder tempo buscando como usar o metodo Date, pois nao e o foco.
            var filtro1 = new FiltroMesAtual(new FiltroSaldoAlto(new FiltroSaldoBaixo()));
            var listaFiltrada = filtro1.Filtra(listaParaSerAnalizada);
            //Remove duplicacoes em detrimento de uma conta ser capturada por mais de um filtro
            var listaSemDuplicacoes = new HashSet<ContaBancaria>(listaFiltrada);
            var listaFiltradaSemDuplicacao = listaSemDuplicacoes.ToList();
            System.Console.WriteLine("As contas que precisam ser filtradas são as que possuem o titular :");
            //Printa o nome das pessoas que foram capturadas pelo filtro
            for (var i = 0; i < listaFiltradaSemDuplicacao.Count(); i++)
            {
                System.Console.WriteLine($"{listaFiltradaSemDuplicacao[i].Nome}");
            }
        }
    }
}