using System;

namespace Zadanie1
{
    public class Pistol
    {
        private string name; // ���
        private double kalibr;
        private float mass;
        private byte emkostmag;

        public Pistol()
        {
            name = "Colt";
            kalibr = 0.45;
            mass = 1.4f;
            emkostmag = 7;
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                if (value.Length > 10)
                {
                    Console.WriteLine("������� ������� ��������");
                }
                else if (value.Length < 0)
                {
                    name = "��� ��������";
                }
                else
                {
                    name = value;
                }
            }
        }

        public double Kalibr
        {
            get
            {
                return kalibr;
            }

            set
            {
                if (value > 1)
                {
                    Console.WriteLine("����� �� �������� �� ���� ������");
                }
                else if (value < 0)
                {
                    name = "������ ����������";
                }
                else
                {
                    kalibr = value;
                }
            }
        }

        public float Mass
        {
            get
            {
                return mass;
            }

            set
            {
                if (value > 10)
                {
                    Console.WriteLine("������ ������� ������� ��� ������ ������");
                }
                else if (value < 0)
                {
                    name = "������ ����������";
                }
                else
                {
                    mass = value;
                }
            }
        }

        public byte Emkostmag
        {
            get
            {
                return emkostmag;
            }

            set
            {
                if (value > 20)
                {
                    Console.WriteLine("����� ��������� �� ����������");
                }
                else if (value < 0)
                {
                    name = "������� ����������";
                }
                else
                {
                    emkostmag = value;
                }
            }
        }

        public string GetInfo()
        {
            return $"������������: {name}  ������: {kalibr} �����: {mass} ������� ��������: {emkostmag}\n �������� {name} ���������: \"���!\"";
        }

        public string Display()
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
