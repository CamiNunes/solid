using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lsp.Problem
{
    public class ArquivoSomenteLeitura : Arquivo
    {
        public override void Escrever(string conteudo)
        {
            throw new InvalidOperationException("Arquivo é somente leitura");
        }
    }
}
