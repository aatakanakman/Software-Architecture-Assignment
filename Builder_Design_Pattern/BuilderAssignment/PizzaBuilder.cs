using System;
namespace BuilderDesignPattern
{
    public abstract class PizzaBuilder
    {
        protected Pizza _pizza;

        public Pizza Pizza
        {
            get { return _pizza; }
        }

        public abstract void SosHazirlama();
        public abstract void HamurHazirlama();
    }
}