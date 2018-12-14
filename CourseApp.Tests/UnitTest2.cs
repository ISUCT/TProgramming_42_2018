using System;
using Xunit;
using Zadanie1;

namespace CourseApp.Tests
{
    public class UnitTest2
    {
        [Fact]
        public void Test12()
        {
            Pistol �olt = new Pistol();
            var name = �olt.Name;
            var kalibr = �olt.Kalibr;
            var emkostmag = �olt.Emkostmag;
            var mass = �olt.Mass;
            Assert.Equal("Colt", name);
            Assert.Equal(0.45, kalibr);
            Assert.Equal(7, emkostmag);
            Assert.Equal(1.4f, mass);
           
        }
        [Fact]
        public void Test13()
        {
            Pistol Colt = new Pistol();
            string pistol = Colt.Display();
            Assert.Equal(@"

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
       

", pistol);
        }
        [Fact]
        public void Test14()
        {
            Pistol �olt = new Pistol();
            var name = �olt.Name;
            var kalibr = �olt.Kalibr;
            var mass = �olt.Mass;
            var emkostmag = �olt.Emkostmag;
            Assert.Equal("Colt", name);
            string Pistol = �olt.GetInfo();
            Assert.Equal($"������������: {name}  ������: {kalibr} �����: {mass} ������� ��������: {emkostmag}\n �������� {name} ���������: \"���!\"", Pistol);
        }

    }
}
