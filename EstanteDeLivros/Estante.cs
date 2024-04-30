using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstanteDeLivros
{
    public class Estante
    {
        private Livro[] estante;
        private int qtdLivros;
        private int MAXLIVROS = 10;

        public Estante()
        {
            estante = new Livro[MAXLIVROS];
            qtdLivros = 0;
        }

        public void AdicionarLivro(Livro livro)
        {
            if (qtdLivros < MAXLIVROS)
            {
                estante[qtdLivros] = livro;
                qtdLivros++;
                Console.WriteLine("\n**Livro Adicionado com sucesso**\n");
            }
            else
            {
                Console.WriteLine("\n**Estante Cheia, remova um livro para adicionar outro**\n");
            }
        }

        public void RemoverLivro(int i)
        {
            bool existe = false;

            if (qtdLivros != 0)
            {
                for (int j = 0; j < qtdLivros - 1; j++)
                {
                    if (j == i)
                    {
                        existe = true;
                    }

                    if (existe)
                    {
                        estante[j] = estante[j + 1];
                    }
                }
                if (i == qtdLivros - 1)
                {
                    existe = true;
                }
            }
            

            if (existe)
            {
                Console.WriteLine("\n**Livro removido com sucesso!\n");
                qtdLivros--;
            }
            else
            {
                Console.WriteLine("\n**Livro não encontrado**\n");
            }
        }

        public void EditarLivro(int op, int i)
        {
            switch (op)
            {
                case 1:
                    Console.WriteLine("\nDigite o título novo:");
                    string titulo = Console.ReadLine();
                    estante[i].setTitulo(titulo);
                    break;
                case 2:
                    Console.WriteLine("\nEditar autores:");
                    estante[i].setAutores(MenuAutores());
                    break;
                case 3:
                    Console.WriteLine("\nEditar lançamento:");
                    estante[i].setLancamento(DateOnly.Parse(Console.ReadLine()));
                    break;
                case 4:
                    Console.WriteLine("\nEditar editora:");
                    estante[i].setEditora(Console.ReadLine());
                    break;
                case 5:
                    Console.WriteLine("\nEditar edição:");
                    estante[i].setEdicao(int.Parse(Console.ReadLine()));
                    break;
                case 6:
                    Console.WriteLine("\nEditar ISBN:");
                    estante[i].setIsbn(Console.ReadLine());
                    break;
                case 7:
                    Console.WriteLine("\nEditar QTD de páginas:");
                    estante[i].setQtdPaginas(int.Parse(Console.ReadLine()));
                    break;
                default:
                    break;
            }
        }

        private string[] MenuAutores()
        {
            string[] autores, auxAutores = new string[5];
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
            for (int i = 0; i < counter; i++)
            {
                autores[i] = auxAutores[i];
            }

            return autores;
        }

        public void ImprimirEstante()
        {
            Console.Clear();
            for (int i = 0; i < qtdLivros; i++)
            {
                Console.WriteLine($"\n=========Livro {i}===========\n");
                Console.WriteLine(this.estante[i].ImprimirLivro());
            }
            Console.WriteLine($"\n=============================\n");
        }

        public bool ImprimirPorIndice(int i)
        {
            Console.Clear();
            
            if(i >= 0 && i < qtdLivros)
            {
                Console.WriteLine($"\n=========Livro {i}===========\n");
                Console.WriteLine(this.estante[i].ImprimirLivro());
                Console.WriteLine($"\n=============================\n");
                return true;
            }
            else
            {
                Console.WriteLine("\n**Livro não encontrado**\n");
                return false;
            }
        }

        public Livro BuscarPorIndice(int i)
        {
            if(i > 0 && i < qtdLivros)
            {
                return estante[i];
            }
            else
            {
                return null;
            }
        }
    }
}
