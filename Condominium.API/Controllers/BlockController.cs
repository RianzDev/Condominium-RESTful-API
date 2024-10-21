using Condominium.Domain.Interfaces;
using Condominium.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace Condominium.API.Controllers;


public class BlockController: ControllerBase
{
    private readonly IBlockRepository _repo;
    public BlockController(IBlockRepository repo)
    {
        _repo = repo;
    }
    
    [HttpGet]
    public ActionResult<IEnumerable<Block>GetAll(){
        IEnumerable <Block> blocks = _repo.GetAll(); 
        return Ok(blocks);
    }

    [HttpGet]
    [Route("id")]
    public ActionResult <Block> GetById([FromQuery]int id){ 
        Block block = _repo.GetById(id);
        if(block == null){
            return NotFound();
        }

    }  

    [HttpPost]
    public ActionResult<Block> Create ([FromBody]Block block){
       _repo.Create(block);
        return Ok(string.Empty,block);
    }

    [HttpDelete]
    public ActionResult <Block> Delete(int id){
        Block block = _repo.DeleteById(id);
        if(block == null){
            return NotFound();
        }
        _repo.Delete(block);
        return Ok(block);
    }

}

    