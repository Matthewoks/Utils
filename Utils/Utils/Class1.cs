using Utils.MStringUtils;
namespace Utils
{
    public class Class1
    {
        public static string Hello(string name)
        { return "ciao"; }
    }

  public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Esecuzione della libreria MyLibrary...");
            MyTestFunction(); // Chiama una funzione della libreria per testarla
        }

     //  bool aaa= MStringUtils.VerificaDati(input);           
        public static void MyTestFunction()
        {
            Console.WriteLine("Funzionalità di test della libreria.");
        }
    }
}
