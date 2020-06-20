using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Self_Assessment_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            GetSutudentInformation();

            PrintStudentDetails("Nguyen", "Trung Anh", "31-1-08-1998");
            PrintStudentDetails("Pham", "Phuong", "28-02-1998");
            PrintStudentDetails("Tran", "Dang Hai", "14-07-1998");

            Console.ReadKey();
        }

        static void GetSutudentInformation()
        {
            Console.WriteLine("Enter the student's first name: ");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter the student's last name: ");
            string lastName = Console.ReadLine();

            string name = (firstName +" "+ lastName);
            Console.WriteLine(name);
        }

        static void PrintStudentDetails(string first, string last, string birthday)
        {

            Console.WriteLine("\n{0} {1} was born on: {2}", first, last, birthday);
        }
    }
}
