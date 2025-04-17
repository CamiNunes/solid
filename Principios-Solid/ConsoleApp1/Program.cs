// Uso problemático:
using lsp.Problem;

var arquivoNormal = new Arquivo { Nome = "dados.txt" };
var processador = new ProcessadorArquivos();
processador.Processar(arquivoNormal); // Funciona

var arquivoLeitura = new ArquivoSomenteLeitura { Nome = "config.txt" };
processador.Processar(arquivoLeitura); // Lança exceção!