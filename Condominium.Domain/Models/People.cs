namespace Condominium.Domain.Models{

    public class People{

        public int Id {get;set;}
        public string Name{get;set;}
       
        public string Password {get;set;}
        public string Email {get;set;}  
        
        public People(int id, string name, string password, string email)
        {
            Id = id;
            Name = name;   
            Password = password;    
            Email = email;


        }
        public People()
        {
            Name = string.Empty;
        }
    }
}