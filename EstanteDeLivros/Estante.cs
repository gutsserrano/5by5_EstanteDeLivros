using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstanteDeLivros
{
    public class Estante
    {
        public Livro[] estante;
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

            for(int j = 0; j < qtdLivros - 1; j++)
            {
                if(j == i)
                {
                    existe = true;
                }

                if (existe)
                {
                    estante[j] = estante[j + 1];
                }
            }

            if(i == qtdLivros - 1)
            {
                existe = true;
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

        public void ImprimirPorIndice(int i)
        {
            bool existe = false;

            Console.Clear();
            for (int j = 0; j < qtdLivros && !existe; j++)
            {
                if(j == i)
                {
                    existe = true;
                    Console.WriteLine($"\n=========Livro {i}===========\n");
                    Console.WriteLine(this.estante[j].ImprimirLivro());
                }
            }

            if (!existe)
            {
                Console.WriteLine("\n**Livro não encontrado**\n");
            }
            else
            {
                Console.WriteLine($"\n=============================\n");
            }
        }
    }
}
