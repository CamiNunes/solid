namespace isp.Problem
{
    public class HistoricoSalario
    {
        public int Id { get; set; }
        public int FuncionarioId { get; set; }
        public Funcionario Funcionario { get; set; }
        public DateTime Data { get; set; }
        public decimal SalarioAnterior { get; set; }
        public decimal NovoSalario { get; set; }
        public decimal PercentualAumento { get; set; }
    }
}
