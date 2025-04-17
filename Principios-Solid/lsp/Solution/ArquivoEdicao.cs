using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lsp.Solution
{
    public class ArquivoEdicao : IArquivoEscrita
    {
        public string Nome { get; set; }
        public int Tamanho { get; private set; }

        public void Ler()
        {
            Console.WriteLine($"Lendo arquivo {Nome}");
        }

        public void Escrever(string conteudo)
        {
            Console.WriteLine($"Escrevendo no arquivo {Nome}");
            Tamanho += conteudo.Length;
        }
    }
}
