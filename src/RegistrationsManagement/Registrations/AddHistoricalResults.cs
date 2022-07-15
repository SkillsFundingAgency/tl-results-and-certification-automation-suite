using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistrationsManagement.Registrations
{
    internal class AddHistoricalResults
    {
        private static string ConnectionString = Constants.ConnectionString;
        public static string CoreSummer2021 = "";
        public static string CoreAutumn2021 = "";
        public static string CoreSummer2022 = "";
        public static string SpecialismSummer2022 = "";
        public static string CoreGrade = "";
        public static string ULN = "";
        public static string _CoreSummer2021Exists = "";
        public static string _CoreAutumn2021Exists = "";
        public static string _CoreSummer2022Exists = "";
        public static string _SpecialismSummer2022Exists = "";
        public static string Grade = "";

        public static void AddResults()
        {
            Console.Clear();
            // Display title for the create Add Historical Results.
            Console.WriteLine("\r");
            Console.WriteLine("Add Historical Results\r");
            Console.WriteLine("----------------------\n");

            Console.WriteLine("Please enter the ULN for your registration: ");
            ULN = Convert.ToString(Console.ReadLine());
            Console.WriteLine();

            string _isWithdrawn = CheckRegistrationWithdrawn(ULN);

            if (_isWithdrawn == "Y")
            {
                Console.WriteLine("This registration is withdrawn so no grades can be added \n");
                Console.WriteLine("Press Enter key to display main menu");
                Console.ReadLine();
                Console.Clear();
                DisplayMenu.DisplayMenu1();
            }

            _CoreSummer2021Exists = CheckCoreGradeExists(ULN, "1");

            if (_CoreSummer2021Exists != "0")
            {
                Console.WriteLine();
                Console.WriteLine("WARNING: A core result already exists for Summer 2021 so you will not be able to enter a result");
            }
            else
            {
                Console.Write("Would you like to add a core result for Summer 2021?");

                CoreSummer2021 = Convert.ToString(Console.ReadLine());

                while ((CoreSummer2021 != "Y" && CoreSummer2021 != "N"))
                {
                    Console.WriteLine("\r\nWould you like to add a core result for Summer 2021? \n");

                    CoreSummer2021 = Convert.ToString(Console.ReadLine());
                }

                if (CoreSummer2021 == "Y")
                {
                    PrintCoreGradesMenu();
                    CoreGrade = Convert.ToString(Console.ReadLine());
                    Console.Write("\r\nYou are setting the core grade for Summer 2021 to: " + CoreGrade + "\n");

                    CreatePathwayResult(CoreGrade, "1");
                    Console.WriteLine("Grade: " + CoreGrade + " has been added for Summer 2021");
                }
            }

            _CoreAutumn2021Exists = CheckCoreGradeExists(ULN, "2");

            if (_CoreAutumn2021Exists != "0")
            {
                Console.WriteLine();
                Console.WriteLine("WARNING: A core result already exists for Autumn 2021 so you will not be able to enter a result");
            }
            else
            {
                Console.Write("Would you like to add a core result for Autumn 2021?");

                CoreAutumn2021 = Convert.ToString(Console.ReadLine());

                while ((CoreAutumn2021 != "Y" && CoreAutumn2021 != "N"))
                {
                    Console.WriteLine("\r\nWould you like to add a core result for Autumn 2021? \n");
                    CoreAutumn2021 = Convert.ToString(Console.ReadLine());
                }

                if (CoreAutumn2021 == "Y")
                {
                    PrintCoreGradesMenu();
                    CoreGrade = Convert.ToString(Console.ReadLine());
                    Console.Write("\r\nYou are setting the core grade for Autumn 2021 to: " + CoreGrade + "\n");

                    CreatePathwayResult(CoreGrade, "2");
                    Console.WriteLine("Grade: " + CoreGrade + " has been added for Autumn 2021");
                }
            }


            _CoreSummer2022Exists = CheckCoreGradeExists(ULN, "3");

            if (_CoreSummer2022Exists != "0")
            {
                Console.WriteLine();
                Console.WriteLine("WARNING: A core result already exists for Summer 2022 so you will not be able to enter a result");
            }
            else
            {
                Console.Write("Would you like to add a core result for Summer 2022?");

                CoreSummer2021 = Convert.ToString(Console.ReadLine());

                while ((CoreAutumn2021 != "Y" && CoreAutumn2021 != "N"))
                {
                    Console.WriteLine("\r\nWould you like to add a core result for Summer 2022? \n");
                    CoreAutumn2021 = Convert.ToString(Console.ReadLine());
                }

                if (CoreAutumn2021 == "Y")
                {
                    PrintCoreGradesMenu();
                    CoreGrade = Convert.ToString(Console.ReadLine());
                    Console.Write("\r\nYou are setting the core grade for Summer 2022 to: " + CoreGrade + "\n");

                    CreatePathwayResult(CoreGrade, "3");
                    Console.WriteLine("Grade: " + CoreGrade + " has been added for Summer 2022");
                }
                else
                {
                    Console.WriteLine("No grade entered for Summer 2022 core result");
                }
            }


            _SpecialismSummer2022Exists = CheckSpecialismGradeExists(ULN, "7");

            if (_SpecialismSummer2022Exists != "0")
            {

                Console.WriteLine();
                Console.WriteLine("WARNING: A specialism result already exists for Summer 2022 so you will not be able to enter a result");
            }
            else
            {
                Console.Write("Would you like to add a specialism result for Summer 2022?");

                SpecialismSummer2022 = Convert.ToString(Console.ReadLine());

                while ((SpecialismSummer2022 != "Y" && SpecialismSummer2022 != "N"))
                {
                    Console.WriteLine("\r\nWould you like to add a specialism result for Summer 2022? \n");
                    SpecialismSummer2022 = Convert.ToString(Console.ReadLine());
                }

                if (SpecialismSummer2022 == "Y")
                {
                    string SpecialismExists = CheckIfASpecialismExists();

                    if (SpecialismExists == "Y")
                    {
                        PrintSpecialismGradesMenu();
                        CoreGrade = Convert.ToString(Console.ReadLine());
                        Console.Write("\r\nYou are setting the specialism grade for Summer 2022 to: " + CoreGrade + "\n");

                        CreateSpecialismResult(CoreGrade, "7");
                    }

                }
                else
                {
                    Console.WriteLine("No grade entered for Summer 2022 specialism");
                }
            }



            Console.WriteLine();
            Console.WriteLine("Please press Enter to return to the main menu");
            Console.ReadLine();
            Console.Clear();
            DisplayMenu.DisplayMenu1();


        }

        public static string CheckCoreGradeExists(string ULN, string AssessmentSeries)
        {
            var SQL = "select count(*) from TqRegistrationProfile TQRP, TqRegistrationPathway TQP, TqPathwayAssessment TQPA, TqPathwayResult TQR where TQP.TqRegistrationProfileId = TQRP.Id and TQP.Id = TQPA.TqRegistrationPathwayId and TQPA.Id = TQR.TqPathwayAssessmentId and TQRP.UniqueLearnerNumber = " + ULN + " and TQP.EndDate is null and TQPA.AssessmentSeriesId =" + AssessmentSeries;
            var Count = SqlDatabaseConncetionHelper.ReadDataFromDataBase(SQL, ConnectionString);
            String Count1 = Convert.ToString(Count[0][0]);
            return Count1;

        }

        public static string CheckSpecialismGradeExists(string ULN, string AssessmentSeries)
        {
            var SQL = "select count(*) from TqRegistrationProfile TQRP, TqRegistrationPathway TQP, TqRegistrationSpecialism TQRS, TqSpecialismAssessment TQSA,  TqSpecialismResult TQSR where TQP.TqRegistrationProfileId = TQRP.Id and TQP.Id = TQRS.TqRegistrationPathwayId and TQRS.Id = TQSA.TqRegistrationSpecialismId and TQSA.Id = TQSR.TqSpecialismAssessmentId and TQRP.UniqueLearnerNumber = " + ULN + "and TQP.EndDate is null and TQSA.AssessmentSeriesId = " + AssessmentSeries;
            var Count = SqlDatabaseConncetionHelper.ReadDataFromDataBase(SQL, ConnectionString);
            String Count1 = Convert.ToString(Count[0][0]);
            return Count1;

        }

        public static void CreatePathwayResult(string Grade, string AssessmentSeriesID)
        {
            string CoreGrade = "";
            if (Grade == "A*") { CoreGrade = "1"; }
            else if (Grade == "A") { CoreGrade = "2"; }
            else if (Grade == "B") { CoreGrade = "3"; }
            else if (Grade == "C") { CoreGrade = "4"; }
            else if (Grade == "D") { CoreGrade = "5"; }
            else if (Grade == "E") { CoreGrade = "6"; }
            else if (Grade == "U") { CoreGrade = "7"; }

            string ProfileID = GetRegProfileID(ULN);
            string PathwayID = GetRegPathwayID(ProfileID);
            String PathwayAssessmentID = CreateCorePathwayAssessment(PathwayID, AssessmentSeriesID);
            CreateCoreResult(PathwayAssessmentID, CoreGrade);

        }

        public static string CheckIfASpecialismExists()
        {
            string ProfileID = GetRegProfileID(ULN);
            string PathwayID = GetRegPathwayID(ProfileID);
            string RegistrationSpecialismID = GetRegistrationSpecialismID(PathwayID);
            String Exists = "";

            if (RegistrationSpecialismID == "0")
            {
                Console.WriteLine("Sorry a specialism grade can't be added because a specialism has not been added to this registration");
                Exists = "N";
                return Exists;
            }
            else
            {
                Exists = "Y";
                return Exists;
            }
        }

        #region SpecialismAssessment

        public static void CreateSpecialismResult(string Grade, string AssessmentSeriesID)
        {
            string SpecialismGrade = "";
            if (Grade == "D") { SpecialismGrade = "10"; }
            else if (Grade == "M") { SpecialismGrade = "11"; }
            else if (Grade == "P") { SpecialismGrade = "12"; }
            else if (Grade == "U") { SpecialismGrade = "13"; }

            string ProfileID = GetRegProfileID(ULN);
            string PathwayID = GetRegPathwayID(ProfileID);
            string RegistrationSpecialismID = GetRegistrationSpecialismID(PathwayID);


            String TQSpecialismAssessmentID = InsertSpecialismAssessment(RegistrationSpecialismID, AssessmentSeriesID);
            InsertSpecialismAssessmentResult(TQSpecialismAssessmentID, SpecialismGrade);
            Console.WriteLine("Grade: " + CoreGrade + " has been added for the specialism result for Summer 2022");


        }

        private static string GetRegistrationSpecialismID(string PathwayID)
        {
            var getSpecialismId1 = "select count(*) from TqRegistrationSpecialism where TqRegistrationPathwayId  = '" + PathwayID + "' and EndDate is NULL";
            var specialismId1 = SqlDatabaseConncetionHelper.ReadDataFromDataBase(getSpecialismId1, ConnectionString); 
            SqlDatabaseConncetionHelper.ExecuteSqlCommand(getSpecialismId1, ConnectionString);

            if (Convert.ToString(specialismId1[0][0]) == "0")
            {
                return Convert.ToString(specialismId1[0][0]);
            }

            else
            {
                var getSpecialismId = "select top 1 id from TqRegistrationSpecialism where TqRegistrationPathwayId  = '" + PathwayID + "' and EndDate is NULL";
                var specialismId = SqlDatabaseConncetionHelper.ReadDataFromDataBase(getSpecialismId, ConnectionString);
                return Convert.ToString(specialismId[0][0]);
            }
        }

        private static string InsertSpecialismAssessment(string specialismId, string AssessmentSeries)
        {
            var createSpecialismAssessment = "Insert into TqSpecialismAssessment values('" + specialismId + "','" + AssessmentSeries + "',GETDATE(),Null,1,0,GETDATE(),'System',GETDATE(),'System')";
            var getSpecialismAssessmentId = "select top 1 id from TqSpecialismAssessment where TqRegistrationSpecialismId  = '" + specialismId + "' and AssessmentSeriesId = " + AssessmentSeries;
            SqlDatabaseConncetionHelper.ExecuteSqlCommand(createSpecialismAssessment, ConnectionString);
            var specialismAssessmentId = SqlDatabaseConncetionHelper.ReadDataFromDataBase(getSpecialismAssessmentId, ConnectionString);
            return Convert.ToString(specialismAssessmentId[0][0]);
        }

        private static void InsertSpecialismAssessmentResult(string specialismAssessmentId, string SpecialismGrade)
        {
            var createPathwayResult = "Insert into TqSpecialismResult values ('" + specialismAssessmentId + "','" + SpecialismGrade + "',GETDATE(),NULL,Null,1,0,GETDATE(),'SYSTEM',NULL,'SYSTEM')";
            SqlDatabaseConncetionHelper.ExecuteSqlCommand(createPathwayResult, ConnectionString);
        }

        #endregion SpecialismAssessment


        public static string GetRegProfileID(string ULN)
        {
            var getRegProfileId = "Select top 1 id from TqRegistrationProfile where UniqueLearnerNumber='" + ULN + "'";
            var profileId = SqlDatabaseConncetionHelper.ReadDataFromDataBase(getRegProfileId, ConnectionString);
            return (Convert.ToString(profileId[0][0]));
        }
        public static string GetRegPathwayID(string profileId)
        {
            var getRegPathwayId = "select top 1 id from TqRegistrationPathway where TqRegistrationProfileId = '" + profileId + "' and EndDate is NULL";
            var pathwayId = SqlDatabaseConncetionHelper.ReadDataFromDataBase(getRegPathwayId, ConnectionString);
            return (Convert.ToString(pathwayId[0][0]));
        }

        public static string CreateCorePathwayAssessment(string pathwayId, string AssessmentSeries)
        {
            var createPathwayAssessment = "Insert into TqPathwayAssessment values('" + pathwayId + "'," + AssessmentSeries + ",GETDATE(),NULL,1,0,GETDATE(),'System',Null,Null )";
            var getRegPathwayAssessId = "select top 1 id from TqPathwayAssessment where TqRegistrationPathwayId  = '" + pathwayId + "' and AssessmentSeriesID = '" + AssessmentSeries + "' and EndDate is NULL";
            SqlDatabaseConncetionHelper.ExecuteSqlCommand(createPathwayAssessment, ConnectionString);
            var regPathwayAssessmentId = SqlDatabaseConncetionHelper.ReadDataFromDataBase(getRegPathwayAssessId, ConnectionString);
            return Convert.ToString(regPathwayAssessmentId[0][0]);
        }

        public static void CreateCoreResult(string pathwayAssessmentId, string grade)
        {
            var createPathwayResult = "Insert into TqPathwayResult values('" + pathwayAssessmentId + "'," + grade + ",GETDATE(),NULL,Null,1,0,GETDATE(),'SYSTEM',NULL,'SYSTEM')";
            SqlDatabaseConncetionHelper.ExecuteSqlCommand(createPathwayResult, ConnectionString);
        }

        public static void PrintCoreGradesMenu()
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
        }

        public static void PrintSpecialismGradesMenu()
        {
            Console.WriteLine("Choose an option from the following list:");
            Console.WriteLine("\tD - Distinciton");
            Console.WriteLine("\tM - Merit");
            Console.WriteLine("\tP - Pass");
            Console.WriteLine("\tU - Unclassified");
            Console.Write("Please select an option: ");
        }

        public static string CheckRegistrationWithdrawn(string ULN)
        {
            //string ProfileID = GetRegProfileID(ULN);
            //string PathwayID = GetRegPathwayID(ProfileID);
            string Withdrawn = "";

            var GetWithdrawnStatus = "select count(*) from TqRegistrationProfile TQRP, TqRegistrationPathway TQPR where TQRP.id = TQPR.TqRegistrationProfileId and TQPR.EndDate is NULL and TQRP.UniqueLearnerNumber =" + ULN;
            var GetWithdrawnStatus1 = SqlDatabaseConncetionHelper.ReadDataFromDataBase(GetWithdrawnStatus, ConnectionString);

            if (Convert.ToString(GetWithdrawnStatus1[0][0]) == "0")
            {
                Withdrawn = "Y";
                return Withdrawn;
            }
            else
            {
                Withdrawn = "N";
                return Withdrawn;
            }
        }
    }
}