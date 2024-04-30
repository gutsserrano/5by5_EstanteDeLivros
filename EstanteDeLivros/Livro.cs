using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstanteDeLivros
{
    public class Livro
    {
        public string titulo;
        public string[] autores;
        public int qtdAutores;
        public DateOnly lancamento;
        public string editora;
        public int edicao;
        public string isbn;
        public int qtdPaginas;

        public Livro()
        {
            autores = new string[5];
            qtdAutores = 0;
        }

        public void DefinirTitulo(string t)
        {
            this.titulo = t;
        }

        public void DefinirAutor(string a) 
        {
            this.autores[qtdAutores++] = a;
        }

        public void DefinirLancamento(DateOnly l)
        {
            this.lancamento = l;
        }

        public void DefinirEditora(string e)
        {
            this.editora = e;
        }

        public void DefinirEdicao(int e)
        {
            this.edicao = e;
        }

        public void DefinirIsbn(string i)
        {
            this.isbn = i;
        }

        public void DefinirQtdPaginas(int p)
        {
            this.qtdPaginas = p;
        }

        public string ImprimirLivro()
        {
            string livro = "Titulo: " + this.titulo
                + ImprimirAutores()
                + "\nData de lançamento: " + this.lancamento
                + "\nEditora: " + this.editora
                + "\nEdição: " + this.edicao
                + "\nISBN: " + this.isbn
                + "\nQtd páginas: " + this.qtdPaginas;

            return livro;
        }

        public string ImprimirAutores()
        {
            string autor = "\nAutores: ";

            for(int i = 0; i < qtdAutores; i++)
            {
                if(i == qtdAutores - 1)
                {
                    autor += autores[i];
                }
                else
                {
                    autor += autores[i] + ", ";
                }
            }

            return autor;
        }
    }
}
