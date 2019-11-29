using AutoMapper;
using MyMusic.Api.Resources;
using MyMusic.Core.Models;

namespace MyMusic.Api.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Music, MusicResource>().ReverseMap();
            CreateMap<Music, SaveMusicResource>().ReverseMap();
            CreateMap<Artist, ArtistResource>().ReverseMap();
        }
    }
}