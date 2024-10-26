using Condominium.API.Dtos.Requests;
using Condominium.API.Dtos.Response;
using Condominium.Domain.Models;

namespace Condominium.API.Mappers;

public static class DomainToDtoMapper
{
    public static BlockResponse ToResponse(Block block){

        BlockResponse response = new BlockResponse(block.Id, block.Name);
        return response;
    }
       public static BlockRequest ToRequest(Block block){

        BlockRequest request = new BlockRequest(block.Id, block.Name);
        return request;
    }
}