using Microsoft.AspNetCore.Mvc;
using Condominium.Domain.Interfaces;
using Condominium.Infrastructure.Repositories;
using Condominium.Domain.Models;
using Microsoft.AspNetCore.Http.HttpResults;
using System.Reflection.Metadata.Ecma335;
namespace Condominium.API.Controllers;

[Route("api/people")]
[ApiController]
public class PeopleController:ControllerBase{

  private readonly IPeopleRepository _repo;
  public PeopleController(IPeopleRepository repo)
  {
    _repo = repo;
  } 
    
    [HttpGet]
    public ActionResult<IEnumerable<People>> GetAll(){
    IEnumerable <People> peoples = _repo.GetAll();
     return Ok(peoples);   
  }

    [HttpGet]
    [Route("id")]    
     public ActionResult<People> GetById([FromQuery]int id){
     People people = _repo.GetById(id);
     if(people == null){
        return NotFound();
     }     
     return Ok (people);
  }

   [HttpPost]
     public ActionResult Create([FromBody]People people){
    _repo.Create(people);
    return Created(string.Empty,people);    
   }    
  
  [HttpDelete]
  public ActionResult <People> Delete (int id){

    People people = _repo.GetById(id);
    if(people == null){
        return NotFound();
    }
    _repo.Delete(people);
    return Ok(people);
 }

    [HttpPut]
    public ActionResult<People> GetById(People people){
        _repo.Update(people);
        return Ok(people); 
    }
}

