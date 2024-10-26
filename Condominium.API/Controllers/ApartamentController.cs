using Condominium.Domain.Interfaces;
using Condominium.Domain.Models;
using Condominium.Infrastructure.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Condominium.API.Controllers;
[Route ("api/apartament")]
[ApiController]

public class ApartamentController: ControllerBase
{
    private readonly IApartamentRepository _repo;
    public ApartamentController (IApartamentRepository repo){
        _repo = repo;
    }

    [HttpGet]
    public ActionResult<IEnumerable<Apartament>> GetAll(){
        return Ok(_repo.GetAll());

    }
    [HttpGet]
    [Route("{id}")]

    public ActionResult<Apartament> GetById(int id){
        Apartament apartament = _repo.GetById(id);
        if(apartament == null){
            return NotFound($"NOT FOUND APARTAMENT WITH {id}");
        }
        return Ok(apartament);        
    }



    [HttpPost]
    public ActionResult<Apartament> Create (Apartament apartament)
    {
        if(apartament == null)
        {
            return BadRequest("INVALID APARTAMENT");
        }
            _repo.Create(apartament);
            return Created(string.Empty,apartament);
    }
    [HttpPut]
    [Route("{id}")]
    public ActionResult<Apartament> Update([FromRoute]int id, [FromBody] Apartament apartament){
        Apartament apartamentToPut = _repo.GetById(id);
        if(apartamentToPut == null)
        {
            return NotFound($"Not found Apartament with id: {id}");
        }
          apartamentToPut.Number  = apartament.Number;
          apartamentToPut.BlockId = apartament.BlockId;
          
        _repo.Update(apartamentToPut);
        return Ok(apartamentToPut);

    }




    [HttpDelete]
    public ActionResult<Apartament> Delete(int id)
    {
        Apartament apartament = _repo.GetById(id);
        if(apartament == null)
        {
            return NotFound($"Not found Apartament with id: {id}");
        }
        _repo.Delete(apartament);
        return Ok(apartament);
    }



}


