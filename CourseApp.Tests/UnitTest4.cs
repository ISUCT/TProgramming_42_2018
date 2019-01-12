using System;
using Xunit;

using ConsoleApp1;

namespace CourseApp.Tests
{
    public class UnitTest4
    {
        [Fact]
        public void Test14()
        {
            Land[] land = new Land[2];
            land[0] = new Island();
            land[1] = new Country();
            foreach (Land i in land)
            {
                Assert.Equal("����������� �����", i.Name);
                Assert.Equal(24140800, i.People);
                Assert.Equal(7692024, i.Square);
            }
        }

        [Fact]
        public void Test15()
        {
            Land[] land = new Land[2];
            land[0] = new Island();
            land[1] = new Country();
            Assert.Equal("����������� �����", land[0].Name);
            Assert.Equal(24140800, land[0].People);
            Assert.Equal(7692024, land[0].Square);
            Assert.Equal("����������� �����", land[1].Name);
            Assert.Equal(24140800, land[1].People);
            Assert.Equal(7692024, land[1].Square);
        }

        [Fact]
        public void Test16()
        {
            Land[] land = new Land[2];
            land[0] = new Island();
            land[1] = new Country();
            Assert.Equal("������ ����������� ����� ������ \'Dhou!\', ������� � ������", land[0].Voice());
            Assert.Equal("������ ����������� ����� ������� \'Dhou!\', ���������� � ����", land[1].Voice());
        }

        [Fact]
        public void Test17()
        {
            Land[] land = new Land[2];
            land[0] = new Island();
            land[1] = new Country();
            Assert.Equal("������ ����������� ����� ��������� � �������", land[1].ToString());
        }
    }
}
