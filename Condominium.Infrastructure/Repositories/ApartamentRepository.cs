
using System.Data.Common;
using Condominium.Domain.Interfaces;
using Condominium.Domain.Models;
using Condominium.Infrastructure.Data;


namespace Condominium.Infrastructure.Repositories;

public class ApartamentRepository : IApartamentRepository {

    private readonly AppDbContext _db;

    public ApartamentRepository(AppDbContext db){

        _db=db;
    }

    public void Create(Apartament apartament)
    {
       _db.Apartaments.Add(apartament);
       _db.SaveChanges();
    }

    public void Delete(Apartament apartament)
    {
        _db.Apartaments.Remove(apartament);
        _db.SaveChanges();
    }

    public IEnumerable<Apartament> GetAll()
    {
        return _db.Apartaments.ToList();
    }     

    public Apartament GetById(int id)
    {
        return _db.Apartaments.Find(id); 
    }

    public void Update(Apartament apartament)
    {
        _db.Apartaments.Update(apartament);
        _db.SaveChanges(); 
    }
}