using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lsp.Problem
{
    public class ProcessadorArquivos
    {
        public void Processar(Arquivo arquivo)
        {
            arquivo.Ler();

            // Pode falhar se for ArquivoSomenteLeitura
            arquivo.Escrever("dados atualizados");

            Console.WriteLine($"Processamento completo. Novo tamanho: {arquivo.Tamanho}");
        }
    }

}
