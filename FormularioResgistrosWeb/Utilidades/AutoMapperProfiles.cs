
using AutoMapper;
using FormularioResgistrosWeb.DTOs;
using FormularioResgistrosWeb.Entidades;

namespace FormularioResgistrosWeb.Utilidades
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            ConfigurarMapeoCategorias();
            ConfigurarMapeoFormularios();



        }
        private void ConfigurarMapeoCategorias()
        {
            CreateMap<CrearCategoriaDTO, Categoria>();
            CreateMap<Categoria, CategoriaDTO>();
        }

        private void ConfigurarMapeoFormularios()
        {
            CreateMap<CrearFormularioDTO, Formulario>().
                ForMember(entidad => entidad.Telefonos, dto =>
                dto.MapFrom(dto => dto.Telefonos))
                .ForMember(entidad => entidad.Dirrecciones,
                dto => dto.MapFrom(dto => dto.Dirrecciones))
                .ForMember(entidad => entidad.CategoriaFormularios,
                dto => dto.MapFrom(dto => dto.CategoriasIds!.Select(id => new CategoriaFormulario { CategoriaId = id })));
            CreateMap<CrearTelefonoDTO, Telefono>();
            CreateMap<CrearDirreccionDTO, Dirreccion>();
            CreateMap<CrearFormularioDTO, FormularioDTO>();

            CreateMap<Formulario, FormularioDTO>()
                .ForMember(entidad => entidad.Telefonos,
                dto => dto.MapFrom(dto => dto.Telefonos))
                .ForMember(entidad => entidad.Dirrecciones,
                dto => dto.MapFrom(dto => dto.Dirrecciones))
                .ForMember(entidad => entidad.Categorias,
                dto => dto.MapFrom(dto => dto.CategoriaFormularios));
            CreateMap<CategoriaFormulario, CategoriaDTO>()
                .ForMember(c => c.Id, cf => cf.MapFrom(cf => cf.CategoriaId))
                .ForMember(c => c.Tipo, cf => cf.MapFrom(cf => cf.Categoria.Tipo));
            CreateMap<TelefonoDTO, Telefono>();
            CreateMap<DirreccionDTO, Dirreccion>();
        }
    }
}
