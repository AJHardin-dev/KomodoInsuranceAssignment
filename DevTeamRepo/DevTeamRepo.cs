using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevTeamPOCO;
using DeveloperPOCO;

namespace DevTeamRepo
{
    public class DevTeamRepo
    {
        private readonly List<DevTeam> _devTeams = new List<DevTeam>();

        public bool CreateDevTeam(DevTeam devTeam)
        {
            if (devTeam != null)
            {
                if (GetById(devTeam.Id) == null)
                {
                    _devTeams.Add(devTeam);
                    return true;
                }
            }
            return false;
        }

        public List<DevTeam> GetAll() 
        {
            return _devTeams;
        }

        public DevTeam GetById(int id) 
        {
            foreach (DevTeam devTeam in _devTeams)
            {
                if (id == devTeam.Id)
                {
                    return devTeam;
                }
            }
            return null;
        }

        public bool UpdateById(int id, DevTeam newData)
        {
            if (newData != null && GetById(id) != null)
            {
                foreach (DevTeam devTeam in _devTeams)
                {
                    if (id == devTeam.Id)
                    {
                        devTeam.Name = newData.Name;
                        devTeam.MemberList = newData.MemberList;
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
                foreach (DevTeam devTeam in _devTeams)
                {
                    if (id == devTeam.Id)
                    {
                        _devTeams.Remove(GetById(id));
                        return true;
                    }
                }
            }
            return false;
        }
    
    }
}
