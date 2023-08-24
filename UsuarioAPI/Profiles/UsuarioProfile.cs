using AutoMapper;
using UsuarioAPI.Database.Dtos;
using UsuarioAPI.Models;

namespace UsuarioAPI.Profiles
{
    public class UsuarioProfile : Profile
    {
        public UsuarioProfile()
        {
            CreateMap<CreateUsuariosDto, Usuario>();
        }
    }
}
