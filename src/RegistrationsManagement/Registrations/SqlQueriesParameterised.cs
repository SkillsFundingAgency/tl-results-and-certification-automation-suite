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

        //Test env DB Connection string
        private const string UlnList = "select Id,UniqueLearnerNumber,Firstname,Lastname,DateofBirth from TqRegistrationProfile";
        //Delete from Registration Tables
        private const string DeleteRegistrationSpecialism = "Delete rs from TqRegistrationSpecialism rs join TqRegistrationPathway rw ON rs.TqRegistrationPathwayId = rw.Id join TqRegistrationProfile rp on rw.TqRegistrationProfileId =rp.Id where UniqueLearnerNumber like '9%'";
        private const string DeleteRegistrationPathway = "Delete from TqRegistrationPathway where TqRegistrationProfileId In (select Id from TqRegistrationProfile where UniqueLearnerNumber like '9%')";
        private const string DeleteRegistrationProfile = "Delete from TqRegistrationProfile where UniqueLearnerNumber like '9%'";
        private const string DeleteAssessmentPathway = "Delete pa from TqPathwayAssessment pa join TqRegistrationPathway rw ON pa.TqRegistrationPathwayId = rw.Id join TqRegistrationProfile rp on rw.TqRegistrationProfileId =rp.Id where UniqueLearnerNumber like '9%'";
        private const string DeleteAssessmentSpecialism = "Delete sa from TqSpecialismAssessment sa join TqRegistrationSpecialism rs ON sa.TqRegistrationSpecialismId = rs.Id join TqRegistrationPathway rp on  rs.TqRegistrationPathwayId=rp.Id join TqRegistrationProfile tr on  rp.TqRegistrationProfileId =tr.Id where UniqueLearnerNumber like '9%'";
        private const string DeletePathwayResults = "Delete pr from TqPathwayResult pr join TqPathwayAssessment pa on pr.TqPathwayAssessmentId = pa.Id join TqRegistrationPathway rw ON pa.TqRegistrationPathwayId = rw.Id join TqRegistrationProfile rp on rw.TqRegistrationProfileId =rp.Id where UniqueLearnerNumber like '9%'";
        private const string DeleteAssessmentResult = "Delete sr from TqSpecialismResult sr join TqSpecialismAssessment sa on sr.TqSpecialismAssessmentId = sa.Id join TqRegistrationSpecialism rs ON sa.TqRegistrationSpecialismId = rs.Id join TqRegistrationPathway rp on  rs.TqRegistrationPathwayId=rp.Id join TqRegistrationProfile tr on  rp.TqRegistrationProfileId =tr.Id where UniqueLearnerNumber like '9%'";
        private const string DeleteIpData = "Delete ip from IndustryPlacement ip join TqRegistrationPathway pw on ip.TqRegistrationPathwayId = pw.Id join TqRegistrationProfile rp on rp.Id=pw.TqRegistrationProfileId where rp.UniqueLearnerNumber like '9%'";
        private const string DeleteEmData = "Delete qa from QualificationAchieved qa join TqRegistrationProfile rp on qa.TqRegistrationProfileId = rp.Id where rp.UniquelearnerNumber like '9%'";

     
        public static void CreateRegistration(string uln, string CreateCoreGrade, string CreateSpecialismGrade, string Year, String TLEVEL, string Provider)
        {
            var profileId = CreateRegistrationProfileForLrsWithEM(uln);

            string TQProviderID = "";
            string SpecialismID = "";

            if (TLEVEL == "A")
            {
                if (Provider == "A") 
                {
                    TQProviderID =  GetTQProfileID("T Level in Health", "Barnsley College", "1");
                    SpecialismID = "28";
                }
                    //TQProviderID = "17787"; SpecialismID = "28";}

                else
                {
                    TQProviderID = GetTQProfileID("T Level in Health", "Dudley College of Technology", "1");
                    SpecialismID = "28";
                }
            
            }   
            else if (TLEVEL == "B")
            {
                if (Provider == "A")
                {
                    TQProviderID = GetTQProfileID("T Level in Healthcare Science", "Barnsley College", "1");
                    SpecialismID = "31";
                }
                //TQProviderID = "17787"; SpecialismID = "28";}

                else
                {
                    TQProviderID = GetTQProfileID("T Level in Healthcare Science", "Dudley College of Technology", "1");
                    SpecialismID = "31";
                }
            }


            else if (TLEVEL == "C")
            {
                if (Provider == "A")
                {
                    TQProviderID = GetTQProfileID("T Level in Digital Production, Design and Development", "Barnsley College", "1");
                    SpecialismID = "20";
                }
                //TQProviderID = "17787"; SpecialismID = "28";}

                else
                {
                    TQProviderID = GetTQProfileID("T Level in Digital Production, Design and Development", "Dudley College of Technology", "1");
                    SpecialismID = "20";
                }
            }

            else if (TLEVEL == "D")
            {
                if (Provider == "A")
                {
                    TQProviderID = GetTQProfileID("T Level in Digital Business Services", "Barnsley College", "1");
                    SpecialismID = "25";
                }
                //TQProviderID = "17787"; SpecialismID = "28";}

                else
                {
                    TQProviderID = GetTQProfileID("T Level in Digital Business Services", "Dudley College of Technology", "1");
                    SpecialismID = "25";
                }
            }
            else if (TLEVEL == "E")
            {
                if (Provider == "A")
                {
                    TQProviderID = GetTQProfileID("T Level in Digital Support Services", "Barnsley College", "1");
                    SpecialismID = "23";
                }
                //TQProviderID = "17787"; SpecialismID = "28";}

                else
                {
                    TQProviderID = GetTQProfileID("T Level in Digital Support Services", "Dudley College of Technology", "1");
                    SpecialismID = "23";
                }
            }
            else if (TLEVEL == "F")
            {
                if (Provider == "A")
                {
                    TQProviderID = GetTQProfileID("T Level in Design, Surveying and Planning for Construction", "Barnsley College", "1");
                    SpecialismID = "2";
                }
                //TQProviderID = "17787"; SpecialismID = "28";}

                else
                {
                    TQProviderID = GetTQProfileID("T Level in Design, Surveying and Planning for Construction", "Dudley College of Technology", "1");
                    SpecialismID = "2";
                }
            }
            else if (TLEVEL == "G")
            {
                if (Provider == "A")
                {
                    TQProviderID = GetTQProfileID("T Level in Education and Childcare", "Barnsley College", "1");
                    SpecialismID = "17";
                }
                //TQProviderID = "17787"; SpecialismID = "28";}

                else
                {
                    TQProviderID = GetTQProfileID("T Level in Education and Childcare", "Dudley College of Technology", "1");
                    SpecialismID = "17";
                }

            }
            else if (TLEVEL == "H")
            {
                if (Provider == "A")
                {
                    TQProviderID = GetTQProfileID("T Level in Science", "Barnsley College", "1");
                    SpecialismID = "32";
                }
                //TQProviderID = "17787"; SpecialismID = "28";}

                else
                {
                    TQProviderID = GetTQProfileID("T Level in Science", "Dudley College of Technology", "1");
                    SpecialismID = "32";
                }
            }
            else if (TLEVEL == "I")
            {
                if (Provider == "A")
                {
                    TQProviderID = GetTQProfileID("T Level in Onsite Construction", "Barnsley College", "3");
                    SpecialismID = "6";
                }
                //TQProviderID = "17787"; SpecialismID = "28";}

                else
                {
                    TQProviderID = GetTQProfileID("T Level in Onsite Construction", "Bath College", "3");
                    SpecialismID = "6";
                }
            }

          
            var pathwayId = CreateRegistrationPathwayForLrs(profileId, Year, TQProviderID);
            var TQRegistrationspecialismId =  CreateRegSpecialismForLrs(pathwayId, SpecialismID);
            
            var pathwayAssessmentId = CreatePathwayAssessment(pathwayId);

            if (CreateCoreGrade != "N")
            {
             CreatePathwayResult(pathwayAssessmentId, CreateCoreGrade);
            }

            var SpecialismAssessmentID =  InsertSpecialismAssessment(TQRegistrationspecialismId);

            if (CreateSpecialismGrade != "N")
            {
                InsertSpecialismAssessmentResult(SpecialismAssessmentID, CreateSpecialismGrade);
            }

            

        }
        public static int CreateRegistrationProfileForLrsWithEM(string uln)
        {
            var createRegistrationProfile = "Insert into TqRegistrationProfile values(" + uln + ", 'Db FirstName','Db LastName','2001-01-01',Null,1,1,Null,0,3,3,GETDATE(),'System', GETDATE(),'System')";
            var getRegProfileId = "Select top 1 id from TqRegistrationProfile where UniqueLearnerNumber='" + uln + "'";
            SqlDatabaseConncetionHelper.ExecuteSqlCommand(createRegistrationProfile, ConnectionString);
            var profileId = SqlDatabaseConncetionHelper.ReadDataFromDataBase(getRegProfileId, ConnectionString);
            return (int)profileId.FirstOrDefault().FirstOrDefault();
        }
        public static int CreateRegistrationPathwayForLrs(int profileId, string Year, string tqProviderId)
        {
            //var tqProviderId = Constants.TqProviderIdForLrs;
            var createRegPathway = "Insert into TqRegistrationPathway values('" + profileId + "', '" + tqProviderId + "','" + Year + "', GETDATE(),NULL,1,1,GETDATE(),'System',NULL,NULL)";
            var getRegPathwayId = "select top 1 id from TqRegistrationPathway where TqRegistrationProfileId = '" + profileId + "'";
            SqlDatabaseConncetionHelper.ExecuteSqlCommand(createRegPathway, ConnectionString);
            var pathwayId = SqlDatabaseConncetionHelper.ReadDataFromDataBase(getRegPathwayId, ConnectionString);
            return (int)pathwayId.FirstOrDefault().FirstOrDefault();
        }

        public static int CreateRegSpecialismForLrs(int pathwayId, string specialismID)
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

        public static void CreateQualificationAcheivedForLrs(int profileId)
        {
            var createQualificationAcheived = "Insert into QualificationAchieved values ('" + profileId + "',38,8,1,GETDATE(),'SYSTEM',GETDATE(),'SYSTEM')";
            SqlDatabaseConncetionHelper.ExecuteSqlCommand(createQualificationAcheived, ConnectionString);

            var createQualificationAcheived1 = "Insert into QualificationAchieved values ('" + profileId + "',69,8,1,GETDATE(),'SYSTEM',GETDATE(),'SYSTEM')";
            SqlDatabaseConncetionHelper.ExecuteSqlCommand(createQualificationAcheived1, ConnectionString);
        }

        public static void CreateIndustryPlacement(int pathwayId, int status)
        {
            var createIpData = "Insert into IndustryPlacement values ('" + pathwayId + "','" + status + "',GETDATE(),'SYSTEM',GETDATE(),'SYSTEM')";
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


    }
}
