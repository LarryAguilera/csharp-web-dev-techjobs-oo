using System;
namespace TechJobsOO
{
    public class CoreCompetency : Jobfield
    {

      

        public CoreCompetency(string value) : base(value)
        {
        }

        public override bool Equals(object obj)
        {
            return obj is CoreCompetency competency &&
                   id == competency.id;
        }

 
    }
    }
}
