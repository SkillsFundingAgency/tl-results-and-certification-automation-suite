using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistrationsManagement.Registrations
{
    internal class CreateParameterisedReg
    {
        public static string CoreGrade = "";
        public static string SpecialismGrade = "";
        public static string Answer = "";
        public static string RegistrationYear = "";
        public static string IPStatus = "";
        public static string TLevelChosen = "";
        public static string Provider = "";
        public static Double NoOfRegistrations = 0;
        public static string ConnectionString = "";
        public static string ConnectionStringVerification = "";
        public static int IndustryPlacementStatus = 0;
        public static string MathsStatus = "";
        public static string EnglishStatus = "";

        public static void CreateParamRegistration()
        {
            Console.Clear();
            // Display title for the create parameterised registration code.
            Console.WriteLine("\r");
            Console.WriteLine("Create Parameterised Registration\r");
            Console.WriteLine("---------------------------------\n");

            Console.WriteLine("\r\nPlease select a T Level for your registration: \n");
            Console.WriteLine("\t1:  T Level in Design, Surveying and Planning for Construction");
            Console.WriteLine("\t2:  T Level in Onsite Construction");
            Console.WriteLine("\t4:  T Level in Education and Childcare");
            Console.WriteLine("\t5:  T Level in Digital Production, Design and Development");
            Console.WriteLine("\t6:  T Level in Digital Support Services");
            Console.WriteLine("\t7:  T Level in Digital Business Services");
            Console.WriteLine("\t8:  T Level in Health");
            Console.WriteLine("\t9:  T Level in Healthcare Science");
            Console.WriteLine("\t10: T Level in Science");
            Console.Write("Please enter the letter corresponding to your choice: ");

            TLevelChosen = Convert.ToString(Console.ReadLine());

            while ((TLevelChosen != "1" && TLevelChosen != "2" && TLevelChosen != "4" && TLevelChosen != "5" && TLevelChosen != "6" && TLevelChosen != "7" && TLevelChosen != "8" && TLevelChosen != "9" && TLevelChosen != "10"))
            {
                Console.WriteLine("\r\nPlease select a T Level for your registration: \n");
                Console.WriteLine("\t1:  T Level in Design, Surveying and Planning for Construction");
                Console.WriteLine("\t2:  T Level in Onsite Construction");
                Console.WriteLine("\t4:  T Level in Education and Childcare");
                Console.WriteLine("\t5:  T Level in Digital Production, Design and Development");
                Console.WriteLine("\t6:  T Level in Digital Support Services");
                Console.WriteLine("\t7:  T Level in Digital Business Services");
                Console.WriteLine("\t8:  T Level in Health");
                Console.WriteLine("\t9:  T Level in Healthcare Science");
                Console.WriteLine("\t10: T Level in Science");
                Console.Write("Please only enter a letter corresponding to your choice: ");
                TLevelChosen = Convert.ToString(Console.ReadLine());
            }


            Console.WriteLine("\r\nPlease select a provider for your registration: \n");
            Console.WriteLine("\tA: Barnsley");
            Console.WriteLine("\tB: Dudley");
            Console.Write("Please enter the letter corresponding to your choice: ");
            Provider = Convert.ToString(Console.ReadLine());

            while (Provider != "A" && Provider != "B")
            {
                Console.WriteLine("\r\nPlease select a provider for your registration: \n");
                Console.WriteLine("\tA: Barnsley");
                Console.WriteLine("\tB: Dudley");
                Console.Write("Please only enter the letter corresponding to your choice: ");
                Provider = Convert.ToString(Console.ReadLine());
            }

            SqlQueriesParameterised.CheckTQProviderTable(TLevelChosen, Provider);


            Console.WriteLine("\r\nWhich year would do you want the registration for? (2020 or 2021): \n");
            RegistrationYear = Convert.ToString(Console.ReadLine());

            while ((RegistrationYear != "2020") && (RegistrationYear != "2021"))
            {
                Console.WriteLine("\r\nPlease enter either 2020 or 2021 only: \n");
                RegistrationYear = Convert.ToString(Console.ReadLine());
            }

           //Capture the Maths status
            Console.WriteLine("\r\nPlease select the student's maths status: \n");
            Console.WriteLine("\t1: Achieved ");
            Console.WriteLine("\t2: Achieved With Send ");
            Console.WriteLine("\t3: NotAchieved  ");
            Console.WriteLine("\t4: Not Specified");
            Console.Write("Please enter the number corresponding to your choice: ");
            MathsStatus = Convert.ToString(Console.ReadLine());

            while (MathsStatus != "1" && MathsStatus != "2" && MathsStatus != "3" && MathsStatus != "4")
            {
                Console.WriteLine();
                Console.WriteLine("\r\nPlease enter a valid option: \n");
                MathsStatus = Convert.ToString(Console.ReadLine());
            }

            //Capture the English status
            Console.WriteLine("\r\nPlease select the student's English status: \n");
            Console.WriteLine("\t1: Achieved ");
            Console.WriteLine("\t2: Achieved With Send ");
            Console.WriteLine("\t3: NotAchieved  ");
            Console.WriteLine("\t4: Not Specified");
            Console.Write("Please enter the number corresponding to your choice: ");
            EnglishStatus = Convert.ToString(Console.ReadLine());

            while (EnglishStatus != "1" && EnglishStatus != "2" && EnglishStatus != "3" && EnglishStatus != "4")
            {
                Console.WriteLine();
                Console.WriteLine("\r\nPlease enter a valid option: \n");
                EnglishStatus = Convert.ToString(Console.ReadLine());
            }



            Console.WriteLine("\r\nWould you like to add a core result?: (Y or N) \n");
            Answer = Convert.ToString(Console.ReadLine());

            if (Answer == "Y")
            {
                Console.WriteLine("Choose an option from the following list:");
                Console.WriteLine("\tA*");
                Console.WriteLine("\tA");
                Console.WriteLine("\tB");
                Console.WriteLine("\tC");
                Console.WriteLine("\tD");
                Console.WriteLine("\tE");
                Console.WriteLine("\tU");
                Console.Write("Please select an option: ");
                CoreGrade = Convert.ToString(Console.ReadLine());
                Console.Write("\r\nCore Grade: " + CoreGrade);
            }
            else 
            {
                CoreGrade = "N";
                Console.Write("\r\nCore Grade: " + CoreGrade);
            }

            Console.WriteLine("\r\nWould you like to add a specialism result?: (Y or N) \n");

            Answer = Convert.ToString(Console.ReadLine());

            if (Answer == "Y")
            {
                Console.WriteLine("Choose an option from the following list:");
                Console.WriteLine("\tD - Distinciton");
                Console.WriteLine("\tM - Merit");
                Console.WriteLine("\tP - Pass");
                Console.WriteLine("\tU - Unclassified");
                Console.Write("Please select an option: ");
                SpecialismGrade = Convert.ToString(Console.ReadLine());
                Console.Write("\r\nSpecialism Grade: " + SpecialismGrade + "\n");
            }
            else
            {
                SpecialismGrade = "N";
                Console.Write("\r\nSpecialism Grade: " + SpecialismGrade + "\n");
            }

            //Industry Placement Question
            Console.WriteLine("\r\nPlease select an Industry Placement Status: \n");
            Console.WriteLine("\r\n1: Completed");
            Console.WriteLine("\r\n2: Completed with Special Consideration:");
            Console.WriteLine("\r\n3: Not Completed:");

            while (!int.TryParse(Console.ReadLine(), out IndustryPlacementStatus))
            {
                Console.Write("This is not valid input. Please enter an integer value: ");
            }

            if (IndustryPlacementStatus == 1)
            {
                IndustryPlacementStatus = 1;
            }
            else if (IndustryPlacementStatus == 2)
            {
                IndustryPlacementStatus = 2;
            }
            else if (IndustryPlacementStatus == 3)
            {
                IndustryPlacementStatus = 3;
            }


            Console.Write("\r\nHow many registrations with the parameters provided would you like to create?: \n");
            //NoOfRegistrations = Convert.ToString(Console.ReadLine());
            while (!double.TryParse(Console.ReadLine(), out NoOfRegistrations))
            {
                Console.Write("This is not valid input. Please enter an integer value: ");
            }
            Console.WriteLine("You are creating " + NoOfRegistrations + " registrations");

            CreateRegistrations.CreateRegistrationsParameterised(CoreGrade, SpecialismGrade, RegistrationYear, TLevelChosen, Provider, NoOfRegistrations, IndustryPlacementStatus, MathsStatus, EnglishStatus);
        }
    }
}
