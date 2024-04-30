using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace EstanteDeLivros
{
    public class Livro
    {
        private string titulo;
        private string[] autores;
        private int qtdAutores;
        private DateOnly lancamento;
        private string editora;
        private int edicao;
        private string isbn;
        private int qtdPaginas;

        public Livro()
        {
            autores = new string[5];
            qtdAutores = 0;
        }

        public Livro(string titulo, string[] autores, DateOnly lancamento, string editora, int edicao, string isbn, int qtdPaginas)
        {
            this.titulo = titulo;
            this.autores = autores; 
            this.lancamento = lancamento;
            this.editora = editora;
            this.edicao = edicao;
            this.isbn = isbn;
            this.qtdPaginas = qtdPaginas;

            qtdAutores = autores.Length;
        }


        public void setTitulo(string t)
        {
            this.titulo = t;
        }

        public string getTitulo()
        {
            return this.titulo;
        }

        public void setAutor(string a) 
        {
            this.autores[qtdAutores++] = a;
        }

        public string getAutores()
        {
            string autor = "\nAutores: ";

            for (int i = 0; i < qtdAutores; i++)
            {
                if (i == qtdAutores - 1)
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

        public void setLancamento(DateOnly l)
        {
            this.lancamento = l;
        }

        public DateOnly getLancamento()
        {
            return lancamento;
        }

        public void setEditora(string e)
        {
            this.editora = e;
        }

        public string getEditora()
        {
            return editora;
        }

        public void setEdicao(int e)
        {
            this.edicao = e;
        }

        public int getEdicao()
        {
            return edicao;
        }

        public void setIsbn(string i)
        {
            this.isbn = i;
        }

        public string getIsbn()
        {
            return isbn;
        }

        public void setQtdPaginas(int p)
        {
            this.qtdPaginas = p;
        }

        public int getQtdPaginas()
        {
            return qtdPaginas;
        }

        public string ImprimirLivro()
        {
            string livro = "Titulo: " + getTitulo()
                + getAutores()
                + "\nData de lançamento: " + getLancamento()
                + "\nEditora: " + getEditora()
                + "\nEdição: " + getEdicao()
                + "\nISBN: " + getIsbn()
                + "\nQtd páginas: " + getQtdPaginas();

            return livro;
        }

    }
}
