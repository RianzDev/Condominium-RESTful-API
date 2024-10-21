namespace Condominium.Domain.Models
{
    
    public class Block{

        public int Id { get; set; }
        public string Name {get;set;}

        public ICollection <Apartament> Apartments {get;set;}
        public Block (int id, string name){

            Id = id;
            Name = name;
        }

    }

}