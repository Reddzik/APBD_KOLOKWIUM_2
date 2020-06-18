using System;

namespace Kolokwium.Exceptions
{
    public class TooOldPlayerForThisTeamException :Exception
    {
        public TooOldPlayerForThisTeamException(string msg) : base(msg)
        {

        }
    }
}
