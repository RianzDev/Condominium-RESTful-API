using System.Text.Json.Serialization;

namespace Condominium.API.Dtos.Requests;

public class BlockRequest{

    [JsonIgnore]
    public int Id { get; set; }
    public string Name {get;set;}
    public BlockRequest(int id, string name)
    {
        
         Id =  id;
        Name = name;       

    }

}
