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

        public static void CreateAllCombinations(string Year, string tlevel, string provider, string MathsStatus, String EnglishStatus)
        {

            String IPStatus = "";
            String CoreGrade = "";
            String SpecialismGrade = "";
            string[] CoreGradeArray = { "1", "2","3", "4", "5", "6","7","N" };
            string[] SpecialismGradeArray = { "10", "11", "12", "13","N"};
            string[] IPStatusArray = { "1", "2", "3","4"};
            //int NumberOfRegistrations = Convert.ToInt32(NoOfRegistrations);
            string Name = "";
            string Surname = "";
            string ULN = "";
            int overallCount = 0;

            for (int i = 0; i < 8; i++)
            {
                CoreGrade = CoreGradeArray[i];      

                for (int j = 0; j < 5; j++)
                {
                    SpecialismGrade = SpecialismGradeArray[j];

                    for (int k = 0; k < 4; k++)
                    {
                        IPStatus = IPStatusArray[k];

                        Name = "Core" + CoreGradeArray[i] + " Specialism" + SpecialismGradeArray[j];
                        Surname = "IPStatus " + IPStatusArray[k];
                        ULN = UlnHelper.GenerateUln().ToString();
                        CreateAllResultsCombinationsSQL.CreateRegistration(ULN, CoreGrade, SpecialismGrade, Year, tlevel, provider, IPStatus, MathsStatus, EnglishStatus,Name,Surname );
                        overallCount = overallCount + 1;
                                               
                        Console.WriteLine(IPStatusArray[k] + "  Creating registration with Core Grade: " + CoreGradeArray[i] + ", Specialism Grade: " + SpecialismGradeArray[j] + " IPStatus: " + IPStatusArray[k] + " ULN:" + ULN + "\n");
                    }
                }

            }

            

            Console.WriteLine("You have created: " + overallCount + " registrations");
            Console.WriteLine("Press Enter key to continue");
            Console.ReadLine();
            Console.Clear();
            DisplayMenu.DisplayMenu1();
        }
    }
}
