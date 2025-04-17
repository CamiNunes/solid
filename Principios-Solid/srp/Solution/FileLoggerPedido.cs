using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
