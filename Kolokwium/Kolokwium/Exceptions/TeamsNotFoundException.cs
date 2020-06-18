using System;

namespace Kolokwium.Exceptions
{
    public class TeamsNotFoundException : Exception
    {
        public TeamsNotFoundException(string msg) : base(msg)
        {

        }
    }
}
