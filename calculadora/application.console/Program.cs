using operaciones;
using System;
namespace application.console
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Suma X ;
            X = new Suma();
            string Datosuser ;
            Console.WriteLine("digite el numero A: ");
            Datosuser = Console.ReadLine();
            int UNO;
            UNO = Int32.Parse(Datosuser);
            X.numera = UNO;
            Console.WriteLine("digite el numero B: ");
            Datosuser = Console.ReadLine();
            UNO = Int32.Parse(Datosuser);
            X.numerb = UNO;
            X.sumar();
            string Operacion;
            Operacion = Console.ReadLine();
            if (Operacion == "1")
            {


            } else if (Operacion == "2")
            {
               
            }
            else
            {

            }
            Console.WriteLine("el numero A: "+ X.numera +"  mas el numero B: "+ X.numerb +"  da como resultado:  " + X.numerc);
        }
    }
}
