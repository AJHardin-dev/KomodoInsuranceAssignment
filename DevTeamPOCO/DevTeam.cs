using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DeveloperPOCO;

namespace DevTeamPOCO
{
    public class DevTeam
    {
        public int Id { get; }
        public string Name { get; set; }
        public List<Developer> MemberList { get; set; }

        public DevTeam(int id, string name)
        {
            Id = id;
            Name = name;
        }
        public DevTeam(int id, string name, List<Developer> memberList)
        {
            Id = id;
            Name = name;
            MemberList = memberList;
        }
    }
}
