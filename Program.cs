Livro livro;
livro = CriarLivro();

Livro CriarLivro(){
    Console.WriteLine("Insira o Titulo do livro: ");
    string titulo = Console.ReadLine();
    Console.WriteLine("Insira o Autor do livro: ");
    string autor = Console.ReadLine();
    Console.WriteLine("Insira a Quantidade de Páginas do livro: ");
    int qtdPaginas = int.Parse(Console.ReadLine());

    Livro livro = new Livro(titulo, autor, qtdPaginas);
    return livro;
}

Console.WriteLine(livro.getAutor(livro));
Console.WriteLine(livro.getTitulo(livro));
Console.WriteLine(livro.getNumeroDePaginas(livro));
Console.WriteLine(livro.ToString());
