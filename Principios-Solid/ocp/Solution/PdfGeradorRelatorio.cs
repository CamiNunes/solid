using iTextSharp.text.pdf;
using iTextSharp.text;
using ocp.Problem;

namespace ocp.Solution
{
    public class PdfGeradorRelatorio : IGeradorRelatorio
    {
        public bool PodeGerar(TipoRelatorio tipo) => tipo == TipoRelatorio.PDF;

        public void Gerar(DadosFinanceiros dados, string caminhoSaida)
        {
            var document = new Document();
            PdfWriter.GetInstance(document, new FileStream(caminhoSaida, FileMode.Create));

            document.Open();
            document.Add(new Paragraph($"Relatório Financeiro - {DateTime.Now}"));
            document.Add(new Paragraph($"Receita: {dados.Receita}"));
            document.Add(new Paragraph($"Despesas: {dados.Despesa}"));
            document.Add(new Paragraph($"Lucro: {dados.Receita - dados.Despesa}"));
            document.Close();
        }
    }
}
