using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lsp.Solution
{
    public interface IArquivoEscrita : IArquivoLeitura
    {
        void Escrever(string conteudo);
    }
}
