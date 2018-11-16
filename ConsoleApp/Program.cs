using System;

namespace ConsoleApp
{
    class Television
    {
        public byte type;
        public byte channel;
        static string f = Console.ReadLine();
        byte ch = byte.Parse(f);
        public void setChannel(byte n)
        {
            if (n < 0)
            {
                Console.WriteLine("Канал не может быть отрицательным числом");
            }
            else channel = n;
        }
        public void setType(byte n)
        {
            if (n <= 0 && n > 2)
            {
                Console.WriteLine("Тип должен быть равен 1 или 2");
            }
            else type = n;
        }
        public Television(byte c, byte m, byte t)
        {
            setChannel(c);
            setType(t);
            setModel(m);
        }

    }
}

