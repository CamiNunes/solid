using isp.Problem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace isp.Solution
{
    // Implementações especializadas
    public class FuncionarioPublicRepository : IRepository<Funcionario>
    {
        public void Adicionar(Funcionario funcionario)
        {
            // Lógica real de adição
        }

        public Funcionario ObterPorId(int id)
        {
            return null;
        }

        public IEnumerable<Funcionario> ObterTodos()
        {
            return null;
        }
    }
}
