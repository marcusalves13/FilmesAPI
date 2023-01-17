using FilmeApi.Models;
using Microsoft.EntityFrameworkCore;

namespace FilmeApi.Data;

public class FilmeContext:DbContext
{
    public FilmeContext(DbContextOptions<FilmeContext> opts) : base (opts)
    {

    }

    public DbSet<Filme> Filmes { get; set; }

}
