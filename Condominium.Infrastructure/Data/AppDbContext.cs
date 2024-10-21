using Condominium.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Condominium.Infrastructure.Data;

public class AppDbContext:DbContext{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) 
    {
        
    }
    public DbSet <People> Peoples {get;set;}
    public DbSet <Block> Blocks {get;set;}

    public DbSet <Apartament> Apartaments {get;set;}
}


