using System.Collections.Generic;
using System.Threading.Tasks;
using MyMusic.Core.Models;

namespace MyMusic.Core.Repositories
{
    public interface IArtistRepository : IRepository<Artist>
    {
         Task<IEnumerable<Artist>> GetAllWithMusicAsync();
         Task<Artist> GetWithMusicByIdAsync(int id);
    }
}