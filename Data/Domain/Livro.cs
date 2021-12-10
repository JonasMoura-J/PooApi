using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PooApi.Data
{
    public class Livro
    {

        private Livro()
        {
        }
        public Livro(string nome, string autor, int paginas, Categorias categoria) : this()
        {
            ExternalId = Guid.NewGuid().ToString();
            Nome = nome;
            Autor = autor;
            Paginas = paginas;
            Categoria = categoria;
        }
        public int Id { get; set; }
        public string ExternalId { get;  set; }
        public string Nome { get; set; }
        public  string Autor { get; set; }
        public int Paginas { get; set; }
        public Categorias Categoria { get; set; }


        public enum Categorias
        {
            Ficcao = 0,
            Suspense = 1,
            Ficcao_Cientifica = 2,
            Fantasia = 3,
            Horror = 4,
            Poesia = 5,
            Romance = 6
        }
    }
}
