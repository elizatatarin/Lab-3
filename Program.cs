using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лабораторна_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.InputEncoding = System.Text.Encoding.Unicode;

            Console.WriteLine("Натисніть будь-яку кнопку, для того, щоб вивести дані на екран");
            Console.ReadKey();

            //Cars
            Car car1 = new Car("Volkswagen", "Gray", 7000);
            Car car2 = new Car("Nissan", "Black", 10000);
            Car car3 = new Car("Toyota", "Blue", 15000);

            car1.Print();
            car1.ChangePrice(10);
            car1.Print();

            car2.Print();
            car2.ChangePrice(10);
            car2.Print();

            car3.Print();
            car3.ChangePrice(10);
            car3.Print();

            Console.WriteLine(car1 == car2);
            Console.WriteLine(car2 == car3);

            Console.ReadKey();
        }

    }
}
   
