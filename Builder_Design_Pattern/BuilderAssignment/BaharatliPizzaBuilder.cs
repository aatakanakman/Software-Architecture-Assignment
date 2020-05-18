using System;
namespace BuilderDesignPattern
{
    public class BaharatliPizzaBuilder : PizzaBuilder
    {

        public BaharatliPizzaBuilder()
        {
            _pizza = new Pizza { PizzaTipi = "Baharatli Pizza" };
        }

        public override void HamurHazirlama()
        {
            _pizza.Sos = "Aci Sos , domates, balkan sosu";
        }

        public override void SosHazirlama()
        {
            _pizza.Hamur = "Citir, ince kenarlı";
        }
    }
}
