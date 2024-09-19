namespace Condominium.Domain.Models{

    public class People{

        public int Id {get;set;}
        public string Name{get;set;}
       
        public People(int id, string name)
        {
            Id = id;
            Name = name;    

        }
        public People()
        {
        }
    }
}