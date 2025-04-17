using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace isp.Solution
{
    public class RhService : IRhService
    {
        public void AprovarFerias(int funcionarioId, DateTime inicio, DateTime fim)
        {
            // Lógica real de aprovação de férias
        }

        public void GerarRelatorioDesempenho(int funcionarioId)
        {
            throw new NotImplementedException();
        }

        public void RegistrarAumento(int funcionarioId, decimal percentual)
        {
            throw new NotImplementedException();
        }
    }
}
