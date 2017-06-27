using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variablesandoperators
{
    class Program
    {
        static void Main(string[] args)
        {
            //6_27_17
            // initializing new firstname variable
            /*  string name = "Mike";
              Console.WriteLine(name);
              name = "Daniel";
              Console.WriteLine(name);
              //printing the value of firstName to the console

              string birthMonth = "May";
              Console.WriteLine(birthMonth);
              // Console.WriteLine(10 + 2);

              int age = 65;
              string why = "because I said so";
              char firstIntial = 'L';
              //floating point types*/
            /*  float floatNumber = 2.164403304897294849383961032F;
              Console.WriteLine(floatNumber);
              double doubleNumber = 2.164403304897294849383961032D;
              Console.WriteLine(doubleNumber);
              decimal decimalNumber = 2.164403304897294849383961032M;
              Console.WriteLine(decimalNumber);*/
            /*  int jessicaAge = 23;
              int samAge = 47;
              Console.WriteLine(jessicaAge < samAge);*/


            /*   double amountEach = 13.55D;
               Console.WriteLine("What is the name on the reservation");
               string reserveName = Console.ReadLine();




               Console.WriteLine("How many people are in your party?");
               int numberOfPeople =int.Parse(Console.ReadLine());


               // Console.WriteLine("Reservation" + reserveName+"total Due:"+ amountEach *numberOfPeople);

               Console.WriteLine("Reservation + {0} + {2} + total Due:",reserveName,numberOfPeople,(amountEach*numberOfPeople));

            //  double totalBill = numberOfPeople * amountEach;
            // Console.WriteLine(totalBill);*/


            double amountOnHand = 40.00D;
            double packageCost = 8.00D;
            double howManyCanBuy = amountOnHand / packageCost;
            Console.WriteLine(howManyCanBuy);

            double juliaMilesTotal = 47D;
            double juliaMoreMilesThanP = 30D;
            double Pranva = juliaMilesTotal - juliaMoreMilesThanP;
            Console.WriteLine(Pranva);


            double amountPaid = 5.12d;
            double amountHad = 27.10d;
            double allMoney = amountPaid + amountHad;
            Console.WriteLine(allMoney);







        }
    }
}
