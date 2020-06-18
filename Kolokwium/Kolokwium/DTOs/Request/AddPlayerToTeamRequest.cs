using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kolokwium.DTOs.Request
{
    public class AddPlayerToTeamRequest
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Brithdate { get; set; }
        public int NumOnShirt { get; set; }
        public string Comment { get; set; }
    }
}
