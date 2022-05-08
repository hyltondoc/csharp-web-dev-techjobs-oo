using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechJobsOO;

namespace TechJobsTest
{
    [TestClass]
    public class JobTests
    {
        //[TestMethod]
        //public void TestMethod1()
        //{
        //}

        [TestMethod]
        public void TestSettingJobId()
        {
            Job newjob1 = new Job();
            Job newjob2 = new Job();

            int newjob1Id = newjob1.Id;
            int newjob2Id = newjob2.Id - 1;

            Assert.AreEqual(newjob1Id, newjob2Id);
        }

        [TestMethod]
        public void TestJobConstructorSetsAllFields()
        {
            Employer employer = new Employer("ACME");
            Location location = new Location("Desert");
            PositionType positionType = new PositionType("Quality Control");
            CoreCompetency coreCompetency = new CoreCompetency("Persistance");

            Job job = new Job("Product tester", employer, location, positionType, coreCompetency);

            string employerName = job.EmployerName.Value;
            string employerLocation = job.EmployerLocation.Value;
            string type = job.JobType.Value;
            string competency = job.JobCoreCompetency.Value;

            Assert.IsTrue(Job.Equals(job.Name, "Product tester"));
            Assert.IsTrue(Job.Equals(employerName, "ACME"));
            Assert.IsTrue(Job.Equals(employerLocation, "Desert"));
            Assert.IsTrue(Job.Equals(type, "Quality Control"));
            Assert.IsTrue(Job.Equals(competency, "Persistance"));

        }

        [TestMethod]
        public void TestJobsForEquality()
        {
            Employer employer = new Employer("ACME");
            Location location = new Location("Desert");
            PositionType positionType = new PositionType("Quality Control");
            CoreCompetency coreCompetency = new CoreCompetency("Persistance");

            Job jobOne = new Job("Product tester", employer, location, positionType, coreCompetency);
            Job jobTwo = new Job("Product tester", employer, location, positionType, coreCompetency);

            Assert.IsFalse(jobOne.Equals(jobTwo));
        }
        [TestMethod]
        public void TestForToString()
        {
       
            Job jobs = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality Control"), new CoreCompetency("Persistance"));

            string jobTest = jobs.ToString();
            string jobTrim = jobs.ToString().Trim();
            int index = jobTest.IndexOf('\n');
          

            //string[] jobTestSplit = jobTest.Split('\n');
            string[] jobTrimSplit = jobTrim.Split('\n');

          //tests if there are spaces inbetween and at the end (7 total new lines, first one removed, 6 newlines)
            Assert.AreEqual(6, jobTrimSplit.Length);

            //tests if there is a new line at the beginning of the line. Either works.
            Assert.AreEqual(0, index);
            //Assert.IsFalse(jobTrim.IndexOf("\n").Equals(0));

            //Assert.IsFalse(jobTest.Equals(jobTrim));
            //Assert.IsTrue(jobTest.Contains('\n'));

        }
    }
}
