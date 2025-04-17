using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lsp.Solution
{
    public class ArquivoSomenteLeitura : IArquivoLeitura
    {
        public string Nome { get; set; }
        public int Tamanho { get; private set; }

        public void Ler()
        {
            Console.WriteLine($"Lendo arquivo somente leitura {Nome}");
        }
    }
}
