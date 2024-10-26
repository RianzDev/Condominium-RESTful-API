using Condominium.API.Dtos.Requests;
using Condominium.Domain.Models;

namespace Condominium.API.Mappers;

public static class DtoToDomainMapper{
        public static Block ToBlock(BlockRequest request){
        Block block = new Block(request.Id, request.Name);
        return block;
    }


}
