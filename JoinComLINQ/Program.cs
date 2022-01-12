using JoinComLINQ.Entidades;

List<Livro> listaLivro = new List<Livro>();
listaLivro.Add(new Livro() { livroID = 1, AutorID = 2, Titulo = "Amor amado" });
listaLivro.Add(new Livro() { livroID = 2, AutorID = 2, Titulo = "Bem amado" });
listaLivro.Add(new Livro() { livroID = 3, AutorID = 3, Titulo = "Um espião em washington" });
listaLivro.Add(new Livro() { livroID = 4, AutorID = 1, Titulo = "A vida na terra" });

List<Autor> listaAutor = new List<Autor>();
listaAutor.Add(new Autor() { AutorID = 1, Nome = "Leonardo" });
listaAutor.Add(new Autor() { AutorID = 2, Nome = "Maria" });
listaAutor.Add(new Autor() { AutorID = 3, Nome = "João" });

var listaJoin = from livros in listaLivro join autor in listaAutor on livros.AutorID equals autor.AutorID select new { livros, autor };

foreach (var item in listaJoin)
{
    Console.WriteLine("Livro: " + item.livros.Titulo + " - Autor: " + item.autor.Nome);
}

Console.ReadKey();


