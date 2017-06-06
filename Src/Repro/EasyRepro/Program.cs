using System;

namespace EasyRepro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(".NET Client Libraries Easy Repro Project");

            try
            {
                ReproduceProblem();
            } catch (Exception ex)
            {
                Console.WriteLine("Unhandled Exception:\n{0}", ex);
            }

            Console.WriteLine("(press any key to continue)");
            Console.ReadKey();
        }

        static void ReproduceProblem()
        {
            // TODO: Put problem here.
        }
    }
}
