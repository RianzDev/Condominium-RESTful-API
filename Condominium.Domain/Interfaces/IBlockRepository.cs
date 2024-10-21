using System.Reflection.Metadata;
using Condominium.Domain.Models;

namespace Condominium.Domain.Interfaces;

public interface IBlockRepository{

    IEnumerable<Block> GetAll();
    Block GetById(int id);   
    void Create(Block block);
    void Update(Block block);
    void Delete(Block block );
}

