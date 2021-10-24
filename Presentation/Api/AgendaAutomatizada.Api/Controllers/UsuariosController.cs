using AgendaAutomatizada.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgendaAutomatizada.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuariosController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public UsuariosController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [Route("Login")]
        [HttpPost]
        public IActionResult Login(string usuario,string clave)
        {
            try
            {
                return StatusCode(200, _unitOfWork.Usuarios.Login(usuario, clave));
            }
            catch (Exception e)
            {
                return StatusCode(500,e);
            }
            finally
            {
                _unitOfWork.Dispose();
            }
        }
    }
}
