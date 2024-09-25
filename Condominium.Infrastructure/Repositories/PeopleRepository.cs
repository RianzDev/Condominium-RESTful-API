using System.Data.Common;
using Condominium.Domain.Interfaces;
using Condominium.Domain.Models;
using Condominium.Infrastructure.Data;


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

    public List<People> GetAll()
    {
        List<People> peoples = _db.Peoples.ToList();
        return peoples;
    }

    public People? GetById(int id)
    {
            People? people = _db.Peoples.Find(id);
            return people;
    }

    public void Update(People people)
    {
        _db.Peoples.Update(people);
        _db.SaveChanges();
    }
}