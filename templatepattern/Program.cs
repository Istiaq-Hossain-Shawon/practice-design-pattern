//Make Coffie
//Normal Coffie,Black Coffie,Capacchino coffice,Hard coffie
//Step of coffice:Boil Water,Set Sugar,Set Coffie,Set Milk,Set Capacchino,SetPacket 
using templatepattern.Base;
using templatepattern.Concrete;

CoffeeTemplate coffeeTemplate= new NormalCoffee();
coffeeTemplate.MakeCoffie();
// CoffeeTemplate coffeeTemplate= new CapacchinoCoffee();
// coffeeTemplate.MakeCoffie();


// MakeNormalCoffie makeNormalCoffie= new MakeNormalCoffie();
// makeNormalCoffie.MakeNormalCoffie();
// public class MakeNormalCoffie{
//     public void MakeNormalCoffie (){
//         BoilWater();
//         SetWater();
//         SetCoffee();
//         SetMilk();
//         SetCapacchino();
//         SetPacket();
//     }

// }