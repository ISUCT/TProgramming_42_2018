using System;

namespace CourseApp
{
    public class Cat : Animal, IWash, IComparable
    {
        public Cat()
            : this("Том", 5)
        {
            Color = "Серый";
        }

        public Cat(string name, float age)
        {
            Name = name;
            Age = age;
            Color = "рыжий";
        }

        public Cat(string name, string color)
            : this(name, 7)
        {
            Color = color;
        }

        public string Wash(object o)
        {
            Cat c = o as Cat;
            return $"кот {c.Name} умылся лапками";
        }

        public int CompareTo(object o)
        {
            Cat p = o as Cat;
            if (p != null)
            {
                return this.Name.CompareTo(p.Name);
            }
            else
            {
                throw new Exception("Невозможно сравнить два объекта");
            }
        }

        public override void Display()
        {
            Console.WriteLine("Животное - кот");
            Console.WriteLine($"Имя: {Name}, Возраст: {Age} лет, окрас: {Color} ");
            Console.WriteLine(Voice());
            Console.WriteLine(Kotik());
        }

        public override string ToString()
        {
            return $"Кот {Name} замурлыкал";
        }

        public override string Voice()
        {
            return $"Кот {Name} сказал: \"Мяу!\"";
        }

        public string Kotik()
        {
            return @"
	
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
";
        }
    }
}
