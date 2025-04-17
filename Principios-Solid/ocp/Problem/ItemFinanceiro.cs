namespace ocp.Problem
{
    public class ItemFinanceiro
    {
        public string Descricao { get; set; }
        public decimal Valor { get; set; }
        public TipoItemFinanceiro Tipo { get; set; }
        public DateTime Data { get; set; }
    }
}
