using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kolokwium.Exceptions
{
    public class TooOldPlayerForThisTeamException :Exception
    {
        public TooOldPlayerForThisTeamException(string msg) : base(msg)
        {

        }
    }
}
