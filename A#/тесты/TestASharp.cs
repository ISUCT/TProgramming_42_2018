using System;
using Xunit;
using System.Collections.Generic;
using ConsoleApp5;

namespace тесты
{
    public class TestASharp
    {
           Arefmetika prov = new Arefmetika();
            Uslovie uslov = new Uslovie();
            Dictionary<string, string> variables = new Dictionary<string, string>();
            
//тесты на математику        
        [Fact]
        public void TestSum()
        {
            variables.Add("C","8");
            Assert.Equal("10", prov.Sum("7","3",variables));            

        }

         [Fact]
        public void TestSub()
        {
            variables.Add("C","8");
            Assert.Equal("4", prov.Sub("7","3",variables));            

        }

         [Fact]
        public void TestDiv()
        {
            variables.Add("C","8");
            Assert.Equal("2", prov.Div("6","3",variables));            

        }

         [Fact]
        public void TestMul()
        {
            variables.Add("C","8");
            Assert.Equal("21", prov.Mul("7","3",variables));            

        }

        [Fact]
        public void TestRes()
        {
            variables.Add("C","8");
            Assert.Equal("1", prov.res("7","3",variables));            

        }
// тесты на условия
          [Fact]
        public void TestMore()
        {
            variables.Add("C","8");
            Assert.Equal("true", uslov.More("7","3",variables));            

        }
        
        [Fact]
         public void TestLess()
        {
            variables.Add("C","8");
            Assert.Equal("fals", uslov.Less("7","3",variables));            

        }

          [Fact]
         public void TestEqually()
        {
            variables.Add("C","8");
            Assert.Equal("fals", uslov.Equally("7","3",variables));            

        }

          [Fact]
         public void TestNotEqually()
        {
            variables.Add("C","8");
            Assert.Equal("true", uslov.NotEqual("7","3",variables));            

        }

          [Fact]
         public void TestMoreOrEqually()
        {
            variables.Add("C","8");
            Assert.Equal("true", uslov.MoreOrEqually("7","3",variables));            

        }
          [Fact]
         public void TestLessOrEqually()
        {
            variables.Add("C","8");
            Assert.Equal("fals", uslov.LessOrEqually("7","3",variables));            

        }

          [Fact]
         public void TestIfElseMore()
        {
            variables.Add("C","8");
            Assert.Equal("true", Program.IfElse("7 > 3",variables));            

        }

          [Fact]
         public void TestIfElseLess()
        {
            variables.Add("C","8");
            Assert.Equal("fals", Program.IfElse("7 < 3",variables));            

        }

          [Fact]
         public void TestIfElseMoreOrEqual()
        {
            variables.Add("C","8");
            Assert.Equal("true", Program.IfElse("7 >= 3",variables));            

        }

          [Fact]
         public void TestIfElseLessOrEqual()
        {
            variables.Add("C","8");
            Assert.Equal("fals", Program.IfElse("7 <= 3",variables));            

        }

          [Fact]
         public void TestIfElseEqually()
        {
            variables.Add("C","8");
            Assert.Equal("fals", Program.IfElse("7 == 3",variables));            

        }

          [Fact]
         public void TestIfElseNotEqually()
        {
            variables.Add("C","8");
            Assert.Equal("true", Program.IfElse("7 != 3",variables));            

        }
//тесты ошибок
          [Fact]
         public void TestOkaziia()
        {
            Assert.Equal("Okaziia", Oshibki.Okaziia("if a > b"));
             Assert.Equal("Okaziia", Oshibki.Okaziia("= 5")); 
              Assert.Equal("Okaziia", Oshibki.Okaziia("5 6 = 11"));  
               Assert.Equal("Okaziia", Oshibki.Okaziia(" a > b goto tt"));            

        }
//тест на возврат последнего элемента строки 
        [Fact]
         public void TestLastElement()
        {
            Assert.Equal("3", Program.LastElement("7 != 3"));            

        }

       
    }
}
