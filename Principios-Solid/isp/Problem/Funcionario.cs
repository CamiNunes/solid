namespace isp.Problem
{
    public class Funcionario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Email { get; set; }
        public DateTime DataAdmissao { get; set; }
        public DateTime? DataDemissao { get; set; }
        public decimal SalarioBase { get; set; }
        public Cargo Cargo { get; set; }
        public Departamento Departamento { get; set; }
        public ICollection<BeneficioFuncionario> Beneficios { get; set; } = new List<BeneficioFuncionario>();
        public ICollection<Ferias> Ferias { get; set; } = new List<Ferias>();
        public ICollection<HistoricoSalario> HistoricoSalarios { get; set; } = new List<HistoricoSalario>();

        // Propriedade calculada
        public bool Ativo => DataDemissao == null;

        // Métodos de negócio
        public void AplicarAumento(decimal percentual)
        {
            var aumento = SalarioBase * (percentual / 100);
            var novoSalario = SalarioBase + aumento;

            HistoricoSalarios.Add(new HistoricoSalario
            {
                Data = DateTime.Now,
                SalarioAnterior = SalarioBase,
                NovoSalario = novoSalario,
                PercentualAumento = percentual
            });

            SalarioBase = novoSalario;
        }

        public void AdicionarBeneficio(Beneficio beneficio, DateTime dataInicio)
        {
            if (Beneficios.Any(b => b.BeneficioId == beneficio.Id && b.DataFim == null))
                throw new InvalidOperationException("Funcionário já possui este benefício ativo");

            Beneficios.Add(new BeneficioFuncionario
            {
                Beneficio = beneficio,
                DataInicio = dataInicio,
                Funcionario = this
            });
        }

        public void RemoverBeneficio(int beneficioId, DateTime dataFim)
        {
            var beneficio = Beneficios.FirstOrDefault(b =>
                b.BeneficioId == beneficioId && b.DataFim == null);

            if (beneficio == null)
                throw new InvalidOperationException("Benefício não encontrado ou já encerrado");

            beneficio.DataFim = dataFim;
        }
    }
}
