using NUnit.Framework;

using UnitTestAndDebug;

namespace Tests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void TestName()
        {
            Person agustin = new Person("Agustin Lorenzo", "5.192.990-4");
            string expected = "Agustin Lorenzo";
            Assert.AreEqual(expected, agustin.Name);
        }

        [Test]
        public void TestID()
        {
            Person agustin = new Person("Agustin Lorenzo", "5.192.990-4");
            string expected = "5.192.990-4";
            Assert.AreEqual(expected, agustin.ID);
            
        
    }   
    }
}
