using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechJobsOO;

namespace TechJobsTests
{
    [TestClass]
    public class JobTests
    {
        [TestMethod]
        public void EmptyTest()
        {
            Assert.AreEqual(10, 10, .001);
        }

        [TestMethod]
        public void TestSettingJobId()
        {
            Job job4 = new Job();
            Job job5 = new Job();
            Assert.AreNotEqual(job4.Id, job5.Id);
            Assert.IsTrue(job5.Id == job4.Id + 1);
        }

        [TestMethod]
        public void TestJobConstructorSetsAllFields()
        {
            //Declare and initialize a new Job object with the following data: "Product tester" for Name, "ACME" for EmployerName,
            //"Desert" for JobLocation, "Quality control" for JobType, and "Persistence" for JobCoreCompetency
            Job job6 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            Assert.AreEqual("Product tester", job6.Name);
            Assert.AreEqual("ACME", job6.EmployerName.Value);
            Assert.AreEqual("Desert", job6.EmployerLocation.Value);
            Assert.AreEqual("Quality control", job6.JobType.Value);
            Assert.AreEqual("Persistence", job6.JobCoreCompetency.Value);
        }

        [TestMethod]
        public void TestJobsForEquality()
        {
            Job job7 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            Job job8 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            Assert.IsFalse(Equals(job8, job7));
        }

        [TestMethod]
        public void TestJobToStringForBlankLines()
        {
            Job job9 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            
            // \n at beginning of string            
            Assert.AreEqual(job9.ToString()[0], '\n');
            // \n at end of string            
            Assert.AreEqual(job9.ToString()[job9.ToString().Length - 1], '\n');
        }

        [TestMethod]
        public void TestJobContainsLabelDataOnOwnLine()
        {
            Job.ResetNextId();
            Job job10 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            
            Assert.IsTrue(job10.ToString().Contains("ID: 1\n"));
            Assert.IsTrue(job10.ToString().Contains("Name: Product tester\n"));
            Assert.IsTrue(job10.ToString().Contains("Employer: ACME\n"));
            Assert.IsTrue(job10.ToString().Contains("Location: Desert\n"));
            Assert.IsTrue(job10.ToString().Contains("Position Type: Quality control\n"));
            Assert.IsTrue(job10.ToString().Contains("Core Competency: Persistence\n"));
        }

        [TestMethod]
        public void TestIfFieldIsEmpty()
        {
            Job job11 = new Job("Product tester", new Employer(""), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));

            //If a field is empty, the method should add, “Data not available” after the label.
            Assert.IsTrue(job11.ToString().Contains("Employer: Data not available"));
        }

        [TestMethod]
        public void TestIfOnlyDataIsInIdField()
        {
            Job job12 = new Job("", new Employer(""), new Location(""), new PositionType(""), new CoreCompetency(""));

            //If a field is empty, the method should add, “Data not available” after the label.
            Assert.IsTrue(job12.ToString().Contains("OOPS! This job does not seem to exist."));
        }
    }
}
