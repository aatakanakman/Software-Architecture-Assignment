using System;

namespace BuilderDesignPattern
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            PizzaBuilder vBuilder;
            Director drk = new Director();

            vBuilder = new BaharatliPizzaBuilder();

            drk.Olustur(vBuilder);
            Console.WriteLine(vBuilder.Pizza.ToString());

            vBuilder = new TavukluPizzaBuilder();
            drk.Olustur(vBuilder);
            Console.WriteLine(vBuilder.Pizza.ToString());
        }


    }
}
