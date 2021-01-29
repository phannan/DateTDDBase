using MyDates;
using Microsoft.VisualStudio.TestTools.UnitTesting;

// Assert docs are here
// https://docs.microsoft.com/en-us/dotnet/api/microsoft.visualstudio.testtools.unittesting.assert?f1url=https%3A%2F%2Fmsdn.microsoft.com%2Fquery%2Fdev16.query%3FappId%3DDev16IDEF1%26l%3DEN-US%26k%3Dk(Microsoft.VisualStudio.TestTools.UnitTesting.Assert);k(TargetFrameworkMoniker-.NETFramework,Version%3Dv4.5.2);k(DevLang-csharp)%26rd%3Dtrue&view=mstest-net-1.2.0
namespace DatesTest
{
    [TestClass]
    public class DateTest
    {
        // This test is just to be sure I've got the 
        //  tests and the class properly linked.
        [TestMethod]
        public void testLinked()
        {
            MyDate d = new MyDate();
            // first I always make it fail.  1970 is the beginning of time in unix land.
            // Assert.AreEqual(d.Year(), 1970);
            Assert.AreEqual(d.Year(), 9999);
        }
    }
}
