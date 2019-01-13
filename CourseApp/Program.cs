namespace CourseApp
{
    using System;

    public class Program
    {
        private static void Main()
        {
            Console.WriteLine("13 вариант");
            Console.WriteLine();

            Employee one = new Employee(); // создание 1-го
            Employee two = new Employee("Nikita", "Singh", "Miss", 35, 153, 55, DateTime.Now); // создание 2-го

            Skateboarder three = new Skateboarder("Candy", "Jacobs", "Ms", 28, 165, 64, "goofy"); // создание 3-го

            one.GetInfo();
            two.GetInfo();
            two.Injury();
            two.GetInfo();

            three.GetInfo();
            three.Injury();
            three.GetInfo();

            Console.WriteLine(one.GetHireDate());
            Console.WriteLine(two.GetHireDate());
            Console.WriteLine(three.GetHireDate());
            Console.WriteLine();

            Console.WriteLine(one.ToString());
            Console.WriteLine(two.ToString());
            Console.WriteLine(three.ToString());
            Console.WriteLine();

            HumanBeing[] humanBeings = new HumanBeing[2];
            humanBeings[0] = new Employee("Гога", "Воробьёв", 20, DateTime.Now);
            humanBeings[1] = new Skateboarder("Жора", "Воробьёв-Насос", 20, "regular");
            foreach(HumanBeing i in humanBeings)
            {
                i.GetInfo();
            }

            Console.Read();
        }
    }
}