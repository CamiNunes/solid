namespace srp.Solution
{
    public class FileLoggerPedido : ILoggerPedido
    {
        public void Log(string mensagem)
        {
            File.AppendAllText("pedidos.log", $"[{DateTime.Now}] {mensagem}\n");
        }
    }
}
