using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistrationsManagement.Registrations
{
    internal class CreateRegistrations
    {
        public static void CreateRegistrationsMethod(int number)
        {

            for (int i = 0; i < number; i++)
            {
                var uln = UlnHelper.GenerateUln().ToString();
                SqlQueries.CreateDbRegWithIpForLrs(uln, 3);
            }


        }

        public static void CreateRegistrationsParameterised(string CoreGrade, string SpecialismGrade, string Year, string tlevel, string provider, double NoOfRegistrations, int IPStatus, string MathsStatus, String EnglishStatus)
        {
            //int NumberOfRegistrations = Convert.ToInt32(NoOfRegistrations);
            for (int i = 0; i < NoOfRegistrations; i++)
            {
                var uln = UlnHelper.GenerateUln().ToString();
                SqlQueriesParameterised.CreateRegistration(uln, CoreGrade, SpecialismGrade, Year, tlevel, provider, IPStatus, MathsStatus, EnglishStatus);
            }

            Console.WriteLine("You have created: " + NoOfRegistrations + " registrations");
            Console.WriteLine("Press Enter key to continue");
            Console.ReadLine();
            Console.Clear();
            DisplayMenu.DisplayMenu1();
        }
    }
}
