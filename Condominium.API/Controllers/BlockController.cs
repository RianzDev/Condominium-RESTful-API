using Condominium.API.Dtos.Requests;
using Condominium.API.Dtos.Response;
using Condominium.API.Mappers;
using Condominium.Domain.Interfaces;
using Condominium.Domain.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.OpenApi.Expressions;

namespace Condominium.API.Controllers;
[Route("api/block")]
[ApiController]
public class BlockController: ControllerBase
{
    private readonly IBlockRepository _repo;
    public BlockController(IBlockRepository repo)
    {
        _repo = repo;
    }
    
    [HttpGet]
    public ActionResult<IEnumerable<BlockResponse>> GetAll()
    {
        IEnumerable <Block> blocks = _repo.GetAll(); 
        List<BlockResponse> responses = new List<BlockResponse>();
        foreach (Block block in blocks)
        {
           responses.Add(DomainToDtoMapper.ToResponse(block));
        }
        return Ok (responses);
    }
    [HttpGet]
    [Route("apartaments/{id}")]
    public ActionResult <Block> GetByIdWithApartaments([FromRoute]int id){

        Block block = _repo.GetByIdWithApartaments(id);
        if(block == null)
        {
            return NotFound($"Not found Block with id: {id}");
        }         
        return Ok(block);
    
    }
    
    
    [HttpGet]
    [Route("{id}")]
    public ActionResult <BlockResponse> GetById([FromRoute]int id)
    { 
        Block block = _repo.GetById(id);
        if(block == null){
            return NotFound();
        }
        return Ok (DomainToDtoMapper.ToResponse(block));
    }  

    [HttpPut]
    [Route("{id}")]
    public ActionResult<BlockResponse> Update ([FromRoute] int id, [FromBody]BlockRequest request){
        Block block = _repo.GetById(id);
        if(block == null){
            return NotFound();
        }
        block.Name = request.Name;
        _repo.Update(block);
        return Ok (DomainToDtoMapper.ToResponse(block));
    }

    [HttpPost]
    public ActionResult<BlockResponse> Create ([FromBody]BlockRequest request){
        Block block = DtoToDomainMapper.ToBlock(request);
       _repo.Create(block);
        return Created(string.Empty,request);
    }

    [HttpDelete]
    public ActionResult <BlockResponse> Delete(int id)
    {
        Block block = _repo.GetById(id);
        if(block == null)
        {
            return NotFound();
        }
         _repo.Delete(block);
        
         BlockResponse response = DomainToDtoMapper.ToResponse(block);        
         return Ok(response);
             
    }

}

    