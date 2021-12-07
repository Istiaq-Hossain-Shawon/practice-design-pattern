using templatepattern.Base;
namespace templatepattern.Concrete
{
    public sealed class CapacchinoCoffee : CoffeeTemplate
    {
        public override void BoilWater()
        {
            Console.WriteLine("Boil Water/n");
        }

        public override Boolean CustomerWantCapacchino()
        {
            return true;
        }

        public override Boolean CustomerWantMilk()
        {
           return true;
        }        

        public override void SetCapacchino()
        {
            Console.WriteLine("Set Capacchino/n");
        }

        public override void SetCoffee()
        {
           Console.WriteLine("Set Coffee/n");
        }

        public override void SetMilk()
        {
            Console.WriteLine("Set Milk /n");
        }

        public override void SetPacket()
        {
            Console.WriteLine("Set Cup Packet/n");
        }

        public override void SetSugar()
        {
            Console.WriteLine("Set Sugur Packet/n");
        }

    }
}