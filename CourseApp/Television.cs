using System;

namespace CourseApp
{
    public class Television : Appliances
    {
        private int channel;
        private bool status;
        private string statusInfo;

        public Television()
            : base()
        {
            Channel = 1;
        }

        public Television(int ch)
            : base()
        {
            Channel = ch;
                if (ch >= 100)
                {
                    Model = 1;
                    Age = 3;
                }
                else
                {
                    Model = 2;
                    Age = 7;
                }
        }

        public Television(int ch, int md, int ag, bool st)
            : base(md, ag, st)
        {
            Channel = ch;
        }

        public int Channel
        {
            get
            {
                return channel;
            }

            set
            {
                if (value <= 0)
                {
                    channel = 0;
                }
                else if (value >= 255)
                {
                    channel = 255;
                }
                else
                {
                    channel = value;
                }
            }
        }

        public override bool Status
        {
            get
            {
                return status;
            }

            set
            {
                if (value == true)
                {
                    status = value;
                    statusInfo = "\nТелевизор включен\n";
                }
                else
                {
                    status = value;
                    statusInfo = "\nТелевизор выключен\n";
                }
            }
        }

        public override string ToString()
        {
            return $"Канал: {Channel}, Модель телевизора: {Model}, Возвраст телевизора: {Age}";
        }

        public override string Art()
        {
            string h = string.Empty;
            for (int i = 0; i < 3 - Channel.ToString().Length; i++)
            {
                h += (Model == 1) ? "▒" : "░";
            }

            if (Model == 1)
            {
                return $"\n ▄██████████████████████████████████████▄\n █▀─▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄─▀████████\n █▐▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▌███░░███\n █▐▒▒Канал {Channel}{h}▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▌█░░██░░█\n █▐▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▌███░░███\n █▐▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▌████████\n █▐▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▌███░░███\n █▐▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▌█░░██░░█\n █▐▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▌███░░███\n █▐▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▌████████\n █▐▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▌████████\n █▐▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▌████████\n █▄─▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀─▄████████\n ▀██████████████████████████████████████▀\n ───▄▄▄████████████████████████████▄▄▄\n ──████████████████████████████████████";
            }
            else
            {
                return $"\n ██████████░▀▀██████████████▀▀░██████████\n ████████████▄░▀▀████████▀▀░▄████████████\n ███████████████▄█▀▀▀▀▀▀█▄███████████████\n ████████████████▄▄▄▄▄▄▄▄████████████████\n ████▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀████\n ███░░▄▄█████████████████████▄░░░▄▄░░░███\n ███░░█▀░Канал {Channel}{h}▄▄▄▄█████████░████░░███\n ███░░█░░░░░░░▄████████████████░░▀▀░░░███\n ███░░█░░░░▄███████████████████░░░░░░░███\n ███░░█░░░█████████████████████░░░░░░░███\n ███░░█░░██████████████████████░░░░░░░███\n ███░░█░███████████████████████░▀███░░███\n ███░░█████████████████████████░▄▄▄▄░░███\n ███░░█████████████████████████░▄▄▄▄░░███\n ███░░▀███████████████████████▀░░▀▀▀░░███\n ███▄░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░▄███\n ████████████████████████████████████████";
            }
        }

        public override void GetInfo()
        {
            Console.Write(statusInfo);
            Console.WriteLine(ToString());
            Console.WriteLine(Art());
        }
    }
}