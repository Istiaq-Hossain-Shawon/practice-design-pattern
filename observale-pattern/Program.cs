namespace observale_pattern
{
    class Progam{
        public static void Main (string[] arg){
            Console.WriteLine("hi");
            StockGrapperSubject stockGrabber = new StockGrapperSubject();

            StockObserver observer1 = new StockObserver(stockGrabber);
            stockGrabber.SetApplPrice(120.23);
            stockGrabber.SetGoogPrice(190.83);
            stockGrabber.SetIBMPrice(180.27);

            StockObserver observer2 = new StockObserver(stockGrabber);
            stockGrabber.SetApplPrice(145);
            stockGrabber.SetGoogPrice(958.2245);
            stockGrabber.SetIBMPrice(145480.32);

        }
    }

}