using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PooApi.Data
{
    public class Livro
    {
        public int Id { get; set; }
        public string ExternalId { get; private set; }
        public string Nome { get; set; }
        public  string Autor { get; set; }
        public int Paginas { get; set; }
        public Categorias categoria { get; set; }


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
