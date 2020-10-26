using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatch1
{
    class Program
    {

        static void Main(string[] args)
        {

            Console.WriteLine("Skriv en siffra mellan 1-10!");

            int myNumber;

            try
            {
                myNumber = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException henric)
            {
                Console.WriteLine($"Ooops, something went wrong! Error message: {henric.Message}");
            }
            finally
            {
                Console.WriteLine("Gick något fel?");
                Console.ReadLine();
                //Detta block exekveras ALLTID. Bra ställe att tex stänga Filereaders/writers eller
                //eller andra resurser som tex databaskopplingar
            }

            try
            {
                TryAgain(13);
            }
            catch (CustomException ce)
            {
                Console.WriteLine(ce.ErrorMessage);
            }

            Console.ReadLine();

        }

        /// <summary>
        /// Min metod för att försöka igen
        /// </summary>
        /// <param name="numberOfRetries">Antalet försök</param>
        public static void TryAgain(int numberOfRetries)
        {
            if (numberOfRetries > 12)
            {
                throw new CustomException(12);
            }
        }
    }
}
