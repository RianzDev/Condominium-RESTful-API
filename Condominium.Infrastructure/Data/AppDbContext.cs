using Condominium.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Condominium.Infrastructure.Data;

public class AppDbContext:DbContext{

    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) 
    {
        
    }
    public DbSet <People> Peoples {get;set;}
}


