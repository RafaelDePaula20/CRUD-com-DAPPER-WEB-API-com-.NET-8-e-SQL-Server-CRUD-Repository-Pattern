using AutoMapper;
using CrudDapper.Dtos;
using CrudDapper.Models;


namespace CrudDapper.Profiles
{
    public class ProfileAutoMapper : Profile
    {
       public ProfileAutoMapper() 
        {
            CreateMap<Usuario, UsuarioListarDto>();

        }

    }
}
