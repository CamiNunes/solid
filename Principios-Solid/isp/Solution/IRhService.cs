namespace isp.Solution
{
    public interface IRhService
    {
        void AprovarFerias(int funcionarioId, DateTime inicio, DateTime fim);
        void RegistrarAumento(int funcionarioId, decimal percentual);
        void GerarRelatorioDesempenho(int funcionarioId);
    }
}
