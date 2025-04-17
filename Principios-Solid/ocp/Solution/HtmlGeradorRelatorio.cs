using ocp.Problem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ocp.Solution
{
    public class HtmlGeradorRelatorio : IGeradorRelatorio
    {
        public bool PodeGerar(TipoRelatorio tipo) => tipo == TipoRelatorio.HTML;

        public void Gerar(DadosFinanceiros dados, string caminhoSaida)
        {
            var html = $@"
        <html>
            <body>
                <h1>Relatório Financeiro - {DateTime.Now}</h1>
                <p>Receita: {dados.Receita}</p>
                <p>Despesas: {dados.Despesa}</p>
                <p>Lucro: {dados.Receita - dados.Despesa}</p>
            </body>
        </html>";

            File.WriteAllText(caminhoSaida, html);
        }
    }
}
