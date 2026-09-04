using Microsoft.AspNetCore.Http.HttpResults;
using VideoGameCharacterApi.Models;
using System.Linq;

namespace VideoGameCharacterApi.Services
{
    public class VideoGameCharacterService : IVideoGameCharacterService
    {

        static List<Character> characters = new List<Character>
        {
                new Models.Character { Id = 1, Name = "Mario", Game = "SuperMario Bros", Role = "Protag" },
                new Models.Character { Id = 2, Name = "Link", Game = "TLO Zelda", Role = "Protag" },
                new Models.Character { Id = 3, Name = "Master Chief", Game = "Halo", Role = "Protag" }
        };

        public Task<Character> AddCharacterAsync(Character character)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteCharacterAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Character>> GetAllCharactersAsync() =>  await Task.FromResult(characters);

        public async Task<Character?> GetCharactersByIdAsync(int id) => await Task.FromResult(characters.FirstOrDefault(c => c.Id == id));

        public Task<bool> UpdateCharacterAsync(int id, Character character)
        {
            throw new NotImplementedException();
        }
    }
}
