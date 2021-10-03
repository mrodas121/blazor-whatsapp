using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QueOndas_APP.Models
{
    public class ChatGeneralEntity
    {
        public string ContactName{get;set;}
        public string B64Photo { get; set; }
        public string LastUpdate { get; set; }
        public string LastMessage { get; set; }
        public bool LastMessageWasFromTheUser { get; set; }
        public bool statusViewed { get; set; }
    }
}
