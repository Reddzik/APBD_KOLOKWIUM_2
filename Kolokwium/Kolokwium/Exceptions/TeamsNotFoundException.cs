using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kolokwium.Exceptions
{
    public class TeamsNotFoundException : Exception
    {
        public TeamsNotFoundException(string msg) : base(msg)
        {

        }
    }
}
