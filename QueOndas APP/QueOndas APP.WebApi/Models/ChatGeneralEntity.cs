using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QueOndas_APP.WebApi.Models
{
    public class ChatGeneralEntity : ContactEntity
    {
        public string LastUpdate { get; set; }
        public string LastMessage { get; set; }
        public bool LastMessageWasFromTheUser { get; set; }
        public bool statusViewed { get; set; }
    }
}
