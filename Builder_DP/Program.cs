using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_DP
{
    public class Car
    {
        public string Name { get; set; }
        public string Body { get; set; }
        public int Engine { get; set; }
        public int Tires { get; set; }
        public string Efficiency { get; set; }
        public void Info()
        {
            Console.WriteLine("=============================");
            Console.WriteLine($"Car name: {Name}");
            Console.WriteLine($"Body: {Body}");
            Console.WriteLine($"Engine: {Engine}hp");
            Console.WriteLine($"Tires: {Tires}");
            Console.WriteLine($"Efficiency: {Efficiency}");
        }
    }
    public class Shop
    {
        public void Create(ConcreteBuilder concreteBuilder)
        {
            concreteBuilder.SetBody();
            concreteBuilder.SetEngine();
            concreteBuilder.SetTires();
            concreteBuilder.SetEfficiency();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Shop shop = new Shop();
            SedanBuilder sedanBuilder = new SedanBuilder();
            shop.Create(sedanBuilder);
            Car car = sedanBuilder.Car;
            car.Name = "Daewoo Lanos";
            car.Info();


            HatchBackBuilder hatchBackBuilder = new HatchBackBuilder();
            shop.Create(hatchBackBuilder);
            Car car2 = hatchBackBuilder.Car;
            car2.Name = "Hyundai Getz";
            car2.Info();
        }
    }
}
