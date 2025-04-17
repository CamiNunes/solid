// Uso correto:
using lsp.Solution;

var arquivoNormal = new ArquivoEdicao { Nome = "dados.txt" };
var arquivoLeitura = new ArquivoSomenteLeitura { Nome = "config.txt" };

var processador = new ProcessadorArquivos();

processador.ProcessarLeitura(arquivoNormal);
processador.ProcessarLeitura(arquivoLeitura);

// Só permite edição para arquivos que suportam
processador.ProcessarEdicao(arquivoNormal, "novos dados");
// processador.ProcessarEdicao(arquivoLeitura, "tentativa"); // Não compila!