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

        public Job(string name, Employer employerName, Location employerLocation, PositionType jobType, CoreCompetency jobCoreCompetency) : this()
        {
            Name = name;
            EmployerName = employerName;
            EmployerLocation = employerLocation;
            JobType = jobType;
            JobCoreCompetency = jobCoreCompetency;
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
            if (Name.Trim() == "" && EmployerName.Value.Trim() == "" && EmployerLocation.Value.Trim() == "" && JobType.Value.Trim() == "" && JobCoreCompetency.Value.Trim() == "")
            {
                string jobReturned = "OOPS! This job does not seem to exist.";
                return jobReturned;
            }

            if (Name == null || Name.Trim() == "")
            {
              Name = "Data not available";
            }
            if (EmployerName.Value == null || EmployerName.Value.Trim() == "")
            {
               EmployerName.Value = "Data not available";
            }
            if (EmployerLocation.Value == null || EmployerLocation.Value.Trim() == "")
            {
                EmployerLocation.Value = "Data not available";
            }
            if (JobType.Value == null || JobType.Value.Trim() == "")
            {
                JobType.Value = "Data not available";
            }
            if (JobCoreCompetency.Value == null || JobCoreCompetency.Value.Trim() == "")
            {
               JobCoreCompetency.Value = "Data not available";
            }
          
            string jobsReturned = $"\nId: {Id}\nName: {Name}\nEmployer: {EmployerName.Value}\nLocation: {EmployerLocation.Value}\nPosition Type: {JobType.Value}\nCore Competency: {JobCoreCompetency.Value}\n";
            return jobsReturned;
           

        }

    }
}
