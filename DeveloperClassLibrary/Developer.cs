using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeveloperClassLibrary
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
