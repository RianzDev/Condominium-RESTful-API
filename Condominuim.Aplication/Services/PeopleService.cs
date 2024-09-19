using System.Runtime.InteropServices;
using Condominium.Domain.Models;
using Condominium.Infrastructure.Data;

namespace   Condominuim.Aplication.Services;

public class PeopleService
{
    private readonly AppDbContext _context;

    public PeopleService(AppDbContext context)
    {
        _context = context;

    } 
    public List<People> GetAll()
    {
        List <People> peoples = _context.Peoples.ToList();
        return peoples;
    }
        
    public void Create(People people)
    {
        _context.Peoples.Add(people);
            
    } 
} 
    
    
