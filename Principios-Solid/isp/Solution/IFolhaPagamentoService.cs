namespace isp.Solution
{
    public interface IFolhaPagamentoService
    {
        void CalcularSalario(int funcionarioId);
        void GerarContraCheque(int funcionarioId);
        void ExportarParaFolhaPagamento(int funcionarioId);
    }
}
