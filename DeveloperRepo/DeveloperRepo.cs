using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeveloperRepo
{
    public class DeveloperRepo
    {
        private List<Developer> _developers = new List<Developer>();

        public bool AddDeveloper(Developer developer)
        {
            int count = _developers.Count();
            _developers.Add(developer);
            if (_developers.Count == (count + 1))
            {
                return true;
            }
            return false;
        }
        public List<Developer> GetAllContent()
        {
            return _developers;
        }

        public void DeleteDevFromDirectory(string name)
        {
            Developer developerToDelete = GetDeveloperByName(name);
            if (developerToDelete != null)
            {
                _developers.Remove(developerToDelete);
            }
        }
        public bool UpdateDeveloper(string originalDeveloper, Developer newDeveloper)
        {
            Developer oldDeveloper = GetDeveloperByName(originalDeveloper);
            if (oldDeveloper != null)
            {
                oldDeveloper.Name = newDeveloper.Name;
                oldDeveloper.Id = newDeveloper.Id;
                oldDeveloper.PluralSightAccess = newDeveloper.PluralSightAccess;
                return true;
            }
            else
            {
                return false;
            }
        }

        public Developer GetDeveloperByName(string name)
        {
            foreach (Developer developer in _developers)
            {
                if (developer.Name == name)
                {
                    return developer;
                }
            }
            return null;
        }

    }
}

//CRUD - find first, then CRUD
//Add already created items to list or specific teams
//field = not a property or method
