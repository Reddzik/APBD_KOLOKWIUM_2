using System;

namespace Kolokwium.Exceptions
{
    public class PlayerNotFoundException :Exception
    {
        public PlayerNotFoundException(string msg) : base(msg)
        {

        }
    }
}
