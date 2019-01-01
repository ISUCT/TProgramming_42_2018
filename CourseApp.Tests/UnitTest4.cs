using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace CourseApp.Tests
{
    public class UnitTest4
    {
        [Fact]
        public void Test13()
        {
            Animals[] animal = new Animals[2];
            animal[0] = new Fox();
            animal[1] = new Wolf();
            foreach (Animals i in animal)
            {
                Assert.Equal("Неизвестное", i.Name);
                Assert.Equal(2, i.Age);
                Assert.Equal("Прозрачный", i.Color);

            }
        }
        [Fact]
        public void Test14()
        {
            Animals[] animal = new Animals[2];
            animal[0] = new Fox();
            animal[1] = new Wolf();
            Assert.Equal("Неизвестное", animal[0].Name);
            Assert.Equal(2, animal[0].Age);
            Assert.Equal("Прозрачный", animal[0].Color);
            Assert.Equal("Неизвестное", animal[1].Name);
            Assert.Equal(2, animal[1].Age);
            Assert.Equal("Прозрачный", animal[1].Color);
        }
        [Fact]
        public void Test15()
        {
            Animals[] animal = new Animals[2];
            animal[0] = new Fox();
            animal[1] = new Wolf();
            Assert.Equal("Из-за странного корма все лисы мутировали, покорили мир и сделали людей своими рабами", animal[0].Mut());
            Assert.Equal("Волки покорились мутировавшим лисицам", animal[1].Mut());
        }
        [Fact]
        public void Test16()
        {
            Animals[] animal = new Animals[2];
            animal[0] = new Fox();
            animal[1] = new Wolf();
            Assert.Equal("Волк Неизвестное пошёл всех кусать, но его укусила лисица", animal[1].ToString());
        }
    }
}