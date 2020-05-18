using System;
namespace BuilderDesignPattern
{
    public class Director
    {
        public void Olustur(PizzaBuilder vBuilder)
        {
            vBuilder.SosHazirlama();
            vBuilder.HamurHazirlama();
        }


    }
}