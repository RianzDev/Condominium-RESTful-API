using System.Data;
using Condominium.Domain.Models;

namespace Condominium.Domain.Interfaces;

public interface IApartamentRepository{

    IEnumerable<Apartament> GetAll();
    Apartament GetById(int id);
    void Create(Apartament apartament);
    void Update(Apartament apartament);       
    void Delete (Apartament apartament);

}