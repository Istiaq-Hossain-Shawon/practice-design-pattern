namespace factorypattern.ConcreteCreator
{
    public class PermanentEmployee : Product.EmployeeManager
    {
        public override int GetBonus()
        {
            return 100;
        }

        public override int GetSalary()
        {
            return 20000;
        }
    }
}