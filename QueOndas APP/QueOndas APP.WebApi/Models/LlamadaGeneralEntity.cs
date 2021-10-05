using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QueOndas_APP.WebApi.Models
{
    public class LlamadaGeneralEntity : ContactEntity
    {
        public bool WasPhoneCall { get; set; }
        public bool CallStatus { get; set; }
        public string CallDate { get; set; }
    }
}
