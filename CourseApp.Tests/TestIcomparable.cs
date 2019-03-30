using System;
using Xunit;
using Zadanie1;

namespace CourseApp.Tests
{
    public class TestIcomparable
    {
        [Fact]
        public void TestName()
        {
            string comparable = @" Walter-7.92 Colt-0.45 ";
            Pistol colt = new Pistol();
            Pistol walter = new Pistol("Walter", 7.92, 3.5f);
            Pistol[] arrayOfPistol = new Pistol[] { walter, colt };
           Assert.Equal(@" Walter-7.92 Colt-0.45 ", comparable);
        }
    }
}
