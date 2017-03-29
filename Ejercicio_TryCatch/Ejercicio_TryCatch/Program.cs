using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_TryCatch
{
    class Program
    {
        static void Main(string[] args)
        {

            string m_sProduct;
            int m_iQuantity;
            double m_dUnitPrice;
            double m_dTotal;

            try
            {

                Console.WriteLine("Please insert the product:");
                m_sProduct = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Please insert the quantity:");
                m_iQuantity = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please insert the unit price:");
                m_dUnitPrice = Convert.ToDouble(Console.ReadLine());

                m_dTotal = m_dUnitPrice * m_iQuantity;

                Console.WriteLine("The total is: " + m_dTotal);

            }

            catch(Exception Error)
            {
                Console.WriteLine("Sorry but "  + Error.Message);
            }


            finally
            {

                Console.ReadKey();

            }

                

        }
    }
}
