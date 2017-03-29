using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Herencia
{
    class Program
    {
        static void Main(string[] args)
        {

            clsCliente_Ventas Client;
            Client = new clsCliente_Ventas();
            Client.IIdClient = 123;
            Client.SName = "Luis";
            Client.SLastName = "Ortiz";
            Client.SRuc = "1890767865001";
            Client.SAdress = "Av Amazonas y Colon";
            Client.BCredit = true;

            Console.WriteLine(Client.SName + " " + Client.SLastName);
            Console.WriteLine(Client.SAdress);
            Console.WriteLine(Client.SRuc);
            if (Client.BCredit)
                Console.WriteLine("The client has credit");
            else

                Console.WriteLine("The client hasn't credit");
                Console.ReadKey();

        }
    }
}
