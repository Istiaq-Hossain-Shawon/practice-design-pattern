namespace Application{
    
    public delegate void HelloDelegateMethod(string message);
    public class Program{
        public static void Main (string[] args ){
            Console.WriteLine("HI");
            HelloDelegateMethod helloDelegate = new HelloDelegateMethod(Hello);
            helloDelegate("THis is delegate message.");
        }

        public static void Hello(string message){
            Console.WriteLine(message);
        }
    }

}



// namespace delegates
// {
//     public delegate void HelloDelegate(string message);
// public class Program{
//     public static void main(string[] arg){
//         HelloDelegate helloDelegate = new HelloDelegate(Hello);
//         helloDelegate("HI");

//     } 
    

//     public static void Hello(string message){
//         Console.WriteLine(message);
//     }
// }
   
// }
