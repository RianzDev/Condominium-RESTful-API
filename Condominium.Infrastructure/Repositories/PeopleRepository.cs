using System.Data.Common;
using Condominium.Domain.Interfaces;
using Condominium.Domain.Models;
using Condominium.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;


namespace Condominium.Infrastructure.Repositories;


public class PeopleRepository : IPeopleRepository
{
    private readonly AppDbContext _db;
     public PeopleRepository(AppDbContext db)
    {
        _db=db;
    }
    public void Create(People people)
    {
        _db.Peoples.Add(people);
        _db.SaveChanges();
    }

    public void Delete(People people)
    {
        _db.Peoples.Remove(people);
        _db.SaveChanges();
    }

    public IEnumerable<People> GetAll()
    {
        return  _db.Peoples.ToList();
    }

    public People? GetById(int id)
    {
        return _db.Peoples.FirstOrDefault(x => x.Id == id);
    }

    public void Update(People people)
    {
        _db.Peoples.Update(people);
        _db.SaveChanges();
    }

    
}

