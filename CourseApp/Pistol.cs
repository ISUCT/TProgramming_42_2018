using System;
namespace Zadanie1
{
    public class Pistol
    {
        public string name; // ���
        public double kalibr;
        public float mass;
        public int emkostmag;
        public Pistol() { name = "Colt";kalibr = 0.45;mass = 1.4f;emkostmag = 7; }
       public string GetInfo()
        {
            return($"������������: {name}  ������: {kalibr} �����: {mass} ������� ��������: {emkostmag}\n �������� {name} ���������: \"���!\"");
        }

        public string display()
        {
            return(@"

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
       

");
         
        }

        public static implicit operator string(Pistol v)
        {
            throw new NotImplementedException();
        }
    }
}