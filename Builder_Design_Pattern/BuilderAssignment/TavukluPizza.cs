using System;
namespace BuilderDesignPattern
{
    public class TavukluPizzaBuilder : PizzaBuilder
    {
        public TavukluPizzaBuilder()
        {
            _pizza = new Pizza { PizzaTipi = "Tavukllu Pizza" };
        }


        public override void HamurHazirlama()
        {
            _pizza.Sos = "Tavuk Parçalari, domates ,Sogan";
        }

        public override void SosHazirlama()
        {

            _pizza.Hamur = "Kalin, naneli ve kori Soslu";
        }
    }
}
