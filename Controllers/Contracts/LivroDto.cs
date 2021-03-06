using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static PooApi.Data.Livro;

namespace PooApi.Controllers
{
    public class LivroDto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Autor { get; set; }
        public int Paginas { get; set; }
        public Categorias Categoria { get; set; }
    }
}
