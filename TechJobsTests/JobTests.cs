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
            Assert.AreNotEqual(job4.Id,job5.Id);
            Assert.IsTrue(job5.Id == job4.Id + 1);
        }
    }
}
