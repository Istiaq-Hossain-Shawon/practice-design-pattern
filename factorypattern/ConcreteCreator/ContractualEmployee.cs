namespace factorypattern.ConcreteCreator
{
    public class ContractualEmployee : Product.EmployeeManager
    {
        public override int GetBonus()
        {
            return 500;
        }

        public override int GetSalary()
        {
            return 8000;
        }
    }
}