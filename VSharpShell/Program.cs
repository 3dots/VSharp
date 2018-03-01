using System;
using VSharpConsoleApp;

namespace VSharpShell
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //TODO Override WriteLine with an extra NewLine each time.
                Console.WriteLine("Hello World!");

                var iVsharpConsoleApp = new VsharpConsoleApp() as IVsharpConsoleApp;

                iVsharpConsoleApp.Run();

                Console.WriteLine("Program Terminated. Press any key to exit.");
                Console.ReadKey();
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
                Console.WriteLine("Program suffered an unrecoverable Exception. Press any key to exit.");
                Console.ReadKey();
            }
            finally
            {
                Console.WriteLine("Goodbye.");
            }
            
        }
    }

    
}



