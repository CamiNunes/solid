namespace isp.Problem
{
    public class BeneficioFuncionario
    {
        public int FuncionarioId { get; set; }
        public Funcionario Funcionario { get; set; }
        public int BeneficioId { get; set; }
        public Beneficio Beneficio { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime? DataFim { get; set; }
    }
}
