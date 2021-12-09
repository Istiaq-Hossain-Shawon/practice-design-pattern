using observale_pattern.observale;
using observale_pattern.subject;

namespace observale_pattern
{
    public class StockObserver : Observale
    {
        private static int observerIDTracker = 0;
        private int observerID;

        private double _ibmPrice ;

        private double _appPrice;

        private double _googlPrice;

        public StockObserver(Subject subject)
        {
            this.observerID = ++observerIDTracker;

            Console.WriteLine("New Observer " + this.observerID);

            subject.Register(this);
        }

        public void Update(double IBMPrice, double aapPrice, double goodPrice)
        {
             this._ibmPrice = IBMPrice;
             this._appPrice = aapPrice;
             this._googlPrice = goodPrice;  
             printThePrices();          
        }
        public void printThePrices()
        {
            Console.WriteLine(observerID + "\nIBM: " + _ibmPrice + "\nAAPL: " +  _appPrice + "\nGOOG: " + _googlPrice + "\n");

        }

    }
}