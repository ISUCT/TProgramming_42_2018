using System;
namespace Zadanie1
{
    public class Pistol
    {
        public string name; // ���
        public double kalibr;
        public float mass;
        public int emkostmag;

        public void GetInfo()
        {
            Console.WriteLine($"������������: {name}  ������: {kalibr} �����: {mass} ������� ��������: {emkostmag}");
        }
        public void display()
        {
            Console.WriteLine(@"

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
    }
}