using System;
using Xunit;
using CourseApp;

namespace CourseApp.Tests
{
    public class TestofIComparable
    {
        [Fact]
        public void Testcomparable()
        {
            string icomparable = @"Admiral - 200 - 100
Duty - 75 - 300
Lucky - 90 - 100";
            Ship admiral = new Ship();
            Ship lucky = new Ship(90);
            Ship duty = new Ship("Duty", 75, 300);
            Ship[] araryOfShip = new Ship[] { admiral, lucky, duty };
            Assert.Equal(
                @"Admiral - 200 - 100
Duty - 75 - 300
Lucky - 90 - 100", icomparable);
        }
    }
}