namespace Condominium.API.Dtos.Response;


public class BlockResponse
{
    public BlockResponse(int id, string name)
    {
        Id =  id;
        Name = name;       

    }
    public int Id { get; set; }
    public string Name {get;set;}

}