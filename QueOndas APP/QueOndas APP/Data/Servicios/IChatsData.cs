using QueOndas_APP.Models;
using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QueOndas_APP.Data.Servicios
{
    public interface IChatsData
    {
        [Get(path: "/api/Chat")]
        Task<List<ChatGeneralEntity>> Get();
    }
}
