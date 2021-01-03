using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TechJobsTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Empty()
        {
            Assert.AreEqual(10, 10, .001);
        }

        [TestMethod]
        public void TestSettingJobId()
        {
            Job job1 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            Job job2 = new Job("Web Developer", new Employer("LaunchCode"), new Location("St. Louis"), new PositionType("Front-end developer"), new CoreCompetency("JavaScript"));

            bool equals = job1.Equals(job2);

            Assert.AreEqual(false, equals, .001);
            Assert.IsTrue(job2 == job1 + 1);
        }


        [TestMethod]
        public void TestJobConstructorSetsAllFields()
        {
            Job job1 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));

            Assert.AreEqual("Product tester", job1.Name, .001);

            Assert.AreEqual("ACME", job1.EmployerName, .001);

            Assert.AreEqual("Desert", job1.EmployerLocation, .001);

            Assert.AreEqual("Quality control", job1.JobType, .001);

            Assert.AreEqual("Persistence", job1.JobCoreCompetency, .001);

        }


        [TestMethod]
        public void TestJobsForEquality()
        {
            Job job1 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            Job job2 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            bool equals = job1.Equals(job2);

            Assert.AreEqual(false, equals, .001);

        }


        [TestMethod]
        public void TestJobToString()
        {
            Job job1 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));

            string desc = job1.ToString();
            string expected = "\n\n";

            if (job1.Id != "")
            {
                expected += "ID: " + job1.Id + "\n";
            }
            else
            {
                expected += "ID: Data not available \n";
            }

            if (job1.Name != "")
            {
                expected += "Name: " + job1.Name + "\n";
            }
            else
            {
                expected += "Name: Data not available \n";
            }

            if (job1.EmployerName != "")
            {
                expected += "Employer: " + job1.EmployerName + "\n";
            }
            else
            {
                expected += "Employer: Data not available \n";
            }

            if (job1.EmployerLocation != "")
            {
                expected += "Location: " + job1.EmployerLocation + "\n";
            }
            else
            {
                expected += "Location: Data not available \n";
            }

            if (job1.JobType != "")
            {
                expected += "Position Type: " + job1.JobType + "\n";
            }
            else
            {
                expected += "Position Type: Data not available \n";
            }

            if (job1.JobCoreCompetency != "")
            {
                expected += "Core Competency: " + job1.JobCoreCompetency + "\n";
            }
            else
            {
                expected += "Core Competency: Data not available \n";
            }
            // all values

            expected += "\n\n"

            Assert.AreEqual(expected, desc, .001);

        }
    }
