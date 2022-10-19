using Chapter.Contexts;
using Chapter.Models;

namespace Chapter.Repositories
{
    public class LivroRepository
    {
        private readonly ChapterContext _context;
        public LivroRepository(ChapterContext context)
        {
            _context = context;
        }
        public List<Livro> Listar()
        {
            return _context.Livros.ToList();
        }
        public Livro BuscarPorId(int Id)
        {
            return _context.Livros.Find(Id);
        }
        public void Cadastrar(Livro livro)
        {
            _context.Livros.Add(livro);

            _context.SaveChanges();
        }
        public void Deletar(int Id)
        {
            Livro livro = _context.Livros.Find(Id);

            _context.Livros.Remove(livro);

            _context.SaveChanges();
        }
        public void Atualizar(int Id, Livro livro)
        {
            Livro livroBuscado = _context.Livros.Find(Id);

            if (livroBuscado != null)
            {
                livroBuscado.Titulo = livro.Titulo;
                livroBuscado.QuantidadePaginas = livro.QuantidadePaginas;
                livroBuscado.Disponivel = livro.Disponivel;
            }

            _context.Livros.Update(livroBuscado);

            _context.SaveChanges();
        }
    }
}
