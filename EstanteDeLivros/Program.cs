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
                        EditarLivro();
                        break;
                    case 4:
                        estante.ImprimirEstante();
                        Console.ReadKey();
                        break;
                    case 5:
                        Console.WriteLine("\nQual livro voce deseja buscar (digite o índice)?");
                        estante.ImprimirPorIndice(int.Parse(Console.ReadLine()));
                        Console.ReadKey();
                        break;
                    default:
                        break;
                }


            } while (option != 6);

            Livro CriarLivro()
            {
                string titulo, editora, isbn;
                string[] autores, auxAutores = new string[5];
                int edicao, paginas;
                DateOnly lancamento;

                Console.WriteLine("\nTitulo:");
                titulo = Console.ReadLine();

                int counter = 0;
                string aux = "";
                do
                {
                    Console.WriteLine($"\nAutor {counter + 1}:");
                    auxAutores[counter] = Console.ReadLine();
                    counter++;

                    if (counter < 5)
                    {
                        Console.WriteLine("\nDeseja cadastrar mais um autor?");
                        Console.WriteLine("s - sim");
                        Console.WriteLine("qualquer outra tecla - não");
                        aux = Console.ReadLine();
                    }
                } while (aux == "s" && counter < 5);

                // copia os valores de auxAutores para autores com o tamanho correto para impressão
                autores = new string[counter];
                for(int i = 0; i < counter; i++)
                {
                    autores[i] = auxAutores[i];
                }

                Console.WriteLine("\nData de lançamento:");
                lancamento = DateOnly.Parse(Console.ReadLine());

                Console.WriteLine("\nEditora:");
                editora = Console.ReadLine();

                Console.WriteLine("\nEdição:");
                edicao = int.Parse(Console.ReadLine());

                Console.WriteLine("\nISBN:");
                isbn = Console.ReadLine();

                Console.WriteLine("\nQuantidade de páginas:");
                paginas = int.Parse(Console.ReadLine());

                return new(titulo, autores, lancamento, editora, edicao, isbn, paginas);

            }

            void EditarLivro()
            {
                int input, op;

                Console.WriteLine("\nQual livro voce deseja editar (digite o índice)?");
                input = int.Parse(Console.ReadLine());
                bool aux = estante.ImprimirPorIndice(input);
                if (aux)
                {
                    op = MenuEditar();
                    estante.EditarLivro(op, input);
                }
                else
                {
                    Console.ReadKey();
                }
            }

            int MenuEditar()
            {
                int option;
                do
                {
                    Console.WriteLine("\nEditar Livro:\n");
                    Console.WriteLine("1 - Título");
                    Console.WriteLine("2 - Autores");
                    Console.WriteLine("3 - Data de lançamento");
                    Console.WriteLine("4 - Editora");
                    Console.WriteLine("5 - Edição");
                    Console.WriteLine("6 - ISBN");
                    Console.WriteLine("7 - QTD páginas");
                    Console.WriteLine("8 - Cancelar");
                    option = int.Parse(Console.ReadLine());
                } while (option < 1 || option > 8);

                return option;
            }

            int Menu()
            {
                int option;
                do
                {
                    Console.WriteLine("\nEstante de livros:");
                    Console.WriteLine("1 - Adicionar Livro");
                    Console.WriteLine("2 - Remover Livro");
                    Console.WriteLine("3 - Editar Livro");
                    Console.WriteLine("4 - Imprimir todos os livros");
                    Console.WriteLine("5 - Imprimir por índice");
                    Console.WriteLine("6 - sair");
                    option = int.Parse(Console.ReadLine());
                } while (option < 1 || option > 6);

                return option;
            }
        }
    }
}
