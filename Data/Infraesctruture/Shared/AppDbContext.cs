using System.Linq;
using Microsoft.EntityFrameworkCore;
using MediatR;
using PooApi.Data.Domain;
using PooApi.Data.Domain.Shared;

namespace PooApi.Data.Infraesctruture.Shared
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<Livro> Livros { get; set; }
    }
}
