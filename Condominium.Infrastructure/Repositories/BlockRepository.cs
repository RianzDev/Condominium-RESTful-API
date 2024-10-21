using System.Collections.Concurrent;
using System.Data.Common;
using Condominium.Domain.Interfaces;
using Condominium.Domain.Models;
using Condominium.Infrastructure.Data;


namespace Condominium.Infrastructure.Repositories;


public class BlockRepository : IBlockRepository{

    private readonly AppDbContext _db;

    public BlockRepository(AppDbContext db){
        _db=db;
    }

    public void Create(Block block)
    {
        _db.Blocks.Add(block);
        _db.SaveChanges();
    }

    public void Delete(Block block)
    {
        _db.Blocks.Remove(block);
        _db.SaveChanges();
    }

    public IEnumerable<Block> GetAll()
    {
        return _db.Blocks.ToList();
    }

    public Block GetById(int id)
    {
        return _db.Blocks.Find(id);
    }

    public void Update(Block block)
    {
        _db.Blocks.Update(block);
        _db.SaveChanges();
    }
}