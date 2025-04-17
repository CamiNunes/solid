namespace isp.Problem
{
    public interface IFuncionarioRepository
    {
        // Operações básicas
        void Adicionar(Funcionario funcionario);
        Funcionario ObterPorId(int id);
        IEnumerable<Funcionario> ObterTodos();

        // Operações específicas de RH
        void AprovarFerias(int funcionarioId, DateTime inicio, DateTime fim);
        void RegistrarAumento(int funcionarioId, decimal percentual);
        void GerarRelatorioDesempenho(int funcionarioId);

        // Operações de folha de pagamento
        void CalcularSalario(int funcionarioId);
        void GerarContraCheque(int funcionarioId);
        void ExportarParaFolhaPagamento(int funcionarioId);

        // Operações de benefícios
        void AdicionarBeneficio(int funcionarioId, Beneficio beneficio);
        void RemoverBeneficio(int funcionarioId, int beneficioId);
    }
}
