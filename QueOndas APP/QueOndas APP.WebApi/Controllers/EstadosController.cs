using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QueOndas_APP.WebApi.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace QueOndas_APP.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EstadosController : ControllerBase
    {
        [HttpGet]
        [ProducesResponseType(typeof(List<EstadoGeneralEntity>), 200)]
        public IActionResult get()
        {
            List<EstadoGeneralEntity> data = new List<EstadoGeneralEntity>();
            string currentPath = Directory.GetCurrentDirectory();
            data = new List<EstadoGeneralEntity>()
            {
                new EstadoGeneralEntity()
                {
                    ContactName="Alejandro Bonilla",
                    StatusDate = "Hoy 9:18am",
                    B64Photo = $"data:image/jpeg;base64,{Convert.ToBase64String(System.IO.File.ReadAllBytes($"{currentPath}/Content/img/pictures/5.jpg"))}",
                },
                new EstadoGeneralEntity()
                {
                    ContactName="Estefan Panameño",
                    StatusDate = "Hoy 6:21am",
                    B64Photo = $"data:image/jpeg;base64,{Convert.ToBase64String(System.IO.File.ReadAllBytes($"{currentPath}/Content/img/pictures/2.jpg"))}",
                },
            };
            return Ok(data);
        }
    }
}
