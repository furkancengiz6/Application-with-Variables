using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_with_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the following information:");
            Console.WriteLine("T.C. Your ID Number:");
            //TC kimlik numarası için string kullandım çünkü  Kimlik numarası ile herhangi bir matematiksel işlem yapılmaz.
            string tcNumber = Console.ReadLine();
            Console.WriteLine("Your Name:");
            string firstName= Console.ReadLine();
            Console.WriteLine("Your LastName:");
            string lastName =Console.ReadLine();
            //Telefon numarası string kullandım çünkü Phone numarası ile herhangi bir matematiksel işlem yapılmaz.
            Console.WriteLine("Your Phone Number:");
            string phoneNumber = Console.ReadLine();
            //Console.readline sadece metin girişidir.bu yüzden tryParse kullanıp intager'a çevirdim.
            Console.WriteLine("The price of the first product you purchased");
            string firstProduct = Console.ReadLine();
            bool tryParse1 = Int32.TryParse(firstProduct, out int product1);
            
            Console.WriteLine("The price of the second product you purchased");
            string secondProduct = Console.ReadLine();
            bool tryParse2 = Int32.TryParse(firstProduct, out int product2);

            int percentage = 10;       int sum = product1 + product2;        int result = (sum * percentage) / 100;

            Console.WriteLine("---------------------------------------------------------------");
            Console.WriteLine($"{tcNumber}, TC numbered, {firstName}, A record has been created for the person named.");
            Console.WriteLine($"{phoneNumber}, A notification message has been sent to the phone number.");
            Console.WriteLine($"{sum}, 10% amount of trail points earned for total spending is->{result}");
        }
    }
}
