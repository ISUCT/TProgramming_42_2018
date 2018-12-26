using System;

namespace Zadanie1
{
    public class Pistol : Arsenal
    {
        public Pistol()
        {
            Name = "Colt";
            Kalibr = 0.45;
            Mass = 1.4f;
            Emkostmag = 7;
        }

        public Pistol(string name, double kalibr, float mass )
            : base(name, kalibr, mass)
        {
            Emkostmag = 7;
        }

        public override string GetInfo()
        {
            return $"������������: {Name}  ������: {Kalibr} �����: {Mass} ������� ��������: {Emkostmag}\n �������� {Name} ���������: \"���!\"";
        }

        public override string Display()
        {
            return @"

      +-'~`---------------------------------/\--
 ||"""""""""""""""""""""""""""""""" \\\\\\  \/~)
 ||                                  \\\\\\  \/_
  |~~~~~~~~-________________-_________________\ ~--_
  !---------|_________       ------~~~~~(--   )--~~
                      \ /~~~~\~~\   )--- \_ /(
                       ||     |  | \   ()   \\
                       \\____/_ / ()\        \\
                        `~~~~~~~~~-. \        \\
                                    \ \  <($)> \\
                                     \ \        \\
                                      \ \        \\
                                       \ \        \\
                                        \ \  ()    \|
                                        _\_\__====~~~
       

";
        }
    }
}
