
using AutoMapper;
using FormularioResgistrosWeb.DTOs;
using FormularioResgistrosWeb.Entidades;
using FormularioResgistrosWeb.Servicios;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OutputCaching;

namespace FormularioResgistrosWeb.Controllers
{
    public class FormulariosController
    {
        [Route("api/formularios")]
        [ApiController]
        public class FormularioController : ControllerBase
        {
            private readonly IOutputCacheStore outputCacheStore;
            private readonly AplicationDbContext context;
            private readonly IMapper mapper;
            private readonly IAlmacenadorArchivos almacenadorArchivos;
            private const string cachetag = "formulario";

            public FormularioController(IOutputCacheStore outputCacheStore,AplicationDbContext context,IMapper mapper,
                IAlmacenadorArchivos almacenadorArchivos)
            {
                this.outputCacheStore = outputCacheStore;
                this.context = context;
                this.mapper = mapper;
                this.almacenadorArchivos = almacenadorArchivos;
            }
            

           
        }
    }
}
