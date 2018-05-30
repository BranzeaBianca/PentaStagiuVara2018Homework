using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Doriti sa stiti la ce varsta va pensionati si cati ani mai aveti pana acolo? Introduce-ti urmatoarele date");
            Console.WriteLine("Introduceti anul in care v-ati nascut");
            int year = int.Parse(Console.ReadLine());

            DateTime birthday = Birthday(year);
            Console.WriteLine("Ziua dumneavoastra de nastere este :{0} ", birthday);

            int age = Age(year, birthday);
            Console.WriteLine("Varsta dumneavoastra este : {0} ", age);

            Console.WriteLine("Introduceti F sau M in functie de sexul dumneavoastra: ");
            int? genderUser;
            string stringGender = Console.ReadLine().ToUpper();

            switch (stringGender)
            {
                case "F":
                    genderUser = (int?)Gender.Female;
                    break;
                case "M":
                    genderUser = (int?)Gender.Male;
                    break;
                default:
                    genderUser = null;
                    break;
            }

            if (genderUser == (int?)Gender.Female)
            {
                Console.WriteLine("Femeile se pensioneaza la 63 de ani");
                if (63 - age > 0)
                {
                    int i = 63 - age;
                    Console.WriteLine("Mai aveti {0} pana la pensie", i);
                }
                else Console.WriteLine("Ati ajuns deja la varsta de pensionare");
            }
            else if (genderUser == (int?)Gender.Male)
            {
                Console.WriteLine("Barbatii se pensioneaza la 65 de ani");
                if (65 - age > 0)
                {
                    int i = 65 - age;
                    Console.WriteLine("Mai aveti {0} pana la pensie", i);
                }
                else Console.WriteLine("Ati ajuns deja la varsta de pensionare");
            }
            else Console.WriteLine("ERROR");
        }
            private static DateTime Birthday(int year)
            {
                Console.WriteLine("Introduceti luna in care v-ati nascut");
                int month = int.Parse(Console.ReadLine());

                Console.WriteLine("Introduceti ziua in care v-ati nascut");
                int day = int.Parse(Console.ReadLine());

                return new DateTime(year, month, day);
            }


            private static int Age(int year, DateTime birthday)
            {
                int age = DateTime.Now.Year - year;
                return age;
            }


            public enum Gender
            {
                Female,
                Male 
            }
      

    }
}
