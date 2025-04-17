using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace ocp.Problem
{
    public class RelatorioFinanceiro
    {
        public void GerarRelatorio(TipoRelatorio tipo, DadosFinanceiros dados)
        {
            switch (tipo)
            {
                case TipoRelatorio.PDF:
                    GerarPdf(dados);
                    break;
                case TipoRelatorio.HTML:
                    GerarHtml(dados);
                    break;
                case TipoRelatorio.CSV:
                    throw new NotImplementedException("CSV não implementado ainda");
                default:
                    throw new NotSupportedException($"Tipo {tipo} não suportado");
            }
        }

        private void GerarPdf(DadosFinanceiros dados)
        {
            var document = new iTextSharp.text.Document();
            PdfWriter.GetInstance(document, new FileStream("relatorio.pdf", FileMode.Create));

            document.Open();
            document.Add(new Paragraph($"Relatório Financeiro - {DateTime.Now}"));
            document.Add(new Paragraph($"Receita: {dados.Receita}"));
            document.Add(new Paragraph($"Despesas: {dados.Despesa}"));
            document.Add(new Paragraph($"Lucro: {dados.Receita - dados.Despesa}"));
            document.Close();
        }

        private void GerarHtml(DadosFinanceiros dados)
        {
            var html = $@"
        <html>
            <body>
                <h1>Relatório Financeiro - {DateTime.Now}</h1>
                <p>Receita: {dados.Receita}</p>
                <p>Despesas: {dados.Despesa}</p>
                <p>Lucro: {dados.Receita - dados.Despesa}</p>
            </body>
        </html>";

            File.WriteAllText("relatorio.html", html);
        }
    }
}
