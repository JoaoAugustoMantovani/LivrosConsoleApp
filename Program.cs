Console.WriteLine("Informe quantos livros você quer cadastrar: ");
int tamanho = int.Parse(Console.ReadLine());

Livro[] livros = new Livro[tamanho];

CadastrarLivros();
ExibirLivros(livros);

Livro CriarLivro()
{
    Console.WriteLine("Insira o Titulo do livro: ");
    string titulo = Console.ReadLine();

    Console.WriteLine("Insira o Autor do livro: ");
    string autor = Console.ReadLine();

    Console.WriteLine("Insira a Quantidade de Páginas do livro: ");
    int qtdPaginas = int.Parse(Console.ReadLine());

    Livro livro = new Livro(titulo, autor, qtdPaginas);
    return livro;
}

void CadastrarLivros()
{
    for (int i = 0; i < livros.Length; i++)
    {
        livros[i] = CriarLivro();
    }
}

void ExibirLivros(Livro[] livros)
{
    for (int i = 0; i < livros.Length; i++)
    {
        Console.WriteLine(livros[i].ToString());
    }
}