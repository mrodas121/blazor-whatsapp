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
    public class LlamadasController : ControllerBase
    {
        [HttpGet]
        [ProducesResponseType(typeof(List<LlamadaGeneralEntity>), 200)]
        public IActionResult get()
        {
            List<LlamadaGeneralEntity> data = new List<LlamadaGeneralEntity>();
            string currentPath = Directory.GetCurrentDirectory();
            data = new List<LlamadaGeneralEntity>()
            {
                new LlamadaGeneralEntity()
                {
                    ContactName="Alejandro Bonilla",
                    CallDate = "29 de Septiembre 2021",
                    B64Photo =  $"data:image/jpeg;base64,{Convert.ToBase64String(System.IO.File.ReadAllBytes($"{currentPath}/Content/img/pictures/5.jpg"))}",
                    WasPhoneCall = true,
                    CallStatus = false
                },
                new LlamadaGeneralEntity()
                {
                    ContactName="Francisca Desarrollador",
                    CallDate = "28 de Septiembre 2021",
                    B64Photo =  $"data:image/jpeg;base64,{Convert.ToBase64String(System.IO.File.ReadAllBytes($"{currentPath}/Content/img/pictures/4.jpg"))}",
                    WasPhoneCall = false,
                    CallStatus = true
                },
                new LlamadaGeneralEntity()
                {
                    ContactName="Alejandro Bonilla",
                    CallDate = "27 de Septiembre 2021",
                    B64Photo =  $"data:image/jpeg;base64,{Convert.ToBase64String(System.IO.File.ReadAllBytes($"{currentPath}/Content/img/pictures/5.jpg"))}",
                    WasPhoneCall = true,
                    CallStatus = true
                },
            };
            return Ok(data);
        }
    }
}
