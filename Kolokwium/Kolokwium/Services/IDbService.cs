using Kolokwium.DTOs.Request;
using System.Collections.Generic;

namespace Kolokwium.Services
{
    public interface IDbService
    {
        public Dictionary<int,float> GetTeamsWithScoresOnChampionship(int id);

        public void AddPlayerToTeam(AddPlayerToTeamRequest req , int teamId);
    }
}
