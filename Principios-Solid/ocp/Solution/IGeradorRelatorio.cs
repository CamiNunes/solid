using ocp.Problem;

namespace ocp.Solution
{
    public interface IGeradorRelatorio
    {
        bool PodeGerar(TipoRelatorio tipo);
        void Gerar(DadosFinanceiros dados, string caminhoSaida);
    }
}
