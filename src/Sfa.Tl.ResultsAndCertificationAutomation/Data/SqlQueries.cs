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
        private static readonly string DeleteRegistrationSpecialism = "Delete rs from TqRegistrationSpecialism rs join TqRegistrationPathway rw ON rs.TqRegistrationPathwayId = rw.Id join TqRegistrationProfile rp on rw.TqRegistrationProfileId =rp.Id where UniqueLearnerNumber like '9%'";
        private static readonly string DeleteRegistrationPathway = "Delete from TqRegistrationPathway where TqRegistrationProfileId In (select Id from TqRegistrationProfile where UniqueLearnerNumber like '9%')";
        private static readonly string DeleteRegistrationProfile = "Delete from TqRegistrationProfile where UniqueLearnerNumber like '9%'";
        private static readonly string DeleteAssessmentPathway = "Delete pa from TqPathwayAssessment pa join TqRegistrationPathway rw ON pa.TqRegistrationPathwayId = rw.Id join TqRegistrationProfile rp on rw.TqRegistrationProfileId =rp.Id where UniqueLearnerNumber like '9%'";
        private static readonly string DeleteAssessmentSpecialism = "Delete sa from TqSpecialismAssessment sa join TqRegistrationSpecialism rs ON sa.TqRegistrationSpecialismId = rs.Id join TqRegistrationPathway rp on  rs.TqRegistrationPathwayId=rp.Id join TqRegistrationProfile tr on  rp.TqRegistrationProfileId =tr.Id where UniqueLearnerNumber like '9%'";
        private static readonly string DeletePathwayResults = "Delete pr from TqPathwayResult pr join TqPathwayAssessment pa on pr.TqPathwayAssessmentId = pa.Id join TqRegistrationPathway rw ON pa.TqRegistrationPathwayId = rw.Id join TqRegistrationProfile rp on rw.TqRegistrationProfileId =rp.Id where UniqueLearnerNumber like '9%'";
        private static readonly string DeleteAssessmentResult = "Delete sr from TqSpecialismResult sr join TqSpecialismAssessment sa on sr.TqSpecialismAssessmentId = sa.Id join TqRegistrationSpecialism rs ON sa.TqRegistrationSpecialismId = rs.Id join TqRegistrationPathway rp on  rs.TqRegistrationPathwayId=rp.Id join TqRegistrationProfile tr on  rp.TqRegistrationProfileId =tr.Id where UniqueLearnerNumber like '9%'";
        private static readonly string DeleteIpData = "Delete ip from IndustryPlacement ip join TqRegistrationPathway pw on ip.TqRegistrationPathwayId = pw.Id join TqRegistrationProfile rp on rp.Id=pw.TqRegistrationProfileId where rp.UniqueLearnerNumber like '9%'";
        private static readonly string DeleteEMData = "Delete qa from QualificationAchieved qa join TqRegistrationProfile rp on qa.TqRegistrationProfileId = rp.Id where rp.UniquelearnerNumber like '9%'";

        public static void DeleteFromRegistrationTables()
        {
            SqlDatabaseConncetionHelper.ExecuteDeleteSqlCommand(DeleteIpData, ConnectionString);
            SqlDatabaseConncetionHelper.ExecuteDeleteSqlCommand(DeleteEMData, ConnectionString);
            SqlDatabaseConncetionHelper.ExecuteDeleteSqlCommand(DeleteAssessmentResult, ConnectionString);
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
        public static void CreateSpecialismAssessment(int specialismId)
        {
            var tlAssessmentSeriesId = Constants.TlAssessmentSeriesId;
            string CreateSpecialismAssessment = "Insert into TqSpecialismAssessment values('" + specialismId + "','" + tlAssessmentSeriesId + "',GETDATE(),Null,1,0,GETDATE(),'System',GETDATE(),'System')";
            SqlDatabaseConncetionHelper.ExecuteSqlCommand(CreateSpecialismAssessment, ConnectionString);
        }

        public static int CreateSecondPathwayAssessmentEntry(int pathwayId)
        {
            string CreatePathwayAssessment2 = "Insert into TqPathwayAssessment values('" + pathwayId + "',2,GETDATE(),NULL,1,0,GETDATE(),'System',Null,Null )";
            string GetRegPathwayId = "select top 1 id from TqPathwayAssessment where TqRegistrationPathwayId  = '" + pathwayId + "'";
            SqlDatabaseConncetionHelper.ExecuteSqlCommand(CreatePathwayAssessment2, ConnectionString);
            var regPathwayId = SqlDatabaseConncetionHelper.ReadDataFromDataBase(GetRegPathwayId, ConnectionString);
            return (int)regPathwayId.FirstOrDefault().FirstOrDefault();
        }

        public static void CreatePathwayResult(int pathwayAssessmentId)
        {
            string CreatePathwayResult = "Insert into TqPathwayResult values ('" + pathwayAssessmentId + "',2,GETDATE(),NULL,Null,1,0,GETDATE(),'SYSTEM',NULL,'SYSTEM')";
            SqlDatabaseConncetionHelper.ExecuteSqlCommand(CreatePathwayResult, ConnectionString);
        }
        public static int CreateRegistrationProfileForLrs(string uln)
        {
            string CreateRegistrationProfile = "Insert into TqRegistrationProfile values(" + uln + ", 'Db FirstName','Db LastName','2001-01-01',Null,0,Null,1,1,GETDATE(),'System', GETDATE(),'System')";
            string GetRegProfileId = "Select top 1 id from TqRegistrationProfile where UniqueLearnerNumber='" + uln + "'";
            SqlDatabaseConncetionHelper.ExecuteSqlCommand(CreateRegistrationProfile, ConnectionString);
            var profileId = SqlDatabaseConncetionHelper.ReadDataFromDataBase(GetRegProfileId, ConnectionString);
            return (int)profileId.FirstOrDefault().FirstOrDefault();
        }
        public static int CreateRegistrationProfileForLrsWithEM(string uln)
        {
            string CreateRegistrationProfile = "Insert into TqRegistrationProfile values(" + uln + ", 'Db FirstName','Db LastName','2001-01-01',Null,1,1,Null,0,GETDATE(),'System', GETDATE(),'System')";
            string GetRegProfileId = "Select top 1 id from TqRegistrationProfile where UniqueLearnerNumber='" + uln + "'";
            SqlDatabaseConncetionHelper.ExecuteSqlCommand(CreateRegistrationProfile, ConnectionString);
            var profileId = SqlDatabaseConncetionHelper.ReadDataFromDataBase(GetRegProfileId, ConnectionString);
            return (int)profileId.FirstOrDefault().FirstOrDefault();
        }
        public static int CreateRegistrationProfileForNonLrsWithEM(string uln)
        {
            string CreateRegistrationProfile = "Insert into TqRegistrationProfile values(" + uln + ", 'Db FirstName','Db LastName','2001-01-01',Null,Null,1,Null,1,GETDATE(),'System', GETDATE(),'System')";
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
        public static int CreateRegistrationPathwayForDudley(int profileId)
        {
            var tqProviderId = Constants.DudleyProviderIdForLrs;
            string CreateRegPathway = "Insert into TqRegistrationPathway values('" + profileId + "', '" + tqProviderId + "','2021', GETDATE(),NULL,1,1,GETDATE(),'System',NULL,NULL)";
            string GetRegPathwayId = "select top 1 id from TqRegistrationPathway where TqRegistrationProfileId = '" + profileId + "'";
            SqlDatabaseConncetionHelper.ExecuteSqlCommand(CreateRegPathway, ConnectionString);
            var pathwayId = SqlDatabaseConncetionHelper.ReadDataFromDataBase(GetRegPathwayId, ConnectionString);
            return (int)pathwayId.FirstOrDefault().FirstOrDefault();
        }
        public static void CreateQualificationAcheivedForLrs(int profileId)
        {
            string CreateQualificationAcheived = "Insert into QualificationAchieved values ('" + profileId + "',38,8,1,GETDATE(),'SYSTEM',GETDATE(),'SYSTEM')";
            SqlDatabaseConncetionHelper.ExecuteSqlCommand(CreateQualificationAcheived, ConnectionString);

            string CreateQualificationAcheived1 = "Insert into QualificationAchieved values ('" + profileId + "',69,8,1,GETDATE(),'SYSTEM',GETDATE(),'SYSTEM')";
            SqlDatabaseConncetionHelper.ExecuteSqlCommand(CreateQualificationAcheived1, ConnectionString);
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

        public static void CreateQualificationAcheivedForLrsMathsAEnglishNA(int profileId)
        {
            string CreateQualificationAcheived = "Insert into QualificationAchieved values ('" + profileId + "',38,8,1,GETDATE(),'SYSTEM',GETDATE(),'SYSTEM')";
            SqlDatabaseConncetionHelper.ExecuteSqlCommand(CreateQualificationAcheived, ConnectionString);

            string CreateQualificationAcheived1 = "Insert into QualificationAchieved values ('" + profileId + "',69,9,0,GETDATE(),'SYSTEM',GETDATE(),'SYSTEM')";
            SqlDatabaseConncetionHelper.ExecuteSqlCommand(CreateQualificationAcheived1, ConnectionString);
        }

        public static void CreateQualificationAcheivedForLrsMathsNAEnglishA(int profileId)
        {
            string CreateQualificationAcheived = "Insert into QualificationAchieved values ('" + profileId + "',38,9,0,GETDATE(),'SYSTEM',GETDATE(),'SYSTEM')";
            SqlDatabaseConncetionHelper.ExecuteSqlCommand(CreateQualificationAcheived, ConnectionString);

            string CreateQualificationAcheived1 = "Insert into QualificationAchieved values ('" + profileId + "',69,8,1,GETDATE(),'SYSTEM',GETDATE(),'SYSTEM')";
            SqlDatabaseConncetionHelper.ExecuteSqlCommand(CreateQualificationAcheived1, ConnectionString);
        }

        public static int CreateRegistrationProfileForLrsMathsAndEnglishNotAchieved(string uln)
        {
            string CreateRegistrationProfile = "Insert into TqRegistrationProfile values(" + uln + ", 'Db FirstName','Db LastName','2001-01-01',Null,1,0,0,0,GETDATE(),'System', GETDATE(),'System')";
            string GetRegProfileId = "Select top 1 id from TqRegistrationProfile where UniqueLearnerNumber='" + uln + "'";
            SqlDatabaseConncetionHelper.ExecuteSqlCommand(CreateRegistrationProfile, ConnectionString);
            var profileId = SqlDatabaseConncetionHelper.ReadDataFromDataBase(GetRegProfileId, ConnectionString);
            return (int)profileId.FirstOrDefault().FirstOrDefault();
        }

        public static int CreateRegistrationProfileForNonLRS(string uln)
        {
            string CreateRegistrationProfile = "Insert into TqRegistrationProfile values(" + uln + ", 'Db FirstName','Db LastName','2001-01-01',Null,Null,Null,Null,Null,GETDATE(),'System', GETDATE(),'System')";
            string GetRegProfileId = "Select top 1 id from TqRegistrationProfile where UniqueLearnerNumber='" + uln + "'";
            SqlDatabaseConncetionHelper.ExecuteSqlCommand(CreateRegistrationProfile, ConnectionString);
            var profileId = SqlDatabaseConncetionHelper.ReadDataFromDataBase(GetRegProfileId, ConnectionString);
            return (int)profileId.FirstOrDefault().FirstOrDefault();
        }

        public static int ReturnIPStatus(string uln)
        {
            string ReturnIPStatus = "select status from IndustryPlacement where TqRegistrationPathwayId in (  Select max (id) from TqRegistrationPathway where TqRegistrationProfileId in (select id from TqRegistrationProfile where uniquelearnernumber =" + uln +"))";
            var Records = SqlDatabaseConncetionHelper.ReadDataFromDataBase(ReturnIPStatus, ConnectionString);
            int result = Convert.ToInt32(Records[0][0]);
            return result;
        }

        public static int ReturnRegistrationProfileForLrs(string uln)
        {
            String GetRegProfileId = "Select top 1 id from TqRegistrationProfile where UniqueLearnerNumber='" + uln + "'";
            var profileId = SqlDatabaseConncetionHelper.ReadDataFromDataBase(GetRegProfileId, ConnectionString);
            return (int)profileId.FirstOrDefault().FirstOrDefault();
        }

        public static int ReturnRegistrationPathwayForLrs(int profileId)
        {
            string GetRegPathwayId = "select top 1 id from TqRegistrationPathway where TqRegistrationProfileId = '" + profileId + "'";
            var pathwayId = SqlDatabaseConncetionHelper.ReadDataFromDataBase(GetRegPathwayId, ConnectionString);
            return (int)pathwayId.FirstOrDefault().FirstOrDefault();
        }

        public static void UpdateRegistrationProfileRecord(string SQL)
        {
            SqlDatabaseConncetionHelper.ExecuteSqlCommand(SQL, ConnectionString);
        }

        public static void CreateQualificationAcheivedForLrsSEND(int profileId)
        {
            string CreateQualificationAcheived = "Insert into QualificationAchieved values ('" + profileId + "',517,8,1,GETDATE(),'SYSTEM',GETDATE(),'SYSTEM')";
            SqlDatabaseConncetionHelper.ExecuteSqlCommand(CreateQualificationAcheived, ConnectionString);

            string CreateQualificationAcheived1 = "Insert into QualificationAchieved values ('" + profileId + "',596,8,1,GETDATE(),'SYSTEM',GETDATE(),'SYSTEM')";
            SqlDatabaseConncetionHelper.ExecuteSqlCommand(CreateQualificationAcheived1, ConnectionString);
        }

        public static int ReturnRegistrationProfileID(string uln)
        {
            string GetRegProfileId = "Select top 1 id from TqRegistrationProfile where UniqueLearnerNumber='" + uln + "'";
            var profileId = SqlDatabaseConncetionHelper.ReadDataFromDataBase(GetRegProfileId, ConnectionString);
            return (int)profileId.FirstOrDefault().FirstOrDefault();
        }
        public static void DeleteAddress()
        {
            string DeleteAddress = "Delete pa from TlProviderAddress pa join  TlProvider tp on pa.TlProviderId = tp.Id where tp.Name ='Barnsley College'";
            SqlDatabaseConncetionHelper.ExecuteDeleteSqlCommand(DeleteAddress, ConnectionString);
        }
        public static void InsertAddress()
        {
            string ProviderId = "Select Id from TlProvider where Name='Barnsley College'";
            var GetProviderId  = SqlDatabaseConncetionHelper.ReadDataFromDataBase(ProviderId, ConnectionString);
            int result = Convert.ToInt32(GetProviderId[0][0]);
            string InsertAddress = "Insert Into TlProviderAddress values ('"+ result +"','Department', 'BARNSLEY COLLEGE','CHURCH STREET',NULL,'BARNSLEY','S70 2AX',1,GETDATE(),'System',Null,Null)";
            SqlDatabaseConncetionHelper.ExecuteSqlCommand(InsertAddress, ConnectionString);
        }

        public static int CreateWithdrawnRegistrationPathwayRecord(int profileId)
        {
            var tqProviderId = Constants.TqProviderIdForLrs;
            string CreateRegPathway = "Insert into TqRegistrationPathway values('" + profileId + "', '" + tqProviderId + "','2020', GETDATE(),GETDATE(),4,1,GETDATE(),'System',NULL,NULL)";
            string GetRegPathwayId = "select top 1 id from TqRegistrationPathway where TqRegistrationProfileId = '" + profileId + "'";
            SqlDatabaseConncetionHelper.ExecuteSqlCommand(CreateRegPathway, ConnectionString);
            var pathwayId = SqlDatabaseConncetionHelper.ReadDataFromDataBase(GetRegPathwayId, ConnectionString);
            return (int)pathwayId.FirstOrDefault().FirstOrDefault();
        }

        public static int CreateRegistrationProfileForLrsCOMBINATION(string uln, string IsLearnerVerified, string isEMAchieved, string SendLearner, string isRCFeed)
        {
            string CreateRegistrationProfile = "Insert into TqRegistrationProfile values(" + uln + ", 'Db FirstName','Db LastName','2001-01-01',Null," + IsLearnerVerified + "," + isEMAchieved + "," + SendLearner + "," + isRCFeed + ",GETDATE(),'System', GETDATE(),'System')";
            Console.WriteLine(CreateRegistrationProfile);
            string GetRegProfileId = "Select top 1 id from TqRegistrationProfile where UniqueLearnerNumber='" + uln + "'";
            SqlDatabaseConncetionHelper.ExecuteSqlCommand(CreateRegistrationProfile, ConnectionString);
            var profileId = SqlDatabaseConncetionHelper.ReadDataFromDataBase(GetRegProfileId, ConnectionString);
            return (int)profileId.FirstOrDefault().FirstOrDefault();
        }

        public static int CreateRegistrationPathwayForLrsCOMBINATION(int profileId)
        {
            var tqProviderId = Constants.TqProviderIdForLrs;
            string CreateRegPathway = "Insert into TqRegistrationPathway values('" + profileId + "', '" + tqProviderId + "','2020', GETDATE(),GETDATE(),4,0,GETDATE(),'System',NULL,NULL)";
            string GetRegPathwayId = "select top 1 id from TqRegistrationPathway where TqRegistrationProfileId = '" + profileId + "'";
            SqlDatabaseConncetionHelper.ExecuteSqlCommand(CreateRegPathway, ConnectionString);
            var pathwayId = SqlDatabaseConncetionHelper.ReadDataFromDataBase(GetRegPathwayId, ConnectionString);
            return (int)pathwayId.FirstOrDefault().FirstOrDefault();
        }

        public static void CreateQualificationAcheivedForLrsMathsNAEnglishNA(int profileId)
        {
            string CreateQualificationAcheived = "Insert into QualificationAchieved values ('" + profileId + "',38,9,0,GETDATE(),'SYSTEM',GETDATE(),'SYSTEM')";
            SqlDatabaseConncetionHelper.ExecuteSqlCommand(CreateQualificationAcheived, ConnectionString);

            string CreateQualificationAcheived1 = "Insert into QualificationAchieved values ('" + profileId + "',69,9,1,GETDATE(),'SYSTEM',GETDATE(),'SYSTEM')";
            SqlDatabaseConncetionHelper.ExecuteSqlCommand(CreateQualificationAcheived1, ConnectionString);
        }

        public static void DeletePrintTableRecords(string uln)
        {
            string RecordCountSQL = "select count(*) from PrintCertificate where uln =" + uln;
            var RecordCount = SqlDatabaseConncetionHelper.ReadDataFromDataBase(RecordCountSQL, ConnectionString);
            int RecordCount1 = Convert.ToInt32(RecordCount[0][0]);
           
            if (RecordCount1 == 0)
            {
                Console.WriteLine("Do Nothing");
            }
            else
            {
                string RetrievePrintBatchItemID = "select top 1 printbatchitemid from PrintCertificate where uln =" + uln;
                var PrintBatchItemID = SqlDatabaseConncetionHelper.ReadDataFromDataBase(RetrievePrintBatchItemID, ConnectionString);
                string RetrieveBatchID = "Select top 1 batchID from PrintBatchItem where id in (select printbatchitemid from PrintCertificate where uln =" + uln + ")";
                var BatchID = SqlDatabaseConncetionHelper.ReadDataFromDataBase(RetrieveBatchID, ConnectionString);
                string DeletePrintCertificateRecord = "delete from PrintCertificate where ULN =" + uln;
                string DeletePrintBatchItemRecord = "delete from PrintBatchItem where id =" + PrintBatchItemID[0][0];
                string DeleteBatchRecord = "delete from batch where id =" + BatchID[0][0];
                SqlDatabaseConncetionHelper.ExecuteSqlCommand(DeletePrintCertificateRecord, ConnectionString);
                SqlDatabaseConncetionHelper.ExecuteSqlCommand(DeletePrintBatchItemRecord, ConnectionString);
                SqlDatabaseConncetionHelper.ExecuteSqlCommand(DeleteBatchRecord, ConnectionString);
            }
        }

        public static string CreateRegistrationAppealURL(string uln)
        {
            var profileId = SqlQueries.ReturnRegistrationProfileForLrs(uln);
            var pathwayId = SqlQueries.ReturnRegistrationPathwayForLrs(profileId);
            string RetrieveTqPathwayAssessmentID = "Select top 1 Id from TqPathwayAssessment where TqRegistrationPathwayId =" + pathwayId;
            var PathwayAssessmentID = SqlDatabaseConncetionHelper.ReadDataFromDataBase(RetrieveTqPathwayAssessmentID, ConnectionString);
            string URL = "https://test.manage-tlevel-results.tlevels.gov.uk/reviews-and-appeals-learner-status/" + profileId + "/" + PathwayAssessmentID[0][0];
            return URL;
        }

        public static string RetrieveResultUpdatedData(string uln)
        {
            var profileId = SqlQueries.ReturnRegistrationProfileForLrs(uln);
            var pathwayId = SqlQueries.ReturnRegistrationPathwayForLrs(profileId);
            string RetrieveTqPathwayAssessmentID = "Select top 1 Id from TqPathwayAssessment where TqRegistrationPathwayId =" + pathwayId;
            var PathwayAssessmentID = SqlDatabaseConncetionHelper.ReadDataFromDataBase(RetrieveTqPathwayAssessmentID, ConnectionString);
            string TqPathwayResultCreatedByValue = "select top 1 createdby from TqPathwayResult where TqPathwayAssessmentId =" + PathwayAssessmentID[0][0] + " order by id desc";
            var CreatedByValue = SqlDatabaseConncetionHelper.ReadDataFromDataBase(TqPathwayResultCreatedByValue, ConnectionString);
            string CreatedByValue1 = Convert.ToString(CreatedByValue[0][0]);
            return CreatedByValue1;
        }

        public static string RetrieveResultCreatedOnData(string uln)
        {
            var profileId = SqlQueries.ReturnRegistrationProfileForLrs(uln);
            var pathwayId = SqlQueries.ReturnRegistrationPathwayForLrs(profileId);
            string RetrieveTqPathwayAssessmentID = "Select top 1 Id from TqPathwayAssessment where TqRegistrationPathwayId =" + pathwayId;
            var PathwayAssessmentID = SqlDatabaseConncetionHelper.ReadDataFromDataBase(RetrieveTqPathwayAssessmentID, ConnectionString);
            string TqPathwayResultCreatedByValue = "select top 1 createdOn from TqPathwayResult where TqPathwayAssessmentId =" + PathwayAssessmentID[0][0] + " order by id desc";
            var CreatedOnValue = SqlDatabaseConncetionHelper.ReadDataFromDataBase(TqPathwayResultCreatedByValue, ConnectionString);
            string CreatedOnValue1 = Convert.ToString(CreatedOnValue[0][0]);
            return CreatedOnValue1;
        }
        

        public static int RetrieveResultStatus(string uln)
        {
            var profileId = SqlQueries.ReturnRegistrationProfileForLrs(uln);
            var pathwayId = SqlQueries.ReturnRegistrationPathwayForLrs(profileId);
            string RetrieveTqPathwayAssessmentID = "Select top 1 Id from TqPathwayAssessment where TqRegistrationPathwayId =" + pathwayId;
            var PathwayAssessmentID = SqlDatabaseConncetionHelper.ReadDataFromDataBase(RetrieveTqPathwayAssessmentID, ConnectionString);
            string TqPathwayResultStatusValue = "select top 1 prsstatus from TqPathwayResult where TqPathwayAssessmentId =" + PathwayAssessmentID[0][0] + " order by id desc";
            var resultStatusValue = SqlDatabaseConncetionHelper.ReadDataFromDataBase(TqPathwayResultStatusValue, ConnectionString);
            int resultStatusValue1 = Convert.ToInt32(resultStatusValue[0][0]);
            return resultStatusValue1;
        }

        public static string RetrieveLatestGrade(string uln)
        {
            var profileId = SqlQueries.ReturnRegistrationProfileForLrs(uln);
            var pathwayId = SqlQueries.ReturnRegistrationPathwayForLrs(profileId);
            string RetrieveTqPathwayAssessmentID = "Select top 1 Id from TqPathwayAssessment where TqRegistrationPathwayId =" + pathwayId;
            var PathwayAssessmentID = SqlDatabaseConncetionHelper.ReadDataFromDataBase(RetrieveTqPathwayAssessmentID, ConnectionString);
            string TqPathwayResultGradeLookup = "select top 1 TlLookupId from TqPathwayResult where TqPathwayAssessmentId =" + PathwayAssessmentID[0][0] + " order by id desc";
            var GradeLookupValue = SqlDatabaseConncetionHelper.ReadDataFromDataBase(TqPathwayResultGradeLookup, ConnectionString);
            string LookupGrade = "select value from TlLookup where ID = " + GradeLookupValue[0][0];
            var Grade = SqlDatabaseConncetionHelper.ReadDataFromDataBase(LookupGrade, ConnectionString);
            string Grade1 = Convert.ToString(Grade[0][0]);
            return Grade1;
        }

        public static void UpdateAutumn2021AssessmentSeriesWithPastDate()
        {
            string CreateQualificationAcheived = "update AssessmentSeries set appealenddate = '2021-08-04 00:00:00.000' where id = 1";
            SqlDatabaseConncetionHelper.ExecuteSqlCommand(CreateQualificationAcheived, ConnectionString);
        }

        public static void UpdateAutumn2021AssessmentSeriesWithFutureDate()
        {
            string CreateQualificationAcheived = "update AssessmentSeries set appealenddate = '2021-09-24 00:00:00.000' where id = 1";
            SqlDatabaseConncetionHelper.ExecuteSqlCommand(CreateQualificationAcheived, ConnectionString);
        }

        public static void SetAllTLevelsToNotReviewed()
        {
            string SetAllTLevelsToNotReviewed = "Update TqAwardingOrganisation set ReviewStatus=1 where TlAwardingOrganisatonId=1";
            SqlDatabaseConncetionHelper.ExecuteSqlCommand(SetAllTLevelsToNotReviewed, ConnectionString);
        }
        public static void SetAllTLevelsToReviewed()
        {
            string SetAllTLevelsToNotReviewed = "Update TqAwardingOrganisation set ReviewStatus=2 where TlAwardingOrganisatonId=1";
            SqlDatabaseConncetionHelper.ExecuteSqlCommand(SetAllTLevelsToNotReviewed, ConnectionString);
        }

        public static void SetAllTLevelsToQueried()
        {
            string SetAllTLevelsToNotReviewed = "Update TqAwardingOrganisation set ReviewStatus=3 where TlAwardingOrganisatonId=1";
            SqlDatabaseConncetionHelper.ExecuteSqlCommand(SetAllTLevelsToNotReviewed, ConnectionString);
        }
        public static void SetTwoTLevelsToNotReviewed()
        {
            string SetTwoTLevelsToNotReviewed = "update TqAwardingOrganisation set reviewstatus = 1 where TlPathwayId in (select ao.TlPathwayId from TqAwardingOrganisation AO, TlPathway p where AO.TlPathwayId = p.id and ao.TlAwardingOrganisatonId = 1 and p.TlevelTitle in ('T Level in Agriculture, Environmental and Animal Care','T Level in Business and Administration'))";
            SqlDatabaseConncetionHelper.ExecuteSqlCommand(SetTwoTLevelsToNotReviewed, ConnectionString);
        }
        public static void SetThreeTLevelsToNotReviewed()
        {
            string SetTwoTLevelsToNotReviewed = "update TqAwardingOrganisation set reviewstatus = 1 where TlPathwayId in (select ao.TlPathwayId from TqAwardingOrganisation AO, TlPathway p where AO.TlPathwayId = p.id and ao.TlAwardingOrganisatonId = 1 and p.TlevelTitle in ('T Level in Agriculture, Environmental and Animal Care','T Level in Business and Administration','T Level in Digital Business Services'))";
            SqlDatabaseConncetionHelper.ExecuteSqlCommand(SetTwoTLevelsToNotReviewed, ConnectionString);
        }

        public static void SetOneTLevelsToNotReviewed()
        {
            string SetTwoTLevelsToNotReviewed = "update TqAwardingOrganisation set reviewstatus = 1 where TlPathwayId in (select ao.TlPathwayId from TqAwardingOrganisation AO, TlPathway p where AO.TlPathwayId = p.id and ao.TlAwardingOrganisatonId = 1 and p.TlevelTitle in ('T Level in Agriculture, Environmental and Animal Care'))";
            SqlDatabaseConncetionHelper.ExecuteSqlCommand(SetTwoTLevelsToNotReviewed, ConnectionString);
        }

        public static void SetTLevelstoReviewedQueriedUnconfirmed()
        {
            string SetThreeTLevelsToReviewed = "update TqAwardingOrganisation set reviewstatus = 2, modifiedon = GETDATE(), ModifiedBy = 'Test User' where TlPathwayId in (select ao.TlPathwayId from TqAwardingOrganisation AO, TlPathway p where AO.TlPathwayId = p.id and ao.TlAwardingOrganisatonId = 1 and p.TlevelTitle in ('T Level in Agriculture, Environmental and Animal Care','T Level in Business and Administration','T Level in Digital Business Services'))";
            SqlDatabaseConncetionHelper.ExecuteSqlCommand(SetThreeTLevelsToReviewed, ConnectionString);
            string SetThreeTLevelsToQueried = "update TqAwardingOrganisation set reviewstatus = 3, modifiedon = GETDATE(), ModifiedBy = 'Test User' where TlPathwayId in (select ao.TlPathwayId from TqAwardingOrganisation AO, TlPathway p where AO.TlPathwayId = p.id and ao.TlAwardingOrganisatonId = 1 and p.TlevelTitle in ('T Level in Digital Support Services','T Level in Education and Childcare','T Level in Engineering and Manufacturing'))";
            SqlDatabaseConncetionHelper.ExecuteSqlCommand(SetThreeTLevelsToQueried, ConnectionString);
            string SetFourTLevelsToUnconfirmed = "update TqAwardingOrganisation set reviewstatus = 1, modifiedon = GETDATE(), ModifiedBy = 'Test User' where TlPathwayId in (select ao.TlPathwayId from TqAwardingOrganisation AO, TlPathway p where AO.TlPathwayId = p.id and ao.TlAwardingOrganisatonId = 1 and p.TlevelTitle in ('T Level in Health','T Level in Healthcare Science','T Level in Legal, Finance and Accounting','T Level in Science'))";
            SqlDatabaseConncetionHelper.ExecuteSqlCommand(SetFourTLevelsToUnconfirmed, ConnectionString);
        }
        public static string GetAcademicYear()
        {
            string GetAcademicYear = "Select Name from dbo.AcademicYear where getdate() >= StartDate and getdate() <= EndDate" ;
            var AcademicYear = SqlDatabaseConncetionHelper.ReadDataFromDataBase(GetAcademicYear, ConnectionString);
            var result = Convert.ToString(AcademicYear[0][0]);
            return result;
        }
        public static string GetAssessmentSeries()
        {
            string GetAssessmentSeries = "Select Name from dbo.AssessmentSeries where getdate() >= StartDate and getdate() <= EndDate";
            var AssessmentSeries = SqlDatabaseConncetionHelper.ReadDataFromDataBase(GetAssessmentSeries, ConnectionString);
            var result = Convert.ToString(AssessmentSeries[0][0]);
            return result;
        }

        public static string GetSpecialismAssessmentSeries()
        {
            string GetSpecialismAssessmentSeries = "Select Name from dbo.AssessmentSeries where getdate() >= StartDate and getdate() <= EndDate and componenttype = 2";
            var SpecialismAssessmentSeries = SqlDatabaseConncetionHelper.ReadDataFromDataBase(GetSpecialismAssessmentSeries, ConnectionString);
            var result = Convert.ToString(SpecialismAssessmentSeries[0][0]);
            return result;
        }

        public static void UpdateAcademicYearToPreviousYear()
        {
            string GetAcademicYear = "Select Name from dbo.AcademicYear where getdate() >= StartDate and getdate() <= EndDate";
            var AcademicYear = SqlDatabaseConncetionHelper.ReadDataFromDataBase(GetAcademicYear, ConnectionString);
            var result = Convert.ToString(AcademicYear[0][0]);
            String PreviousAcademicYear = result.Substring(0, 4);
            int x = Int32.Parse(PreviousAcademicYear);
            x = x - 1;
            string UpdateRegistrationYear = "Update TqRegistrationPathway set AcademicYear = " + x + " where tqregistrationprofileid in (select id from TqRegistrationProfile where  UniqueLearnerNumber like '99%')";
            SqlDatabaseConncetionHelper.ExecuteSqlCommand(UpdateRegistrationYear, ConnectionString);
        }

        public static void UpdateAssessmentSeriesToPastOne(string ULN)
        {
            string UpdateAssessmentSeries = "update TqPathwayAssessment set AssessmentSeriesId = 1 where Id in (select max(Id) from TqPathwayAssessment where TqRegistrationPathwayId in (select Id from TqRegistrationPathway where tqregistrationprofileid in (select id from TqRegistrationProfile where UniqueLearnerNumber = " + ULN + ")))";
            SqlDatabaseConncetionHelper.ExecuteSqlCommand(UpdateAssessmentSeries, ConnectionString);
        }
        
    }
}
