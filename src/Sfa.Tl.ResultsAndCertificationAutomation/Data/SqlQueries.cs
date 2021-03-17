using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.TestSupport;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Data
{
    public class SqlQueries
    {
        private static readonly string ConnectionString = WebDriverFactory.Config["DBConnectionString"];
        //Delete from Registration Tables
        private static readonly string UlnList = "select Id,UniqueLearnerNumber,Firstname,Lastname,DateofBirth from TqRegistrationProfile";
        private static readonly string DeleteRegistrationSpecialism = "Delete rs from TqRegistrationSpecialism rs join TqRegistrationPathway rw ON rs.TqRegistrationPathwayId = rw.Id join TqRegistrationProfile rp on rw.TqRegistrationProfileId =rp.Id where UniqueLearnerNumber like '99%'";
        private static readonly string DeleteRegistrationPathway = "Delete from TqRegistrationPathway where TqRegistrationProfileId In (select Id from TqRegistrationProfile where UniqueLearnerNumber like '99%')";
        private static readonly string DeleteRegistrationProfile = "Delete from TqRegistrationProfile where UniqueLearnerNumber like '99%'";
        private static readonly string DeleteAssessmentPathway = "Delete pa from TqPathwayAssessment pa join TqRegistrationPathway rw ON pa.TqRegistrationPathwayId = rw.Id join TqRegistrationProfile rp on rw.TqRegistrationProfileId =rp.Id where UniqueLearnerNumber like '99%'";
        private static readonly string DeleteAssessmentSpecialism = "Delete sa from TqSpecialismAssessment sa join TqRegistrationSpecialism rs ON sa.TqRegistrationSpecialismId = rs.Id join TqRegistrationPathway rp on  rs.TqRegistrationPathwayId=rp.Id join TqRegistrationProfile tr on  rp.TqRegistrationProfileId =tr.Id where UniqueLearnerNumber like '99%'";
        private static readonly string DeletePathwayResults = "Delete pr from TqPathwayResult pr join TqPathwayAssessment pa on pr.TqPathwayAssessmentId = pa.Id join TqRegistrationPathway rw ON pa.TqRegistrationPathwayId = rw.Id join TqRegistrationProfile rp on rw.TqRegistrationProfileId =rp.Id where UniqueLearnerNumber like '99%'";

        public static void DeleteFromRegistrationTables()
        {
            SqlDatabaseConncetionHelper.ExecuteDeleteSqlCommand(DeletePathwayResults, ConnectionString);
            SqlDatabaseConncetionHelper.ExecuteDeleteSqlCommand(DeleteAssessmentPathway, ConnectionString);
            SqlDatabaseConncetionHelper.ExecuteDeleteSqlCommand(DeleteAssessmentSpecialism, ConnectionString);
            SqlDatabaseConncetionHelper.ExecuteDeleteSqlCommand(DeleteRegistrationSpecialism, ConnectionString);
            SqlDatabaseConncetionHelper.ExecuteDeleteSqlCommand(DeleteRegistrationPathway, ConnectionString);
            SqlDatabaseConncetionHelper.ExecuteDeleteSqlCommand(DeleteRegistrationProfile, ConnectionString);
        }
        public static void DeleteFromAssessmentTables()
        {
            SqlDatabaseConncetionHelper.ExecuteDeleteSqlCommand(DeleteAssessmentPathway, ConnectionString);
            SqlDatabaseConncetionHelper.ExecuteDeleteSqlCommand(DeleteAssessmentSpecialism, ConnectionString);
        }

        public static void SeedScenarioData(string sqlFile)
        {
            string filepath = $"{AppDomain.CurrentDomain.BaseDirectory}Data\\{sqlFile}.sql";
            var sqlfileContent = File.ReadAllText(filepath);
            SqlDatabaseConncetionHelper.ExecuteSqlFile(sqlfileContent, ConnectionString);
        }
        public static List<long> UlnListFromDb()
        {
            var result = SqlDatabaseConncetionHelper.GetFieldValue(UlnList, ConnectionString);
            return result.Select(x => (long)x[1]).ToList();
        }

        public static List<long> GetListFromDb()
        {
            var result = SqlDatabaseConncetionHelper.GetFieldValue(UlnList, ConnectionString);
            var id = result[0].GetValue(0) as string;
            var uln = result[0].GetValue(1) as string;
            var fName = result[0].GetValue(2) as string;
            var lName = result[0].GetValue(3) as string;
            return new List<long>();
        }

        public static void DeleteRegistrationFromTables(string uln)
        {
            string DeletePathwayResults = "Delete pr from TqPathwayResult pr join TqPathwayAssessment pa on pr.TqPathwayAssessmentId = pa.Id join TqRegistrationPathway rw ON pa.TqRegistrationPathwayId = rw.Id join TqRegistrationProfile rp on rw.TqRegistrationProfileId = rp.Id where UniqueLearnerNumber = '" + uln + "'";
            string DeleteRegSpecialism = "Delete rs from TqRegistrationSpecialism rs join TqRegistrationPathway rw ON rs.TqRegistrationPathwayId = rw.Id join TqRegistrationProfile rp on rw.TqRegistrationProfileId =rp.Id where UniqueLearnerNumber = '" + uln + "'";
            string DeleteRegPathway = "Delete from TqRegistrationPathway where TqRegistrationProfileId In (select Id from TqRegistrationProfile where UniqueLearnerNumber= '" + uln + "')";
            string DeleteRegProfile = "Delete from TqRegistrationProfile where UniqueLearnerNumber = '" + uln + "'";
            string DeleteAssPathway = "Delete pa from TqPathwayAssessment pa join TqRegistrationPathway rw ON pa.TqRegistrationPathwayId = rw.Id join TqRegistrationProfile rp on rw.TqRegistrationProfileId =rp.Id where UniqueLearnerNumber= '" + uln + "'";
            string DeleteAssSpecialism = "Delete sa from TqSpecialismAssessment sa join TqRegistrationSpecialism rs ON sa.TqRegistrationSpecialismId = rs.Id join TqRegistrationPathway rp on  rs.TqRegistrationPathwayId=rp.Id join TqRegistrationProfile tr on  rp.TqRegistrationProfileId =tr.Id where UniqueLearnerNumber= '" + uln + "'";
            SqlDatabaseConncetionHelper.ExecuteDeleteSqlCommand(DeletePathwayResults, ConnectionString);
            SqlDatabaseConncetionHelper.ExecuteDeleteSqlCommand(DeleteAssPathway, ConnectionString);
            SqlDatabaseConncetionHelper.ExecuteDeleteSqlCommand(DeleteAssSpecialism, ConnectionString);
            SqlDatabaseConncetionHelper.ExecuteDeleteSqlCommand(DeleteRegSpecialism, ConnectionString);
            SqlDatabaseConncetionHelper.ExecuteDeleteSqlCommand(DeleteRegPathway, ConnectionString);
            SqlDatabaseConncetionHelper.ExecuteDeleteSqlCommand(DeleteRegProfile, ConnectionString);
        }

        public static int CreateRegistrationProfile(string uln)
        {
            string CreateRegistrationProfile = "Insert into TqRegistrationProfile values(" + uln + ", 'Db FirstName','Db LastName','2001-01-01',Null,Null,Null,Null,Null,GETDATE(),'System', GETDATE(),'System')";
            string GetRegProfileId = "Select top 1 id from TqRegistrationProfile where UniqueLearnerNumber='"+ uln + "'";
            SqlDatabaseConncetionHelper.ExecuteSqlCommand(CreateRegistrationProfile, ConnectionString);
            var profileId = SqlDatabaseConncetionHelper.ReadDataFromDataBase(GetRegProfileId, ConnectionString);
            return (int)profileId.FirstOrDefault().FirstOrDefault();
        }
        public static int CreateRegistrationPathway(int profileId)
        {
            var tqProviderId = Constants.TqProviderId;
            string CreateRegPathway = "Insert into TqRegistrationPathway values('"+ profileId +"', '" + tqProviderId + "','2020', GETDATE(),NULL,1,1,GETDATE(),'System',NULL,NULL)";
            string GetRegPathwayId = "select top 1 id from TqRegistrationPathway where TqRegistrationProfileId = '"+ profileId +"'";
            SqlDatabaseConncetionHelper.ExecuteSqlCommand(CreateRegPathway, ConnectionString);
            var pathwayId = SqlDatabaseConncetionHelper.ReadDataFromDataBase(GetRegPathwayId, ConnectionString);
            return (int)pathwayId.FirstOrDefault().FirstOrDefault();
        }
        public static int CreateRegSpecialism(int pathwayId)
        {
            var tlSpecialismId = Constants.TlSpecialismId;
            string CreateRegSpecialism = "Insert into TqRegistrationSpecialism values('" + pathwayId + "','" + tlSpecialismId + "',GETDATE(),NULL,1,0,GETDATE(),'System',Null,Null )";
            string GetSpecialismId = "select top 1 id from TqRegistrationSpecialism where TqRegistrationPathwayId  = '" + pathwayId + "'";
            SqlDatabaseConncetionHelper.ExecuteSqlCommand(CreateRegSpecialism, ConnectionString);
            var specialismId = SqlDatabaseConncetionHelper.ReadDataFromDataBase(GetSpecialismId, ConnectionString);
            return (int)specialismId.FirstOrDefault().FirstOrDefault();
        }
        public static int CreatePathwayAssessment(int pathwayId)
        {
            string CreatePathwayAssessment = "Insert into TqPathwayAssessment values('" + pathwayId + "',1,GETDATE(),NULL,1,0,GETDATE(),'System',Null,Null )";
            string GetRegPathwayId = "select top 1 id from TqPathwayAssessment where TqRegistrationPathwayId  = '" + pathwayId + "'";
            SqlDatabaseConncetionHelper.ExecuteSqlCommand(CreatePathwayAssessment, ConnectionString);
            var regPathwayId = SqlDatabaseConncetionHelper.ReadDataFromDataBase(GetRegPathwayId, ConnectionString);
            return (int)regPathwayId.FirstOrDefault().FirstOrDefault();
        }
        public static void CreatePathwayResult(int pathwayAssessmentId)
        {
            string CreatePathwayResult = "Insert into TqPathwayResult values ('" + pathwayAssessmentId + "',2,GETDATE(),NULL,1,0,GETDATE(),'SYSTEM',NULL,'SYSTEM')";
            SqlDatabaseConncetionHelper.ExecuteSqlCommand(CreatePathwayResult, ConnectionString);
        }
        public static int CreateRegistrationProfileForLrs(string uln)
        {
            string CreateRegistrationProfile = "Insert into TqRegistrationProfile values(" + uln + ", 'Db FirstName','Db LastName','2001-01-01',Null,1,1,0,0,GETDATE(),'System', GETDATE(),'System')";
            string GetRegProfileId = "Select top 1 id from TqRegistrationProfile where UniqueLearnerNumber='" + uln + "'";
            SqlDatabaseConncetionHelper.ExecuteSqlCommand(CreateRegistrationProfile, ConnectionString);
            var profileId = SqlDatabaseConncetionHelper.ReadDataFromDataBase(GetRegProfileId, ConnectionString);
            return (int)profileId.FirstOrDefault().FirstOrDefault();
        }
        public static int CreateRegistrationPathwayForLrs(int profileId)
        {
            var tqProviderId = Constants.TqProviderIdForLrs;
            string CreateRegPathway = "Insert into TqRegistrationPathway values('" + profileId + "', '" + tqProviderId + "','2020', GETDATE(),NULL,1,1,GETDATE(),'System',NULL,NULL)";
            string GetRegPathwayId = "select top 1 id from TqRegistrationPathway where TqRegistrationProfileId = '" + profileId + "'";
            SqlDatabaseConncetionHelper.ExecuteSqlCommand(CreateRegPathway, ConnectionString);
            var pathwayId = SqlDatabaseConncetionHelper.ReadDataFromDataBase(GetRegPathwayId, ConnectionString);
            return (int)pathwayId.FirstOrDefault().FirstOrDefault();
        }
        public static void CreateQualificationAcheivedForLrs(int profileId)
        {
            string CreateQualificationAcheived = "Insert into QualificationAchieved values ('" + profileId + "',510,3,1,GETDATE(),'SYSTEM',GETDATE(),'SYSTEM')";
            SqlDatabaseConncetionHelper.ExecuteSqlCommand(CreateQualificationAcheived, ConnectionString);
        }
        public static void CreateIndustryPlacement (int pathwayId, int status)
        {
            string CreateIpData = "Insert into IndustryPlacement values ('" + pathwayId + "','" + status + "',GETDATE(),'SYSTEM',GETDATE(),'SYSTEM')";
            SqlDatabaseConncetionHelper.ExecuteSqlCommand(CreateIpData, ConnectionString);
        }
        public static int CreateRegSpecialismForLrs(int pathwayId)
        {
            var tlSpecialismId = Constants.TlSpecialismId;
            string CreateRegSpecialism = "Insert into TqRegistrationSpecialism values('" + pathwayId + "','" + tlSpecialismId + "',GETDATE(),NULL,1,0,GETDATE(),'System',Null,Null )";
            string GetSpecialismId = "select top 1 id from TqRegistrationSpecialism where TqRegistrationPathwayId  = '" + pathwayId + "'";
            SqlDatabaseConncetionHelper.ExecuteSqlCommand(CreateRegSpecialism, ConnectionString);
            var specialismId = SqlDatabaseConncetionHelper.ReadDataFromDataBase(GetSpecialismId, ConnectionString);
            return (int)specialismId.FirstOrDefault().FirstOrDefault();
        }
        public static void UpdateRegWithdrawn(string uln)
        {
            string ModifyRegPathway = "Update TqRegistrationPathway set status=4, EndDate=GETDATE(),ModifiedOn=GETDATE(),ModifiedBy='SYSTEM' from TqRegistrationPathway rp join TqRegistrationProfile pr on rp.TqRegistrationProfileId = pr.Id where UniqueLearnerNumber = '" + uln + "'";
            SqlDatabaseConncetionHelper.UpdateSqlCommand(ModifyRegPathway, ConnectionString);
            string ModifyRegSpecialism = "Update TqRegistrationSpecialism set EndDate=GETDATE(),ModifiedOn=GETDATE(),ModifiedBy='SYSTEM' from TqRegistrationSpecialism rs join TqRegistrationPathway rp on rs.TqRegistrationPathwayId = rp.Id join TqRegistrationProfile pr on rp.TqRegistrationProfileId = pr.Id where UniqueLearnerNumber = '" + uln + "'";
            SqlDatabaseConncetionHelper.UpdateSqlCommand(ModifyRegSpecialism, ConnectionString);
            string ModifyPathwayAssessment = "Update TqPathwayAssessment set EndDate=GETDATE(),ModifiedOn=GETDATE(),ModifiedBy='SYSTEM' from TqPathwayAssessment pa join TqRegistrationPathway rp on rp.Id = pa.TqRegistrationPathwayId join TqRegistrationProfile pf on pf.id = rp.TqRegistrationProfileId where UniqueLearnerNumber = '" + uln + "'";
            SqlDatabaseConncetionHelper.UpdateSqlCommand(ModifyPathwayAssessment, ConnectionString);
            string ModifyPathwayResult = "update TqPathwayResult set EndDate=GETDATE(),ModifiedOn=GETDATE(),ModifiedBy='SYSTEM' from TqPathwayResult pr join TqPathwayAssessment pa on pr.TqPathwayAssessmentId = pa.Id join TqRegistrationPathway rp on rp.Id = pa.TqRegistrationPathwayId join TqRegistrationProfile pf on pf.id = rp.TqRegistrationProfileId where UniqueLearnerNumber = '" + uln + "'";
            SqlDatabaseConncetionHelper.UpdateSqlCommand(ModifyPathwayResult, ConnectionString);

        }


        public static string ReturnLastActiveGrade(string uln)
        {
            string ReturnLastActiveGrade = "select top 1 Tll.Value from TqRegistrationProfile TQPR, TqRegistrationPathway TQPA, TqPathwayAssessment TQPAS, TqPathwayResult TQR, TlLookup Tll where TQPR.ID = TQPA.TqRegistrationProfileId and TQPA.id = TQPAS.TqRegistrationPathwayId and TQPAS.ID = TQR.TqPathwayAssessmentId and TQR.TlLookupId = Tll.id and TQPR.uniquelearnernumber = " + uln + " and TQPA.EndDate is not Null order by TQR.Id desc";
            var Grade = SqlDatabaseConncetionHelper.ReadDataFromDataBase(ReturnLastActiveGrade, ConnectionString);
            return (string)Grade.FirstOrDefault().FirstOrDefault();
        }

        public static int ReturnLastActiveGradeCount(string uln)
        {
            string ReturnLastActiveGradeCount = "select count(Tll.Value) from TlLookup TLL, TqPathwayResult TQR where TQR.TlLookupId = Tll.id and TQR.tqpathwayassessmentid in (select id from TqPathwayAssessment where TqRegistrationPathwayId in  (select top 1 TQPA.ID from TqRegistrationProfile TQPR, TqRegistrationPathway TQPA where TQPR.ID = TQPA.TqRegistrationProfileId and TQPR.uniquelearnernumber = " + uln + "and TQPA.EndDate is not Null order by TQPA.EndDate desc)) and IsOptedin > 0   group by Tll.Value";
            var Records = SqlDatabaseConncetionHelper.ReadDataFromDataBase(ReturnLastActiveGradeCount, ConnectionString);
            int result = Convert.ToInt32(Records.Count);
            return result;
        }

        public static int VerifyRegistrationDeleted(string uln)
        {
            string ReturnRegistrationRecords = "select count(TQPR.Id) from TqRegistrationProfile TQPR, TqRegistrationPathway TQPA where TQPR.ID = TQPA.TqRegistrationProfileId and TQPR.uniquelearnernumber = " + uln;
            var Records = SqlDatabaseConncetionHelper.ReadDataFromDataBase(ReturnRegistrationRecords, ConnectionString);
            int result = Convert.ToInt32(Records[0][0]);
            return result;
        }

        public static int RetrievePathwayAssessmentID(string uln)
        {
            string PathwayAssessmentID = " select pa.Id from TqPathwayAssessment pa join TqRegistrationPathway rw ON pa.TqRegistrationPathwayId = rw.Id join TqRegistrationProfile rp on rw.TqRegistrationProfileId = rp.Id where UniqueLearnerNumber = " + uln;
            var PAID = SqlDatabaseConncetionHelper.ReadDataFromDataBase(PathwayAssessmentID, ConnectionString);
            int result = Convert.ToInt32(PAID[0][0]);
            return result;
        }
    }
}
