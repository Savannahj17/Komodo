using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeveloperRepo
{
    public class Developer
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public bool PluralSightAccess { get; set; }

        public Developer()
        {

        }
        public Developer(string name, int id, bool pluralSightAccess)
        {
            Name = name;
            Id = id;
            PluralSightAccess = pluralSightAccess;

        } 
    }
}
//Assign names
//Assign ID numbers
//Need to know whether or not they have access to learning tool Pluralsight (bool)
//get list of all our Developers that need a Pluralsight license
//Create Developer - ctor
//Our HR Department uses the software monthly to get a list of all our Developers that need a Pluralsight license. Create this functionality in the Console Application