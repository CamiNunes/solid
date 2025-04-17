namespace ocp.Problem
{
    public class DadosFinanceiros
    {
        public decimal Receita { get; set; }
        public decimal Despesa { get; set; }
        public decimal Investimento { get; set; }
        public DateTime PeriodoInicio { get; set; }
        public DateTime PeriodoFim { get; set; }
        public List<ItemFinanceiro> Itens { get; set; } = new List<ItemFinanceiro>();

        // Propriedade calculada
        public decimal Lucro => Receita - Despesa;

        // Propriedade calculada com formatação
        public string MargemLucro => $"{((Receita - Despesa) / Receita * 100):0.00}%";

        // Método para adicionar itens
        public void AdicionarItem(string descricao, decimal valor, TipoItemFinanceiro tipo)
        {
            Itens.Add(new ItemFinanceiro
            {
                Descricao = descricao,
                Valor = valor,
                Tipo = tipo,
                Data = DateTime.Now
            });

            // Atualiza totais
            switch (tipo)
            {
                case TipoItemFinanceiro.Receita:
                    Receita += valor;
                    break;
                case TipoItemFinanceiro.Despesa:
                    Despesa += valor;
                    break;
                case TipoItemFinanceiro.Investimento:
                    Investimento += valor;
                    break;
            }
        }
    }
}
