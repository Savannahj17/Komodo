using DeveloperClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class DevTeam
    {
        public string TeamName { get; set; }
        public int TeamId { get; set; }
        public List<Developer> TeamMembers { get; set; }

        public DevTeam()
        {

        }
        public DevTeam(string teamName, int teamId, List<Developer> teamMembers)
        {
            TeamName = teamName;
            TeamId = teamId;
            TeamMembers = teamMembers;
        }
       
    }
}

//Team members
//Team id
//Team name
//see a list of existing developers to choose from (directory)
//one of our managers are nitpicky and would like the functionality to add multiple Developers to a team at once, rather than one by one. Integrate this into your application.

