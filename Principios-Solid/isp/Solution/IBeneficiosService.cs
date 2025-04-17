using isp.Problem;

namespace isp.Solution
{
    public interface IBeneficiosService
    {
        void AdicionarBeneficio(int funcionarioId, Beneficio beneficio);
        void RemoverBeneficio(int funcionarioId, int beneficioId);
    }
}
