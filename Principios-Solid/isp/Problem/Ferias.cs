namespace isp.Problem
{
    public class Ferias
    {
        public int Id { get; set; }
        public int FuncionarioId { get; set; }
        public Funcionario Funcionario { get; set; }
        public DateTime Inicio { get; set; }
        public DateTime Fim { get; set; }
        public bool Aprovado { get; set; }
        public DateTime? DataAprovacao { get; set; }
    }
}
