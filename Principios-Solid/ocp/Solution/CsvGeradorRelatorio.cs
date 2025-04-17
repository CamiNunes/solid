using ocp.Problem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ocp.Solution
{
    public class CsvGeradorRelatorio : IGeradorRelatorio
    {
        public bool PodeGerar(TipoRelatorio tipo) => tipo == TipoRelatorio.CSV;

        public void Gerar(DadosFinanceiros dados, string caminhoSaida)
        {
            var csv = new StringBuilder();
            csv.AppendLine("Data,Receita,Despesa,Lucro");
            csv.AppendLine($"{DateTime.Now},{dados.Receita},{dados.Despesa},{dados.Receita - dados.Despesa}");

            File.WriteAllText(caminhoSaida, csv.ToString());
        }
    }
}
