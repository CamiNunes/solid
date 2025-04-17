using isp.Problem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace isp.Solution
{
    // Serviço que usa apenas o necessário
    public class FuncionarioPublicService
    {
        private readonly IRepository<Funcionario> _repository;

        public FuncionarioPublicService(IRepository<Funcionario> repository)
        {
            _repository = repository;
        }

        public IEnumerable<Funcionario> ListarFuncionarios()
        {
            return _repository.ObterTodos();
        }
    }
}
