
using CineHub.Api.Models;
using Microsoft.EntityFrameworkCore;

namespace CineHub.Api.Data;

public class DataContext : DbContext
{

    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {
        
    }

    public DbSet<Film> Films { get; set; }

}
