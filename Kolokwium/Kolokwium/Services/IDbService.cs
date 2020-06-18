using Kolokwium.DTOs.Request;
using Kolokwium.DTOs.Response;
using Kolokwium.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kolokwium.Services
{
    public interface IDbService
    {
        public Dictionary<int,float> GetTeamsWithScoresOnChampionship(int id);

        public void AddPlayerToTeam(AddPlayerToTeamRequest req , int teamId);
    }
}
