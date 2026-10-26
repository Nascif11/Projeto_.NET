var livros = new List<string>();

while (true)
{
    Console.WriteLine("----MenuPrincipal----");
    Console.WriteLine("1-cadastrar livro");
    Console.WriteLine("2- Listar livro");
    Console.WriteLine("3- remover livro");
    Console.WriteLine("4-sair");


    var opcao = Console.ReadLine();

    switch(opcao)
    {
        case "1":
            Console.WriteLine("Digite o titulo do livro");

            var nomeLivro = Console.ReadLine();

            livros.Add(nomeLivro);

            Console.WriteLine("Livro cadastrado com sucesso");

            break;
        case "2":
            foreach (var livro in livros)
            {
                Console.WriteLine(livro);
            }
            break;
        case "3":
            Console.WriteLine("Digite o nome do livro ");
            var livroRemover = Console.ReadLine();
            var sucesso = livros.Remove(livroRemover);

            if(sucesso)
            {
                Console.WriteLine("Livro removido com sucesso");
            }else
            {
                Console.WriteLine("livro não encontrado");
            }
            break;
        case "0":
            Console.WriteLine("Encerrando aplicação");
            return;
        default:
            Console.WriteLine("Opção não encontrada");
            break;


    }

}
