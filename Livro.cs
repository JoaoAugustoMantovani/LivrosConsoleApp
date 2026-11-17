public class Livro
{
    public string Titulo;
    public string Autor;
    public int NumeroDePaginas;

    public Livro(string titulo, string autor, int numeroDePaginas)
    {
        Titulo = titulo;
        Autor = autor;
        NumeroDePaginas = numeroDePaginas;
    }

    public string getTitulo(Livro livro)
    {
        return Titulo;
    }
    public string getAutor(Livro livro)
    {
        return Autor;
    }
    public int getNumeroDePaginas(Livro livro)
    {
        return NumeroDePaginas;
    }

    public override string ToString()
    {
        return $"Titulo {Titulo}\nAutor: {Autor}\nNumero de Páginas: {NumeroDePaginas}";
    }
}

