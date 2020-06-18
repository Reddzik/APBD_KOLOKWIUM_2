using Kolokwium.DTOs.Request;
using Kolokwium.Exceptions;
using Kolokwium.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace Kolokwium.Services
{
    public class SqlServerChampionshipDbService : IDbService
    {
        private readonly ChampionshipDbContext _context;
        public SqlServerChampionshipDbService(ChampionshipDbContext context)
        {
            _context = context;
        }

        public Dictionary<int,float> GetTeamsWithScoresOnChampionship(int id)
        {
            var teams = _context.ChampionshipTeams
                                .Where(ct => ct.IdTeam == id).ToList();



            if (teams == null)
            {
                throw new TeamsNotFoundException($"There is no Team with id: {id} in database");
            }

            var dictRes = new Dictionary<int, float>();
            
            foreach(var team in teams)
            {
                dictRes.Add(team.IdTeam, team.Score);
            }

            return dictRes;

        }

        public void AddPlayerToTeam(AddPlayerToTeamRequest req ,int teamId)
        {
            var player = _context.Players.FirstOrDefault(p => p.FirstName == req.FirstName && p.LastName == req.LastName);
            if (player == null)
            {
                throw new PlayerNotFoundException($"There is no player {req.FirstName} {req.LastName}");
            }
            var team = _context.Teams.FirstOrDefault(t => t.IdTeam == teamId);
            if(team == null)
            {
                throw new TeamsNotFoundException($"There is no team with id: {teamId}");
            }

            if (team.MaxAge < (DateTime.Today.Year - player.DateOfBirth.Year))
            {
                throw new TooOldPlayerForThisTeamException($"Player id:{player.IdPlayer} is too old for team id {teamId}");
            }

            var newPlayerToTeam = new PlayerTeam
            {
                IdPlayer = player.IdPlayer,
                IdTeam = team.IdTeam,
                NumOnShirt = req.NumOnShirt,
                Comment = req.Comment,
            }
            _context.PlayerTeams.Add(newPlayerToTeam);
            _context.SaveChanges();


        }


    }
}
