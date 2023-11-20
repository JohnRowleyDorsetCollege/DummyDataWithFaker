using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DummyDataWithFaker.Models
{
    public class UserProfile
    {
        public string Name { get; set; }
        public string GovernmentId { get; set; }
        public int Followers { get; set; }
        public string Area { get; set; }
        public string Bio { get; set; }

        public override string ToString()
        {
            return $"{Name} [{GovernmentId}] has {Followers} followers at {Area}. {Bio}";
        }


    }
}
