using DeveloperClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class DevTeamRepo
    {
        private DeveloperRepo devRepo = new DeveloperRepo();
        private List<DevTeam> _devTeamDirectory = new List<DevTeam>();
        public bool AddDevToTeam(Developer developer, DevTeam devTeam)
        {
            int count = devTeam.TeamMembers.Count();
            devTeam.TeamMembers.Add(developer);
            if(devTeam.TeamMembers.Count() == (count + 1))
            {
                return true;
            }
            return false;
        }

        public bool DeleteDevFromTeam(string teamName, string devName)
        {
            DevTeam devTeam = GetTeamByName(teamName);
            Developer developer =devRepo.GetDeveloperByName(devName);
            int devTeamCount = devTeam.TeamMembers.Count();
            devTeam.TeamMembers.Remove(developer);
            if(devTeam.TeamMembers.Count() == devTeamCount - 1)
            {
                return true;
            }
            return false;
            
        }
        public DevTeam GetTeamByName(string teamName)
        {
            foreach(DevTeam team in _devTeamDirectory)
            {
                if(team.TeamName.ToLower() == teamName.ToLower())
                {
                    return team;
                }
                
            }
            return null;
        }

        public List<DevTeam> GetAllContent()
        {
            return _devTeamDirectory;
        }

        public bool UpdateDevTeam(string originalTeam, DevTeam newTeam)
        {
            DevTeam oldTeam = GetTeamByName(originalTeam); ;
            if(oldTeam != null)
            {
                oldTeam.TeamId = newTeam.TeamId;
                oldTeam.TeamMembers = newTeam.TeamMembers;
                oldTeam.TeamName = newTeam.TeamName;
                return true;
            }
            else
            {
                return false;
            }


        }

    }
}
//CRUD- not by name or id. CRUD is for objects. not properties
//Managers need to be able to add and remove members to/from a team by their unique identifier
//add to existing teams (just method)
//add multiple Developers to a team at once, rather than one by one ; pass collection to method 
//Object are just containers!
//get team first and them remove dev
