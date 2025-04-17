using isp.Problem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace isp.Solution
{
    // Serviço completo que usa várias interfaces
    public class FuncionarioInternalService
    {
        private readonly IRepository<Funcionario> _repository;
        private readonly IRhService _rhService;
        private readonly IFolhaPagamentoService _folhaService;

        public FuncionarioInternalService(
            IRepository<Funcionario> repository,
            IRhService rhService,
            IFolhaPagamentoService folhaService)
        {
            _repository = repository;
            _rhService = rhService;
            _folhaService = folhaService;
        }

        public void PromoverFuncionario(int funcionarioId, decimal aumentoPercentual)
        {
            var funcionario = _repository.ObterPorId(funcionarioId);
            _rhService.RegistrarAumento(funcionarioId, aumentoPercentual);
            _folhaService.CalcularSalario(funcionarioId);
        }
    }
}
