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
    public class ChatController : ControllerBase
    {
        [HttpGet]
        [ProducesResponseType(typeof(List<ChatGeneralEntity>), 200)]
        public IActionResult get()
        {
            List<ChatGeneralEntity> data = new List<ChatGeneralEntity>();
            string currentPath = Directory.GetCurrentDirectory();
            data = new List<ChatGeneralEntity>()
            {
                new ChatGeneralEntity()
                {
                    ContactName="Jorge Argueta",
                    LastUpdate = "9:12pm",
                    LastMessage = "Gusto en saludarte",
                    B64Photo = $"data:image/jpeg;base64,{Convert.ToBase64String(System.IO.File.ReadAllBytes($"{currentPath}/Content/img/pictures/1.jpg"))}",
                    LastMessageWasFromTheUser = true,
                    statusViewed = true
                },
                new ChatGeneralEntity()
                {
                    ContactName="Estefan Panameño",
                    LastUpdate = "7:34pm",
                    LastMessage = "Me parece la idea",
                    B64Photo = $"data:image/jpeg;base64,{Convert.ToBase64String(System.IO.File.ReadAllBytes($"{currentPath}/Content/img/pictures/2.jpg"))}",
                    LastMessageWasFromTheUser = false,
                    statusViewed = false
                },
                new ChatGeneralEntity()
                {
                    ContactName="Angela",
                    LastUpdate = "10:00am",
                    LastMessage = "Gusto en saludarte",
                    B64Photo = $"data:image/jpeg;base64,{Convert.ToBase64String(System.IO.File.ReadAllBytes($"{currentPath}/Content/img/pictures/3.jpg"))}",
                    LastMessageWasFromTheUser = true,
                    statusViewed = false
                },
                new ChatGeneralEntity()
                {
                    ContactName="Francisca Desarrollador",
                    LastUpdate = "01/10/2021",
                    LastMessage = "Gusto en saludarte",
                    B64Photo = $"data:image/jpeg;base64,{Convert.ToBase64String(System.IO.File.ReadAllBytes($"{currentPath}/Content/img/pictures/4.jpg"))}",
                    LastMessageWasFromTheUser = false,
                    statusViewed = false
                },
                new ChatGeneralEntity()
                {
                    ContactName="Alejandro Bonilla",
                    LastUpdate = "30/09/2021",
                    LastMessage = "Gusto en saludarte",
                    B64Photo = $"data:image/jpeg;base64,{Convert.ToBase64String(System.IO.File.ReadAllBytes($"{currentPath}/Content/img/pictures/5.jpg"))}",
                    LastMessageWasFromTheUser = true,
                    statusViewed = true
                },
            };
            return Ok(data);
        }
    }
}
