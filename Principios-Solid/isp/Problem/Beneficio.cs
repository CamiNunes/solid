namespace isp.Problem
{
    public class Beneficio
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public TipoBeneficio Tipo { get; set; }
        public decimal Valor { get; set; }
        public bool Ativo { get; set; } = true;
        public ICollection<BeneficioFuncionario> Funcionarios { get; set; } = new List<BeneficioFuncionario>();

        // Método para calcular custo mensal
        public decimal CalcularCustoMensal()
        {
            return Funcionarios.Count(f => f.DataFim == null) * Valor;
        }
    }
}
