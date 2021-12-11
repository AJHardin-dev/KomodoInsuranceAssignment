using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DeveloperPOCO;

namespace DeveloperRepo
{
    public class DeveloperRepo
    {
        private readonly List<Developer> _developers = new List<Developer>();

        public bool CreateDeveloper(Developer developer)
        {
            if (developer != null)
            {
                if (GetById(developer.Id) == null)
                {
                    _developers.Add(developer);
                    return true;
                }
            }
            return false;
        }

        public List<Developer> GetAll() 
        {
            return _developers;
        }

        public Developer GetById(int id) 
        {
            foreach (Developer developer in _developers)
            {
                if (id == developer.Id)
                {
                    return developer;
                }
            }
            return null;
        }

        public bool UpdateById(int id, Developer newData)
        {
            if (newData != null && GetById(id) != null)
            {
                foreach (Developer developer in _developers)
                {
                    if (id == developer.Id)
                    {
                        developer.Name = newData.Name;
                        developer.SoftwareAccess = newData.SoftwareAccess;
                        return true;
                    }
                }
            }
            return false;
        }
        public bool DeleteById(int id)
        {
            if (GetById(id) != null)
            {
                foreach (Developer developer in _developers)
                {
                    if (id == developer.Id)
                    {
                        _developers.Remove(GetById(id));
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
