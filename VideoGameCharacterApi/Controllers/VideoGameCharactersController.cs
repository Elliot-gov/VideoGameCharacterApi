using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VideoGameCharacterApi.Models;
using VideoGameCharacterApi.Services;

namespace VideoGameCharacterApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VideoGameCharactersController(IVideoGameCharacterService service) : ControllerBase
    {

        [HttpGet]
        public async Task<ActionResult<List<Character>>> GetCharaters() => await service.GetAllCharactersAsync();


        [HttpGet("{id}")]
        public async Task<ActionResult<Character>> GetCharacterById(int id)
        { 
            var character = await service.GetCharactersByIdAsync(id);
            return character is null ? NotFound($"Character with the id {id} was not found") : Ok(character);
        }

    }
}
