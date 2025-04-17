using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lsp.Solution
{
    public interface IArquivoLeitura
    {
        string Nome { get; }
        int Tamanho { get; }
        void Ler();
    }
}
