using observale_pattern.observale;
using observale_pattern.subject;

namespace observale_pattern
{
    public class StockGrapperSubject : Subject
    {
        private double _ibmPrice ;

        private double _appPrice;

        private double _googlPrice;
        
        public List<Observale> Observales {set;get;}

        public double GetIBMPrice()
        {
            return _ibmPrice;
        }
        public void SetIBMPrice(double value)
        {
            _ibmPrice = value;
            NotifyObservale();
        }

        public double GetApplPrice()
        {
            return _appPrice;

        }
        public void SetApplPrice(double value)
        {
            _appPrice = value;
            NotifyObservale();
        }

        public double GetGooglePrice()
        {
            return _googlPrice;
        }
        public void SetGoogPrice(double value)
        {
            _googlPrice = value;
            NotifyObservale();
        }        
        
        public StockGrapperSubject()        
        {
            Observales= new List<Observale>();
        }

        public void NotifyObservale()
        {
            foreach (var observale in Observales)
            {
                observale.Update(GetIBMPrice(), GetApplPrice(), GetGooglePrice());
            }
        }

        public void Register(Observale observale)
        {
            Observales.Add(observale);  
        }

        public void UnRegister(Observale observale)
        {
            int observaleIndex=Observales.IndexOf(observale);

            Console.WriteLine("Observale "+observaleIndex+" deleted");

            Observales.Remove(observale);
        }
    }
}