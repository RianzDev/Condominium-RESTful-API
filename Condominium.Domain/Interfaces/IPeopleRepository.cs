using Condominium.Domain.Models;

namespace Condominium.Domain.Interfaces;

public interface IPeopleRepository{


    IEnumerable<People> GetAll();
    People? GetById(int id);
    void Create(People people);
    void Update(People people);
    void Delete(People people );
}