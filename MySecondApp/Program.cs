using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySecondApp
{
    public sealed class VehicleDescriptionAttribute : System.Attribute
    {
        public string Description { get; set; }
        public VehicleDescriptionAttribute(string vehicalDescnption)
        => Description = vehicalDescnption;
        public VehicleDescriptionAttribute() { }
    }
    [VehicleDescription("Му Auto AUDI")]
    public class Car
    {
        public string Name { get; set; }
        public Car() { }
        public Car(string name)
        {
            Name = name;
        }
        //public override string ToString() => $"Name = {Name}";
        public void TurboBoost()
        { Console.WriteLine("Ja estj method iz pozdnego svjazivanija"); }
        public void TurnOn(bool muzik, string str)
        {
            Console.WriteLine("Muzik TurnOn? {0} Muzik System Name: {1}", muzik, str);
        }
    }

    [VehicleDescription(Description ="Му Rockin Suzuki")]
    public class Moto
    {
        public string Name { get; set; }
        public Moto() { }
        public Moto(string name)
        {
            Name = name;
        }
        //public override string ToString() => $"Name = {Name}";
        public void TurboBoost()
        { Console.WriteLine("Ja estj method iz pozdnego svjazivanija"); }
        public void TurnOn(bool muzik, string str)
        {
            Console.WriteLine("Muzik TurnOn? {0} Muzik System Name: {1}", muzik, str);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car("MyCar iz pozdnego svjazivanija");
            Console.WriteLine(car);
            Console.ReadLine();
        }
    }
}
