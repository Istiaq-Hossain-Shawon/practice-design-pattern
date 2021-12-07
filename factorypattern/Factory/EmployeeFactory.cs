using factorypattern.ConcreteCreator;

namespace factorypattern.Factory
{
    public class EmployeeFactory
    {
        public Product.EmployeeManager GetEmployeeManager(int i){
            if(i==1){
                return new ContractualEmployee();
            }
            if(i==2){
                return new PermanentEmployee();
            }
            return null;

        }
    }
}