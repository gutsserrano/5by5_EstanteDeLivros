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

        public Estante()
        {
            estante = new Livro[10];
            qtdLivros = 0;
        }

        public void AdicionarLivro(Livro livro)
        {
            estante[qtdLivros] = livro;
            qtdLivros++;
        }

        public void ImprimirEstante()
        {
            for (int i = 0; i < qtdLivros; i++)
            {
                Console.WriteLine($"\n=========Livro {i}===========\n");
                Console.WriteLine(this.estante[i].ImprimirLivro());
            }
        }

        public void ImprimirPorIndice(int i)
        {
            bool existe = false;
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
        }
    }
}
