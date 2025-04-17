using ocp.Problem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ocp.Solution
{
    public class RelatorioFinanceiroService
    {
        private readonly IEnumerable<IGeradorRelatorio> _geradores;

        public RelatorioFinanceiroService(IEnumerable<IGeradorRelatorio> geradores)
        {
            _geradores = geradores;
        }

        public void GerarRelatorio(TipoRelatorio tipo, DadosFinanceiros dados, string caminhoSaida)
        {
            var gerador = _geradores.FirstOrDefault(g => g.PodeGerar(tipo));

            if (gerador == null)
                throw new NotSupportedException($"Tipo de relatório {tipo} não suportado");

            gerador.Gerar(dados, caminhoSaida);
        }
    }
}
