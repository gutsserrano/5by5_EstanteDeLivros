namespace EstanteDeLivros
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Estante estante = new Estante();

            int option;
            do
            {
                Console.Clear();
                option = Menu();
                switch (option)
                {
                    case 1:
                        estante.AdicionarLivro(CriarLivro());
                        Console.ReadKey();
                        break;
                    case 2:
                        estante.ImprimirEstante();
                        Console.WriteLine("\nQual livro você deseja remover (digite o índice)?");
                        estante.RemoverLivro(int.Parse(Console.ReadLine()));
                        Console.ReadKey();
                        break;
                    case 3:
                        estante.ImprimirEstante();
                        Console.ReadKey();
                        break;
                    case 4:
                        Console.WriteLine("\nQual livro voce deseja buscar (digite o índice)?");
                        estante.ImprimirPorIndice(int.Parse(Console.ReadLine()));
                        Console.ReadKey();
                        break;
                    default:
                        break;
                }


            } while (option != 5);

            Livro CriarLivro()
            {
                Livro livro = new Livro();

                Console.WriteLine("\nTitulo:");
                livro.DefinirTitulo(Console.ReadLine());

                int counter = 0;
                string aux = "";
                do
                {
                    Console.WriteLine($"\nAutor {counter + 1}:");
                    livro.DefinirAutor(Console.ReadLine());
                    counter++;

                    if (counter < 5)
                    {
                        Console.WriteLine("\nDeseja cadastrar mais um autor?");
                        Console.WriteLine("s - sim");
                        Console.WriteLine("qualquer outra tecla - não");
                        aux = Console.ReadLine();
                    }
                } while (aux == "s" && counter < 5);

                Console.WriteLine("\nData de lançamento (dd/mm/aaaa):");
                livro.DefinirLancamento(DateOnly.Parse(Console.ReadLine()));

                Console.WriteLine("\nEditora:");
                livro.DefinirEditora(Console.ReadLine());

                Console.WriteLine("\nEdição:");
                livro.DefinirEdicao(int.Parse(Console.ReadLine()));

                Console.WriteLine("\nISBN:");
                livro.DefinirIsbn(Console.ReadLine());

                Console.WriteLine("\nQuantidade de páginas:");
                livro.DefinirQtdPaginas(int.Parse(Console.ReadLine()));

                return livro;

            }

            int Menu()
            {
                int option;
                do
                {
                    Console.WriteLine("\nEstante de livros:");
                    Console.WriteLine("1 - Adicionar Livro");
                    Console.WriteLine("2 - Remover Livro");
                    Console.WriteLine("3 - Imprimir todos os livros");
                    Console.WriteLine("4 - Imprimir por índice");
                    Console.WriteLine("5 - sair");
                    option = int.Parse(Console.ReadLine());
                } while (option < 1 || option > 5);

                return option;
            }
        }
    }
}
