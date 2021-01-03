using System;
namespace TechJobsOO
{
    public class Job
    {
        public int Id { get; }
        private static int nextId = 1;

        public string Name { get; set; }
        public Employer EmployerName { get; set; }
        public Location EmployerLocation { get; set; }
        public PositionType JobType { get; set; }
        public CoreCompetency JobCoreCompetency { get; set; }

        // TODO: Add the two necessary constructors.
        public Job()
        {
            Id = nextId;
            nextId++;
        }

        public Job(string name, Employer employer, Location location, PositionType positionType, CoreCompetency coreCompetency) : this()
        {
            Name = name;
            EmployerName = employer;
            EmployerLocation = location;
            JobType = positionType;
            JobCoreCompetency = coreCompetency;
        }

        // TODO: Generate Equals() and GetHashCode() methods.
        public override bool Equals(object obj)
        {
            return obj is Job job &&
                   Id == job.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }

        public override string ToString()
        {
            string desc = "\n\n";

            
            if(Id != "") { 
                desc += "ID: "+ Id +"\n";}
            else {
                desc += "ID: Data not available \n";
            }

            
            if(Name != "") { 
                desc += "ID: "+ Name +"\n";}
            else {
                desc += "ID: Data not available \n";
            }

            if(EmployerName != "") { 
                desc += "Employer: "+ job1.EmployerName +"\n";}
            else {
                desc += "Employer: Data not available \n";
            }

            if(EmployerLocation != "") { 
                desc += "Location: "+ job1.EmployerLocation +"\n";}
            else {
                desc += "Location: Data not available \n";
            }

            if(JobType != "") { 
                desc += "Position Type: "+ job1.JobType +"\n";}
            else {
                desc += "Position Type: Data not available \n";
            }

            if(JobCoreCompetency != "") { 
                desc += "Core Competency: "+ job1.JobCoreCompetency +"\n";}
            else {
                desc += "Core Competency: Data not available \n";
            }

            desc+= "\n\n";

            return desc;
        }
    }
}
