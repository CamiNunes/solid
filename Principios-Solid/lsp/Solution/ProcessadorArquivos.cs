using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lsp.Solution
{
    public class ProcessadorArquivos
    {
        public void ProcessarLeitura(IArquivoLeitura arquivo)
        {
            arquivo.Ler();
            Console.WriteLine($"Leitura completa. Tamanho: {arquivo.Tamanho}");
        }

        public void ProcessarEdicao(IArquivoEscrita arquivo, string conteudo)
        {
            arquivo.Ler();
            arquivo.Escrever(conteudo);
            Console.WriteLine($"Edição completa. Novo tamanho: {arquivo.Tamanho}");
        }
    }
}
