using System;
using Xunit;
using CourseApp;

namespace CourseApp.Tests
{
    public class TestOfCat
    {
        [Fact]
        public void Cat1()
        {
            Cat tom = new Cat();
            var name = tom.Name;
            var age = tom.Age;
            var color = tom.Color;
            Assert.Equal("Том", name);
            Assert.Equal(5, age);
            Assert.Equal("Серый", color);
        }

        [Fact]
        public void Cat2()
        {
            Cat red = new Cat("Рыжик", 6);
            var name = red.Name;
            var age = red.Age;
            var color = red.Color;
            Assert.Equal("Рыжик", name);
            Assert.Equal(6, age);
            Assert.Equal("рыжий", color);
        }

        [Fact]
        public void Cat3()
        {
            Cat begemot = new Cat("Бегемот", "черный");
            var name = begemot.Name;
            var age = begemot.Age;
            var color = begemot.Color;
            Assert.Equal("Бегемот", name);
            Assert.Equal(7, age);
            Assert.Equal("черный", color);
        }

        [Fact]
        public void Cat4()
        {
            Cat tom = new Cat();
            var name = tom.Name;
            Assert.Equal("Том", name);
            string word = Program.Meow(tom );
            Assert.Equal($"Кот Том сказал: \"Мяу!\"", word);
        }

        [Fact]
        public void Cat5()
        {
            Cat tom = new Cat();
            string cat = Program.Kot(tom );
            Assert.Equal(
            @"
	
          ,.                 .,
         ,: ':.    .,.    .:' :,
         ,',   '.:'   ':.'   ,',
         : '.  '         '  .' :
         ', : '           ' : ,'
         '.' .,:,.   .,:,. '.'
          ,:    V '. .' V    :,
         ,:        / '        :,
         ,:                   :,
          ,:       =:=       :,
           ,: ,     :     , :,
            :' ',.,' ',.,:' ':
           :'      ':WW::'   '.
          .:'       '::::'   ':
          ,:        '::::'    :,
          :'         ':::'    ':
         ,:           ':''     :.
        .:'             '.     ',.
       ,:'               ''     '.
       .:'               .',    ':
      .:'               .'.,     :
      .:                .,''     :
      ::                .,''    ,:
      ::              .,'','   .:'
    .,::'.           .,','     ::::.
  .:'     ',.       ,:,       ,WWWWW,
  :'        :       :W:'     :WWWWWWW,          .,.
  :         ',      WWW      WWWWWWWWW          '::,
  '.         ',     WWW     :WWWWWWWWW            '::,
   '.         :     WWW     :WWWWWWWW'             :::
    '.       ,:     WWW     :WWWWWWW'             .:::
     '.     .W:     WWW     :WWWWWW'           .,:::'
      '.   :WW:     WWW     :WWWWW'      .,,:::::''
     .,'   ''::     :W:     :WWWWW.  .,::::''
  ,'        ''','',',','','''WWWWW::::''
   ':,,,,,,,':  :  : : :  :  :WWWW'''
", cat);
        }

        [Fact]
        public void Cat6()
        {
            Cat tom = new Cat();
            string toStr = tom.ToString();
            Assert.Equal($"Кот Том замурлыкал", toStr);
        }

        [Fact]
        public void Cat7()
        {
            Cat tom = new Cat();
            string washing = tom.Wash(tom);
            Assert.Equal($"кот Том умылся лапками", washing);
        }

        [Fact]
        public void Cat8()
        {
            Cat red = new Cat("Рыжик", 6);
            string washing = red.Wash(red);
            Assert.Equal($"кот Рыжик умылся лапками", washing);
        }
    }
}
