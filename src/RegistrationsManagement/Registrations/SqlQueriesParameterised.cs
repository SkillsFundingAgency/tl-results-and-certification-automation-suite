using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistrationsManagement.Registrations
{
    internal class SqlQueriesParameterised
    {
        
        private static string ConnectionString = Constants.ConnectionString;
        
        private const string UlnList = "select Id,UniqueLearnerNumber,Firstname,Lastname,DateofBirth from TqRegistrationProfile";
            
        public static void CreateRegistration(string uln, string CreateCoreGrade, string CreateSpecialismGrade, string Year, String TLEVEL, string Provider, int IPStatus, string MathsStatus, String EnglishStatus)
        {
            var profileId = CreateRegistrationProfile(uln, MathsStatus, EnglishStatus);

            string TQProviderID = "";
            string SpecialismID = "";

            //Work out which TQProviderID is required for the registration based on Provier and TLevel combination
            switch (TLEVEL)
            {
                case "8":
                    if (Provider == "A")
                    {
                        TQProviderID = GetTQProfileID("T Level in Health", "Barnsley College", "1");
                        SpecialismID = "28";
                    }
                    else
                    {
                        TQProviderID = GetTQProfileID("T Level in Health", "Dudley College of Technology", "1");
                        SpecialismID = "28";
                    }
                    break;
                case "9":
                    if (Provider == "A")
                    {
                        TQProviderID = GetTQProfileID("T Level in Healthcare Science", "Barnsley College", "1");
                        SpecialismID = "31";
                    }
                    else
                    {
                        TQProviderID = GetTQProfileID("T Level in Healthcare Science", "Dudley College of Technology", "1");
                        SpecialismID = "31";
                    }
                    break;
                case "5":
                    if (Provider == "A")
                    {
                        TQProviderID = GetTQProfileID("T Level in Digital Production, Design and Development", "Barnsley College", "1");
                        SpecialismID = "20";
                    }
                    else
                    {
                        TQProviderID = GetTQProfileID("T Level in Digital Production, Design and Development", "Dudley College of Technology", "1");
                        SpecialismID = "20";
                    }
                    break;
                case "7":
                    if (Provider == "A")
                    {
                        TQProviderID = GetTQProfileID("T Level in Digital Business Services", "Barnsley College", "1");
                        SpecialismID = "25";
                    }
                    else
                    {
                        TQProviderID = GetTQProfileID("T Level in Digital Business Services", "Dudley College of Technology", "1");
                        SpecialismID = "25";
                    }
                    break;
                case "6":
                    if (Provider == "A")
                    {
                        TQProviderID = GetTQProfileID("T Level in Digital Support Services", "Barnsley College", "1");
                        SpecialismID = "23";
                    }
                    else
                    {
                        TQProviderID = GetTQProfileID("T Level in Digital Support Services", "Dudley College of Technology", "1");
                        SpecialismID = "23";
                    }
                    break;
                case "1":
                    if (Provider == "A")
                    {
                        TQProviderID = GetTQProfileID("T Level in Design, Surveying and Planning for Construction", "Barnsley College", "2");
                        SpecialismID = "2";
                    }
                    else
                    {
                        TQProviderID = GetTQProfileID("T Level in Design, Surveying and Planning for Construction", "Dudley College of Technology", "2");
                        SpecialismID = "2";
                    }
                    break;
                case "4":
                    if (Provider == "A")
                    {
                        TQProviderID = GetTQProfileID("T Level in Education and Childcare", "Barnsley College", "1");
                        SpecialismID = "17";
                    }
                    else
                    {
                        TQProviderID = GetTQProfileID("T Level in Education and Childcare", "Dudley College of Technology", "1");
                        SpecialismID = "17";
                    }
                    break;
                case "10":
                    if (Provider == "A")
                    {
                        TQProviderID = GetTQProfileID("T Level in Science", "Barnsley College", "1");
                        SpecialismID = "32";
                    }
                    else
                    {
                        TQProviderID = GetTQProfileID("T Level in Science", "Dudley College of Technology", "1");
                        SpecialismID = "32";
                    }
                    break;
                case "2":
                    if (Provider == "A")
                    {
                        TQProviderID = GetTQProfileID("T Level in Onsite Construction", "Barnsley College", "3");
                        SpecialismID = "6";
                    }
                    else
                    {
                        TQProviderID = GetTQProfileID("T Level in Onsite Construction", "Bath College", "3");
                        SpecialismID = "6";
                    }
                    break;
            }

            //Create the Registration Pathway record using the TQProvider ID worked out above
            var pathwayId = CreateRegistrationPathway(profileId, Year, TQProviderID);
            
            //Create the specialism record for the registration
            var TQRegistrationspecialismId =  CreateRegSpecialism(pathwayId, SpecialismID);
            
            //Create the core assessment record
            var pathwayAssessmentId = CreatePathwayAssessment(pathwayId);

            //Create the core grade if the user stated they wanted a core grade adding
            if (CreateCoreGrade != "N")
            {
             CreatePathwayResult(pathwayAssessmentId, CreateCoreGrade);
            }

            //Create the specialism assessment record
            var SpecialismAssessmentID =  InsertSpecialismAssessment(TQRegistrationspecialismId);

            //Create the specialism grade if the user stated they wanted a specialism grade adding
            if (CreateSpecialismGrade != "N")
            {
                InsertSpecialismAssessmentResult(SpecialismAssessmentID, CreateSpecialismGrade);
            }

            //Create the industry placement record for the registration
            CreateIndustryPlacement(pathwayId, Convert.ToInt32(IPStatus));          

        }


        public static int CreateRegistrationProfile(string uln, string MathsStatus, String EnglishStatus)
        {
            //string MathsStatus = "Null";
            //string EnglishStatus = "Null";
            var createRegistrationProfile = "";
            if (MathsStatus == "4")
            {
                MathsStatus = "Null";
            }

            if (EnglishStatus == "4")
            {
                EnglishStatus = "Null";
            }

            if (MathsStatus == "Null")
            {
                if (EnglishStatus == "Null")
                {
                    createRegistrationProfile = "Insert into TqRegistrationProfile values(" + uln + ", 'Db FirstName','Db LastName','2001-01-01',Null,1,1,Null,0,Null,Null,GETDATE(),'System', GETDATE(),'System')";
                }
                else
                {
                    createRegistrationProfile = "Insert into TqRegistrationProfile values(" + uln + ", 'Db FirstName','Db LastName','2001-01-01',Null,1,1,Null,0,Null," + EnglishStatus + "3,GETDATE(),'System', GETDATE(),'System')";

                }
            }
            else if (EnglishStatus == "Null")
            {                
                    createRegistrationProfile = "Insert into TqRegistrationProfile values(" + uln + ", 'Db FirstName','Db LastName','2001-01-01',Null,1,1,Null,0," + MathsStatus + ",Null,GETDATE(),'System', GETDATE(),'System')";
            }
            else
            {
                    createRegistrationProfile = "Insert into TqRegistrationProfile values(" + uln + ", 'Db FirstName','Db LastName','2001-01-01',Null,1,1,Null,0," + MathsStatus + "," + EnglishStatus + ",GETDATE(),'System', GETDATE(),'System')";
            }
            


           // var createRegistrationProfile = "Insert into TqRegistrationProfile values(" + uln + ", 'Db FirstName','Db LastName','2001-01-01',Null,1,1,Null,0,3,3,GETDATE(),'System', GETDATE(),'System')";
            var getRegProfileId = "Select top 1 id from TqRegistrationProfile where UniqueLearnerNumber='" + uln + "'";
            SqlDatabaseConncetionHelper.ExecuteSqlCommand(createRegistrationProfile, ConnectionString);
            var profileId = SqlDatabaseConncetionHelper.ReadDataFromDataBase(getRegProfileId, ConnectionString);
            return (int)profileId.FirstOrDefault().FirstOrDefault();
        }
        public static int CreateRegistrationPathway(int profileId, string Year, string tqProviderId)
        {
            //var tqProviderId = Constants.TqProviderIdForLrs;
            var createRegPathway = "Insert into TqRegistrationPathway values('" + profileId + "', '" + tqProviderId + "','" + Year + "', GETDATE(),NULL,1,1,GETDATE(),'System',NULL,NULL)";
            var getRegPathwayId = "select top 1 id from TqRegistrationPathway where TqRegistrationProfileId = '" + profileId + "'";
            SqlDatabaseConncetionHelper.ExecuteSqlCommand(createRegPathway, ConnectionString);
            var pathwayId = SqlDatabaseConncetionHelper.ReadDataFromDataBase(getRegPathwayId, ConnectionString);
            return (int)pathwayId.FirstOrDefault().FirstOrDefault();
        }

        public static int CreateRegSpecialism(int pathwayId, string specialismID)
        {
            //var tlSpecialismId = Constants.TlSpecialismId;
            var createRegSpecialism = "Insert into TqRegistrationSpecialism values('" + pathwayId + "','" + specialismID + "',GETDATE(),NULL,1,0,GETDATE(),'System',Null,Null )";
            var getSpecialismId = "select top 1 id from TqRegistrationSpecialism where TqRegistrationPathwayId  = '" + pathwayId + "'";
            SqlDatabaseConncetionHelper.ExecuteSqlCommand(createRegSpecialism, ConnectionString);
            var specialismId = SqlDatabaseConncetionHelper.ReadDataFromDataBase(getSpecialismId, ConnectionString);
            return (int)specialismId.FirstOrDefault().FirstOrDefault();
        }

        public static int CreatePathwayAssessment(int pathwayId)
        {
            var createPathwayAssessment = "Insert into TqPathwayAssessment values('" + pathwayId + "',3,GETDATE(),NULL,1,0,GETDATE(),'System',Null,Null )";
            var getRegPathwayId = "select top 1 id from TqPathwayAssessment where TqRegistrationPathwayId  = '" + pathwayId + "'";
            SqlDatabaseConncetionHelper.ExecuteSqlCommand(createPathwayAssessment, ConnectionString);
            var regPathwayId = SqlDatabaseConncetionHelper.ReadDataFromDataBase(getRegPathwayId, ConnectionString);
            return (int)regPathwayId.FirstOrDefault().FirstOrDefault();
        }

        public static void CreatePathwayResult(int pathwayAssessmentId, string Grade)
        {
            string LookupGrade = "";
            if (Grade == "A*") { LookupGrade = "1"; }
            else if  (Grade == "A") { LookupGrade = "2"; }
            else if  (Grade == "B") { LookupGrade = "3"; }
            else if (Grade == "C") { LookupGrade = "4"; }
            else if (Grade == "D") { LookupGrade = "5"; }
            else if (Grade == "E") { LookupGrade = "6"; }
            else if (Grade == "U") { LookupGrade = "7"; }



            var createPathwayResult = "Insert into TqPathwayResult values('" + pathwayAssessmentId + "'," + LookupGrade + ",GETDATE(),NULL,Null,1,0,GETDATE(),'SYSTEM',NULL,'SYSTEM')";
            SqlDatabaseConncetionHelper.ExecuteSqlCommand(createPathwayResult, ConnectionString);
        }


        public static void CreateIndustryPlacement(int pathwayId, int status)
        {
            var createIpData = "Insert into IndustryPlacement values ('" + pathwayId + "','" + status + "',NULL,GETDATE(),'SYSTEM',GETDATE(),'SYSTEM')";
            SqlDatabaseConncetionHelper.ExecuteSqlCommand(createIpData, ConnectionString);
        }

        public static List<long> UlnListFromDb()
        {
            var result = SqlDatabaseConncetionHelper.GetFieldValue(UlnList, ConnectionString);
            return result.Select(x => (long)x[1]).ToList();
        }

        private static int InsertSpecialismAssessment(int specialismId)
        {
            var SpecialismAssessmentSeries = '7';
            var createSpecialismAssessment = "Insert into TqSpecialismAssessment values('" + specialismId + "','" + SpecialismAssessmentSeries + "',GETDATE(),Null,1,0,GETDATE(),'System',GETDATE(),'System')";
            var getSpecialismAssessmentId = "select top 1 id from TqSpecialismAssessment where TqRegistrationSpecialismId  = '" + specialismId + "'";
            SqlDatabaseConncetionHelper.ExecuteSqlCommand(createSpecialismAssessment, ConnectionString);
            var specialismAssessmentId = SqlDatabaseConncetionHelper.ReadDataFromDataBase(getSpecialismAssessmentId, ConnectionString);
            return (int)specialismAssessmentId.FirstOrDefault().FirstOrDefault();
        }

        private static void InsertSpecialismAssessmentResult(int specialismAssessmentId, string SpecialismGrade)
        {

            string LookupGrade = "";
            if (SpecialismGrade == "D") { LookupGrade = "10"; }
            else if (SpecialismGrade == "M") { LookupGrade = "11"; }
            else if (SpecialismGrade == "P") { LookupGrade = "12"; }
            else if (SpecialismGrade == "U") { LookupGrade = "13"; }

            var createPathwayResult = "Insert into TqSpecialismResult values ('" + specialismAssessmentId + "','" + LookupGrade + "',GETDATE(),NULL,Null,1,0,GETDATE(),'SYSTEM',NULL,'SYSTEM')";
            SqlDatabaseConncetionHelper.ExecuteSqlCommand(createPathwayResult, ConnectionString);
        }

        public static string GetTQProfileID(string TLevel, string Provider, string AwardingOrg)
        {

            var GetTQProviderID = "select top 1 TQP.Id from TqProvider TQP, TqAwardingOrganisation TQAO, TLProvider TLP, TlPathway TLPath where TQP.TlProviderId = TLP.Id and TQP.TqAwardingOrganisationId = TQAO.Id and TQAO.TlPathwayId = TLPath.Id and TLPath.TlevelTitle = '" + TLevel + "' and TLP.Name = '" + Provider + "' and TQAO.TlAwardingOrganisatonId = " + AwardingOrg;
            var TQProviderID = SqlDatabaseConncetionHelper.ReadDataFromDataBase(GetTQProviderID, ConnectionString);
            String TQProviderID1 = Convert.ToString(TQProviderID[0][0]);
            return TQProviderID1;
        }

        public static void CheckTQProviderTable (string TLevel, string Provider)
        {
            String ProviderName = "";
            String TLProviderID = "";
            string AO = "";

            if (Provider == "A")
            {
                ProviderName = "Barnsley College";
                var GetTLProviderIDSQL = "select id from tlprovider where Name = '" + ProviderName +"'";
                var ProviderID = SqlDatabaseConncetionHelper.ReadDataFromDataBase(GetTLProviderIDSQL, ConnectionString);
                TLProviderID = Convert.ToString(ProviderID[0][0]);
            }

            else
            {
                ProviderName = "Dudley College of Technology";
                var GetTLProviderIDSQL = "select id from tlprovider where Name = '" + ProviderName + "'"; 
                var ProviderID = SqlDatabaseConncetionHelper.ReadDataFromDataBase(GetTLProviderIDSQL, ConnectionString);
                TLProviderID = Convert.ToString(ProviderID[0][0]);
            }

            if (TLevel == "2")
            {
                AO = "3";
            }
            else if (TLevel == "1")
            {
                AO = "2";
            }
            else
            {
                AO = "1";
            }


            var TQProviderTableCountSQL = "select count(*) from TqProvider TQP, TqAwardingOrganisation TQAO, TLProvider TLP, TlPathway TLPath where TQP.TlProviderId = TLP.Id and TQP.TqAwardingOrganisationId = TQAO.Id and TQAO.TlPathwayId = TLPath.Id ";
            var TQProviderTableCount1SQL = TQProviderTableCountSQL + "and TLPath.ID =" + TLevel + " and TLP.Name = '" + ProviderName + "' and TQAO.TlAwardingOrganisatonId = " + AO;
            var Count = SqlDatabaseConncetionHelper.ReadDataFromDataBase(TQProviderTableCount1SQL, ConnectionString);
            string Count1 = Convert.ToString(Count[0][0]);

            if (Count1 == "0")
            {

                // var CreateTqAwardingOrganisation = "insert into TqAwardingOrganisation values (" + AO + "," + TLevel + ",1,1,GETDATE(),'System',NULL, NULL)";
                // var GetTQAwardingAOID = "select max(ID) from TqAwardingOrganisation";
                // SqlDatabaseConncetionHelper.ExecuteSqlCommand(CreateTqAwardingOrganisation, ConnectionString);
                var GetTQAwardingAOID = "select id from TqAwardingOrganisation where TlAwardingOrganisatonID = '" + AO + "' and TlPathwayId = '" + TLevel + "'";


                var TQAOID = SqlDatabaseConncetionHelper.ReadDataFromDataBase(GetTQAwardingAOID, ConnectionString);
                string TQAOID1 = Convert.ToString(TQAOID[0][0]);

                var CreateTQProviderRecord = "insert into tqprovider values (" + TQAOID1 + "," + TLProviderID + ",1, GETDATE(), 'System', NULL, NULL)";
                SqlDatabaseConncetionHelper.ExecuteSqlCommand(CreateTQProviderRecord, ConnectionString);
            }
        }


    }
}
