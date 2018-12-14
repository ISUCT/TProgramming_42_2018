using Xunit;
using System;
using CourseApp;

namespace CourseApp.Tests
{
    public class UnitTest2
    {
        [Fact]
        public void Test1()
        {
            Fox one = new Fox();
            var name = one.Name;
            var age = one.Age;
            var color = one.Color;
            Assert.Equal("Первая", name);
            Assert.Equal(3, age);
            Assert.Equal("Рыжая", color);
        }
        [Fact]
        public void Test2()
        {
            Fox two = new Fox("Вторая", "Чёрная");
            var name = two.Name;
            var age = two.Age;
            var color = two.Color;
            Assert.Equal("Вторая", name);
            Assert.Equal(3, age);
            Assert.Equal("Чёрная", color);
        }
        [Fact]
        public void Test3()
        {
            Fox three = new Fox("Третья", "Белая", 3);
            var name = three.Name;
            var age = three.Age;
            var color = three.Color;
            Assert.Equal("Третья", name);
            Assert.Equal(3, age);
            Assert.Equal("Белая", color);
        }

        [Fact]
        public void Test4()
        {
            Fox one = new Fox();
            var age = one.Age;
            one.Age = -1;
            Assert.Equal(3, age);
        }



        [Fact]
        public void Test5()
        {
            string fox = @"   
                                                                   ,-,
                                                             _.-=;~ /_
                                                          _-~   '     ;.
                                                      _.-~     '   .-~-~`-._
                                                _.--~~:.             --.____88
                              ____.........--~~~. .' .  .        _..-------~~
                     _..--~~~~               .' .'             ,'
                 _.-~                        .       .     ` ,'
               .'                                    :.    ./
             .:     ,/          `                   ::.   ,'
           .:'     ,(            ;.                ::. ,-'
          .'     ./'.`.     . . /:::._______.... _/:.o/
         /     ./'. . .)  . _.,'               `88;?88|
       ,'  . .,/'._,-~ /_.o8P'                  88P ?8b
    _,'' . .,/',-~    d888P'                    88'  88|
 _.'~  . .,:oP'        ?88b              _..--- 88.--'8b.--..__
:     ...' 88o __,------.88o ...__..._.=~- .    `~~   `~~      ~-._ Seal _.
`.;;;:='    ~~            ~~~                ~-    -       -   -";

            Assert.Equal(@"   
                                                                   ,-,
                                                             _.-=;~ /_
                                                          _-~   '     ;.
                                                      _.-~     '   .-~-~`-._
                                                _.--~~:.             --.____88
                              ____.........--~~~. .' .  .        _..-------~~
                     _..--~~~~               .' .'             ,'
                 _.-~                        .       .     ` ,'
               .'                                    :.    ./
             .:     ,/          `                   ::.   ,'
           .:'     ,(            ;.                ::. ,-'
          .'     ./'.`.     . . /:::._______.... _/:.o/
         /     ./'. . .)  . _.,'               `88;?88|
       ,'  . .,/'._,-~ /_.o8P'                  88P ?8b
    _,'' . .,/',-~    d888P'                    88'  88|
 _.'~  . .,:oP'        ?88b              _..--- 88.--'8b.--..__
:     ...' 88o __,------.88o ...__..._.=~- .    `~~   `~~      ~-._ Seal _.
`.;;;:='    ~~            ~~~                ~-    -       -   -", fox);

        }
    }
}
