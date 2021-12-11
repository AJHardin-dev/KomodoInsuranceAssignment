using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeveloperPOCO
{
    public class Developer
    {
        public int Id { get; }
        public string Name { get; set; }
        public SoftwareList SoftwareAccess { get; set;}

        public Developer(int id, string name)
        {
            Id = id;
            Name = name;
            SoftwareAccess = SoftwareList.None;
        }
        public Developer(int id, string name, SoftwareList softwareAccess)
        {
            Id = id;
            Name = name;
            SoftwareAccess = softwareAccess;
        }
    }
}
