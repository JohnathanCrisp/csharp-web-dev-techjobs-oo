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

        public string Value { get; set; }

        // TODO: Add the two necessary constructors.
        public Job()
        {
            Id = nextId;
            nextId++;
        }

        public Job(string name, Employer employer, Location location, PositionType posType, CoreCompetency coreCompetency) : this()
        {
            this.Name = name;
            this.EmployerName = employer;
            this.EmployerLocation = location;
            this.JobType = posType;
            this.JobCoreCompetency = coreCompetency;



        }

        // TODO: Generate Equals() and GetHashCode() methods.
        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }

        public override string ToString()
        {
            Value = "\nID: " + this.Id + "\nName: " + this.Name + "\nEmployer: " + this.EmployerName + "\nLocation: " + this.EmployerLocation + "\nPosition Type: " + this.JobType + "\nCore Competency: " + this.JobCoreCompetency + "\n";

            return Value;
        }

        public override bool Equals(object obj)
        {
            return obj is Employer employer &&
                   Id == employer.Id;
        }



    }
}
