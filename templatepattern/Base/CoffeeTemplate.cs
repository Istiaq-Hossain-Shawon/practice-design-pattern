namespace templatepattern.Base
{
    public  abstract class CoffeeTemplate
    {
        public void MakeCoffie(){
            
            BoilWater();            
            SetCoffee();
            if(CustomerWantMilk()){
                SetMilk();
            }
            if(CustomerWantCapacchino()){
               SetCapacchino();
            }
            SetSugar();
            SetPacket();
        }
        public abstract Boolean CustomerWantMilk();
        public abstract Boolean CustomerWantCapacchino();

        
       
        public abstract void BoilWater();
        public  abstract void SetCoffee();

        public  abstract void SetMilk();

        public abstract void SetCapacchino();
        public abstract void SetPacket();
        public abstract void SetSugar();

    }
}