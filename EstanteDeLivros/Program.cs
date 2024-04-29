using System.Security.Cryptography.X509Certificates;

namespace EstanteDeLivros
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Estante estante = new Estante();

            Livro l1 = CriarLivro();

            estante.AdicionarLivro(l1);

            estante.ImprimirEstante();

            int option;
            do
            {
                option = Menu();
                switch (option)
                {
                    case 1:
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    default:
                        break;
                }


            } while (option != 4);

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
                    Console.WriteLine("Estante de livros:");
                    Console.WriteLine("1 - Adicionar Livro");
                    Console.WriteLine("2 - Imprimir todos os livros");
                    Console.WriteLine("3 - Imprimir por índice");
                    Console.WriteLine("4 - sair");
                    option = int.Parse(Console.ReadLine());
                } while (option < 1 || option > 4);

                return option;
            }
        }
    }
}
