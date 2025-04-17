namespace lsp.Problem
{
    public class Arquivo
    {
        public string Nome { get; set; }
        public int Tamanho { get; set; }

        public virtual void Ler()
        {
            Console.WriteLine($"Lendo arquivo {Nome}");
        }

        public virtual void Escrever(string conteudo)
        {
            Console.WriteLine($"Escrevendo no arquivo {Nome}");
            Tamanho += conteudo.Length;
        }
    }
}
