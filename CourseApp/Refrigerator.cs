using System;
using System.Collections.Generic;
using System.Text;

namespace CourseApp
{
    public class Refrigerator : Appliances
    {
        private double temperature;
        private bool status;
        private string statusInfo;

        public Refrigerator()
            : base()
        {
            Temperature = 3;
        }

        public Refrigerator(int temp)
            : base()
        {
            Temperature = temp;
            if (temp >= 5)
            {
                Model = 1;
            }
            else
            {
                Model = 2;
            }
        }

        public Refrigerator(int temp, int md, int ag, bool st)
            : base(md, ag, st)
        {
            Temperature = temp;
        }

        public double Temperature
        {
            get
            {
                return temperature;
            }

            set
            {
                if (value <= 0)
                {
                    temperature = 0;
                }
                else if (value >= 10)
                {
                    temperature = 10;
                }
                else
                {
                    temperature = value;
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
                    statusInfo = "\nХолодильник включен";
                }
                else
                {
                    status = value;
                    statusInfo = "\nХолодильник выключен";
                }
            }
        }

        public override string ToString()
        {
            return $"Температура в холодильнике: +{Temperature}, Модель холодильника {Model}, Возраст холодильника: {Age}. ";
        }

        public override string Art()
        {
            if (Model == 1)
            {
                return $@"
       ___________,_____
      |     |  #  |=====|
      |     | (_) |=====|
      |> _  |_____|=====|
      | [_] |     |     |
      |     |_____|=====|
      |     |     |_____|
      |   ] |_____|     |
      |     |_____|=====|
      |     | ___ |_____|
      |>    |[___]|     |
      |     |[___]|=====|
      |_____|=====|_____|";
            }
            else
            {
                return $@" 

      (∩∩│││┤┤╠╠╠║║║╢▒╢╢╢▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒
      ((∩∩││┤Ñ╠╠╠╠║║╢▒╢╢╢▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒
      '(∩∩││┤Ñ╠╠╠╠║║╢▒╢▒╢▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒
      :(∩∩││┤Ñ╠╠╠╠║║╢▒╢╢╢▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒
      :(∩∩││┤┤╠╠╠║║(╫▒│▒▒╢▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒
      ::∩∩││┤┤╠╠╠║║ ╫▒(▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒
      :((∩││┤┤╠╠╠╠╠ ╫▌(█▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒
      '(∩∩│││┤╠╠╠╠╠ █▌(█▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒
       ((∩││┤┤╠╠╠╠╠ █▌(█▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒
       '╔╔││┤┤╙╙╙╚╠ ╫▌(█▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒
       :Ñ╠ÑN╠╠Ñ┤ÑÑ╠ ▒▌(█▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒
       :▓▓▓▓▓▓▓▓▒▓▒ ▒▓(█▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒
       :▒▓▒╠╙Ñ╙▒∩║Ñ ▒▓j█▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒
       :▒▒▒│∩└└▐,ÑÑ ▓█j█▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒
       :▒▒∩'::∩⌠∩│▐ ▓█j█▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒
       :▒▒ ::(∩∩∩ ▐ ▓█j█▓▒▒▒▒▒▒▒▒▒▒▒▒▓▒▒▒▒
       :╙Ñ∩NNNN##M╢ █▌j██▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒
       ((∩│││┤Ñ╠╠╠╠ █▌j█▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒
       :(∩│││┤Ñ╠╠╠╠ █▌j█▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒
       :(∩│││┤╠╠╠╠╠ █▌j█▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒
       '(∩│││┤╠╠╠║║ █▌j█▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒
       ((∩│││┤╠╠╠║║j█▌j▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒
       ((∩││┤┤╠╠╠╠║j▓▌⌠▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒
       ((∩││┤┤╠╠╠╠║▒▒▒▒╢▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒
       (∩│││┤┤╠╠╠╠║║╢▒╢╢╢╢▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒
       (∩∩││┤┤╠╠╠╠║║╢▌╢╢╢▒╢▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒
      :(∩∩││┤Ñ╠╠╠╠║║╢▌║╢╢╢╢▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒
      ::∩│││┤Ñ╠╠╠╠║║╢▌║╢╢╢╢▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒
      (∩│││┤┤╠╠╠╠╠╠║╢▌║╢╢╢╢▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒
      (∩│││┤Ñ╠╠╠╠╠║║╢▌╢╢╢╢╢▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒
      ╓▄▄QQ╡ÑÑ╠║║║▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒
      ▒███████████████████████████████████
       └                                └";
            }
        }

        public override void GetInfo()
        {
            Console.WriteLine(statusInfo);
            Console.WriteLine(ToString());
            Console.WriteLine(Art());
        }
    }
}