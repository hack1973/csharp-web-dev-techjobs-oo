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
            Assert.AreEqual("ACME", job6.EmployerName.ToString());
            Assert.AreEqual("Desert", job6.EmployerLocation.ToString());
            Assert.AreEqual("Quality control", job6.JobType.ToString());
            Assert.AreEqual("Persistence", job6.JobCoreCompetency.ToString());
        }

        [TestMethod]
        public void TestJobsForEquality()
        {
            Job job1 = new Job("Prodct tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            Job job2 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            Assert.IsFalse(Equals(job2, job1));
        }
    }
}
