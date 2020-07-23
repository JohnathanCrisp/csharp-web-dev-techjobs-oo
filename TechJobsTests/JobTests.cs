using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TechJobsOO;

namespace TestJobsTest
{
    [TestClass]
    public class JobTests
    {


        [TestMethod]
        public void TestSettingJobId()
        {
            int expected;
            int actual;
            Job job1 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            Job job2 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            actual = job1.Id;
            expected = job2.Id;



            Assert.IsFalse(expected.Equals(actual));
        }
       
        [TestMethod]
        public void TestJobConstructorSetsAllFields()
        {
            Job job1 = new Job("Product Tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));

            Assert.AreEqual("Product Tester", job1.Name);
            Assert.AreEqual("ACME", job1.EmployerName.ToString());
            Assert.AreEqual("Desert", job1.EmployerLocation.ToString());
            Assert.AreEqual("Quality control", job1.JobType.ToString());
            Assert.AreEqual("Persistence", job1.JobCoreCompetency.ToString());
        }

        [TestMethod]
        public void JobTest()
        {
            Job job1 = new Job("Product Tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            Job job2 = new Job("Product Tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));

            Assert.AreEqual(job1.Equals(job2), false);
        }
     
      
        [TestMethod]
        public void FirstLine()
        {
            Job job1 = new Job("Product Tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));

            Assert.IsTrue(job1.ToString().StartsWith("\n"));
            Assert.IsTrue(job1.ToString().EndsWith("\n"));

            Assert.IsTrue(job1.ToString().Contains("ID: 1"));
            Assert.IsTrue(job1.ToString().Contains("Name: Product Tester"));
            Assert.IsTrue(job1.ToString().Contains("Employer: ACME"));
            Assert.IsTrue(job1.ToString().Contains("Location: Desert"));
            Assert.IsTrue(job1.ToString().Contains("Position Type: Quality control"));
            Assert.IsTrue(job1.ToString().Contains("Core Competency: Persistence"));
        }


    }
}
