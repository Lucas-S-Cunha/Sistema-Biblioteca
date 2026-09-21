using Biblioteca.Models;

namespace sisBib.Data
{
    public class LivroRepository
    {
        private static List<Livro> _tabelaLivros = new List<Livro>();
        private static int proximoId = 1; // Variável auxiliar
        public void Adicionar(Livro livro) // Método: Adiciona livros na biblioteca
        {
            livro.Id = proximoId++;
            _tabelaLivros.Add(livro);
        }
        public List<Livro> ObterTodos()
        {
            return _tabelaLivros;
        }
    }
}