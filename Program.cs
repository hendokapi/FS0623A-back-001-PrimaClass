using System;

namespace PreProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            //Person gigi = new Person();
            //gigi.Greet();
            Person pinco = new Person();
            //pinco.Grow(20);


            pinco.Age = -50;
            Console.WriteLine(pinco.Age);

            pinco.Price = 20; // si è attivato il setter di Price
            int taxed = pinco.Price + 10; // si è attivato il getter di Price
            Console.WriteLine(taxed);
            pinco.PrintPriceCents();

            //pinco.EyeColor = "Black";
            pinco.Greet();
            //Console.WriteLine(pinco.HowMuchTo18());
            //pinco.TellHowMuchTo18();
            Console.ReadLine();
        }
    }

    public class Person
    {
        // fields (campi)
        public int Height = 180;


        // properties (proprietà)
        // property scorciatoia
        public string EyeColor { get; } = "Brown";

        // property completa
        public int _age = 15;
        public int Age
        {
            get
            {
                return _age - 15;
            }
            set
            {
                if (value >= 0)
                {
                    _age = value;
                }
            }
        }

        private int _price = 1000;
        public int Price
        {
            get
            {
                return _price / 100;
            }
            set
            {
                _price = value * 100;
            }
        }



        // methods (metodi)

        public void PrintPriceCents()
        {
            Console.WriteLine(_price);
        }

        // public Greet()   // signature usata per l'overloading del metodo
        public void Greet() // signature completa del metodo 
        {
            Console.WriteLine("Hi, my eye color is " + this.EyeColor + " " + Height.ToString());
        }

        // public Grow(int delta)    // signature usata per l'overloading
        public void Grow(int delta) // signature completa del metodo
        {
            Height = Height + delta;
        }
        
        public int HowMuchTo18()
        {
            return 18 - Age;
        }

        public void TellHowMuchTo18()
        {
            Console.WriteLine($"{EyeColor} dice che ai 18 anni mancano {HowMuchTo18()}");
        }

        // non serve in c# perchè ci sono le properties
        //public void SetAge(int age)
        //{
        //    if (age >= 0)
        //    {
        //        this.Age = age;
        //        Age = age;
        //    }
        //}
    }
}
