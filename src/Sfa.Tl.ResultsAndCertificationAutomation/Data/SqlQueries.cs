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
        private const string UlnList = "select Id,UniqueLearnerNumber,Firstname,Lastname,DateofBirth from TqRegistrationProfile";
        private const string DeleteRegistrationSpecialism = "Delete rs from TqRegistrationSpecialism rs join TqRegistrationPathway rw ON rs.TqRegistrationPathwayId = rw.Id join TqRegistrationProfile rp on rw.TqRegistrationProfileId =rp.Id where UniqueLearnerNumber like '9%'";
        private const string DeleteRegistrationPathway = "Delete from TqRegistrationPathway where TqRegistrationProfileId In (select Id from TqRegistrationProfile where UniqueLearnerNumber like '9%')";
        private const string DeleteRegistrationProfile = "Delete from TqRegistrationProfile where UniqueLearnerNumber like '9%'";
        private const string DeleteAssessmentPathway = "Delete pa from TqPathwayAssessment pa join TqRegistrationPathway rw ON pa.TqRegistrationPathwayId = rw.Id join TqRegistrationProfile rp on rw.TqRegistrationProfileId =rp.Id where UniqueLearnerNumber like '9%'";
        private const string DeleteAssessmentSpecialism = "Delete sa from TqSpecialismAssessment sa join TqRegistrationSpecialism rs ON sa.TqRegistrationSpecialismId = rs.Id join TqRegistrationPathway rp on  rs.TqRegistrationPathwayId=rp.Id join TqRegistrationProfile tr on  rp.TqRegistrationProfileId =tr.Id where UniqueLearnerNumber like '9%'";
        private const string DeletePathwayResults = "Delete pr from TqPathwayResult pr join TqPathwayAssessment pa on pr.TqPathwayAssessmentId = pa.Id join TqRegistrationPathway rw ON pa.TqRegistrationPathwayId = rw.Id join TqRegistrationProfile rp on rw.TqRegistrationProfileId =rp.Id where UniqueLearnerNumber like '9%'";
        private const string DeleteAssessmentResult = "Delete sr from TqSpecialismResult sr join TqSpecialismAssessment sa on sr.TqSpecialismAssessmentId = sa.Id join TqRegistrationSpecialism rs ON sa.TqRegistrationSpecialismId = rs.Id join TqRegistrationPathway rp on  rs.TqRegistrationPathwayId=rp.Id join TqRegistrationProfile tr on  rp.TqRegistrationProfileId =tr.Id where UniqueLearnerNumber like '9%'";
        private const string DeleteIpData = "Delete ip from IndustryPlacement ip join TqRegistrationPathway pw on ip.TqRegistrationPathwayId = pw.Id join TqRegistrationProfile rp on rp.Id=pw.TqRegistrationProfileId where rp.UniqueLearnerNumber like '9%'";
        private const string DeleteEmData = "Delete qa from QualificationAchieved qa join TqRegistrationProfile rp on qa.TqRegistrationProfileId = rp.Id where rp.UniquelearnerNumber like '9%'";

        public static void DeleteFromRegistrationTables()
        {
            SqlDatabaseConncetionHelper.ExecuteDeleteSqlCommand(DeleteIpData, ConnectionString);
            SqlDatabaseConncetionHelper.ExecuteDeleteSqlCommand(DeleteEmData, ConnectionString);
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
            var filepath = $"{AppDomain.CurrentDomain.BaseDirectory}Data\\{sqlFile}.sql";
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
            var deletePathwayResults = "Delete pr from TqPathwayResult pr join TqPathwayAssessment pa on pr.TqPathwayAssessmentId = pa.Id join TqRegistrationPathway rw ON pa.TqRegistrationPathwayId = rw.Id join TqRegistrationProfile rp on rw.TqRegistrationProfileId = rp.Id where UniqueLearnerNumber = '" + uln + "'";
            var deleteRegSpecialism = "Delete rs from TqRegistrationSpecialism rs join TqRegistrationPathway rw ON rs.TqRegistrationPathwayId = rw.Id join TqRegistrationProfile rp on rw.TqRegistrationProfileId =rp.Id where UniqueLearnerNumber = '" + uln + "'";
            var deleteRegPathway = "Delete from TqRegistrationPathway where TqRegistrationProfileId In (select Id from TqRegistrationProfile where UniqueLearnerNumber= '" + uln + "')";
            var deleteRegProfile = "Delete from TqRegistrationProfile where UniqueLearnerNumber = '" + uln + "'";
            var deleteAssPathway = "Delete pa from TqPathwayAssessment pa join TqRegistrationPathway rw ON pa.TqRegistrationPathwayId = rw.Id join TqRegistrationProfile rp on rw.TqRegistrationProfileId =rp.Id where UniqueLearnerNumber= '" + uln + "'";
            var deleteAssSpecialism = "Delete sa from TqSpecialismAssessment sa join TqRegistrationSpecialism rs ON sa.TqRegistrationSpecialismId = rs.Id join TqRegistrationPathway rp on  rs.TqRegistrationPathwayId=rp.Id join TqRegistrationProfile tr on  rp.TqRegistrationProfileId =tr.Id where UniqueLearnerNumber= '" + uln + "'";
            SqlDatabaseConncetionHelper.ExecuteDeleteSqlCommand(deletePathwayResults, ConnectionString);
            SqlDatabaseConncetionHelper.ExecuteDeleteSqlCommand(deleteAssPathway, ConnectionString);
            SqlDatabaseConncetionHelper.ExecuteDeleteSqlCommand(deleteAssSpecialism, ConnectionString);
            SqlDatabaseConncetionHelper.ExecuteDeleteSqlCommand(deleteRegSpecialism, ConnectionString);
            SqlDatabaseConncetionHelper.ExecuteDeleteSqlCommand(deleteRegPathway, ConnectionString);
            SqlDatabaseConncetionHelper.ExecuteDeleteSqlCommand(deleteRegProfile, ConnectionString);
        }

        public static int CreateRegistrationProfile(string uln)
        {
            var createRegistrationProfile = "Insert into TqRegistrationProfile values(" + uln + ", 'Db FirstName','Db LastName','2001-01-01',Null,Null,Null,Null,Null,Null,Null,GETDATE(),'System', GETDATE(),'System')";
            var getRegProfileId = "Select top 1 id from TqRegistrationProfile where UniqueLearnerNumber='"+ uln + "'";
            SqlDatabaseConncetionHelper.ExecuteSqlCommand(createRegistrationProfile, ConnectionString);
            var profileId = SqlDatabaseConncetionHelper.ReadDataFromDataBase(getRegProfileId, ConnectionString);
            return (int)profileId.FirstOrDefault().FirstOrDefault();
        }
        public static int CreateRegistrationPathway(int profileId)
        {
            var tqProviderId = Constants.TqProviderId;
            var createRegPathway = "Insert into TqRegistrationPathway values('"+ profileId +"', '" + tqProviderId + "','2020', GETDATE(),NULL,1,1,GETDATE(),'System',NULL,NULL)";
            var getRegPathwayId = "select top 1 id from TqRegistrationPathway where TqRegistrationProfileId = '"+ profileId +"'";
            SqlDatabaseConncetionHelper.ExecuteSqlCommand(createRegPathway, ConnectionString);
            var pathwayId = SqlDatabaseConncetionHelper.ReadDataFromDataBase(getRegPathwayId, ConnectionString);
            return (int)pathwayId.FirstOrDefault().FirstOrDefault();
        }
        public static int CreateRegSpecialism(int pathwayId)
        {
            var tlSpecialismId = Constants.TlSpecialismId;
            var createRegSpecialism = "Insert into TqRegistrationSpecialism values('" + pathwayId + "','" + tlSpecialismId + "',GETDATE(),NULL,1,0,GETDATE(),'System',Null,Null )";
            var getSpecialismId = "select top 1 id from TqRegistrationSpecialism where TqRegistrationPathwayId  = '" + pathwayId + "'";
            SqlDatabaseConncetionHelper.ExecuteSqlCommand(createRegSpecialism, ConnectionString);
            var specialismId = SqlDatabaseConncetionHelper.ReadDataFromDataBase(getSpecialismId, ConnectionString);
            return (int)specialismId.FirstOrDefault().FirstOrDefault();
        }
        public static int CreatePathwayAssessment(int pathwayId)
        {
            var createPathwayAssessment = "Insert into TqPathwayAssessment values('" + pathwayId + "',1,GETDATE(),NULL,1,0,GETDATE(),'System',Null,Null )";
            var getRegPathwayId = "select top 1 id from TqPathwayAssessment where TqRegistrationPathwayId  = '" + pathwayId + "'";
            SqlDatabaseConncetionHelper.ExecuteSqlCommand(createPathwayAssessment, ConnectionString);
            var regPathwayId = SqlDatabaseConncetionHelper.ReadDataFromDataBase(getRegPathwayId, ConnectionString);
            return (int)regPathwayId.FirstOrDefault().FirstOrDefault();
        }
        public static void CreateSpecialismAssessment(int specialismId)
        {
            var tlAssessmentSeriesId = Constants.TlAssessmentSeriesId;
            var createSpecialismAssessment = "Insert into TqSpecialismAssessment values('" + specialismId + "','" + tlAssessmentSeriesId + "',GETDATE(),Null,1,0,GETDATE(),'System',GETDATE(),'System')";
            SqlDatabaseConncetionHelper.ExecuteSqlCommand(createSpecialismAssessment, ConnectionString);
        }

        public static int CreateSecondPathwayAssessmentEntry(int pathwayId)
        {
            var createPathwayAssessment2 = "Insert into TqPathwayAssessment values('" + pathwayId + "',2,GETDATE(),NULL,1,0,GETDATE(),'System',Null,Null )";
            var getRegPathwayId = "select top 1 id from TqPathwayAssessment where TqRegistrationPathwayId  = '" + pathwayId + "'";
            SqlDatabaseConncetionHelper.ExecuteSqlCommand(createPathwayAssessment2, ConnectionString);
            var regPathwayId = SqlDatabaseConncetionHelper.ReadDataFromDataBase(getRegPathwayId, ConnectionString);
            return (int)regPathwayId.FirstOrDefault().FirstOrDefault();
        }

        public static void CreatePathwayResult(int pathwayAssessmentId)
        {
            var createPathwayResult = "Insert into TqPathwayResult values ('" + pathwayAssessmentId + "',2,GETDATE(),NULL,Null,1,0,GETDATE(),'SYSTEM',NULL,'SYSTEM')";
            SqlDatabaseConncetionHelper.ExecuteSqlCommand(createPathwayResult, ConnectionString);
        }
        public static int CreateRegistrationProfileForLrs(string uln)
        {
            var createRegistrationProfile = "Insert into TqRegistrationProfile values(" + uln + ", 'Db FirstName','Db LastName','2001-01-01',Null,0,Null,1,1,3,3,GETDATE(),'System', GETDATE(),'System')";
            var getRegProfileId = "Select top 1 id from TqRegistrationProfile where UniqueLearnerNumber='" + uln + "'";
            SqlDatabaseConncetionHelper.ExecuteSqlCommand(createRegistrationProfile, ConnectionString);
            var profileId = SqlDatabaseConncetionHelper.ReadDataFromDataBase(getRegProfileId, ConnectionString);
            return (int)profileId.FirstOrDefault().FirstOrDefault();
        }
        public static int CreateRegistrationProfileForLrsWithEM(string uln)
        {
            var createRegistrationProfile = "Insert into TqRegistrationProfile values(" + uln + ", 'Db FirstName','Db LastName','2001-01-01',Null,1,1,Null,0,3,3,GETDATE(),'System', GETDATE(),'System')";
            var getRegProfileId = "Select top 1 id from TqRegistrationProfile where UniqueLearnerNumber='" + uln + "'";
            SqlDatabaseConncetionHelper.ExecuteSqlCommand(createRegistrationProfile, ConnectionString);
            var profileId = SqlDatabaseConncetionHelper.ReadDataFromDataBase(getRegProfileId, ConnectionString);
            return (int)profileId.FirstOrDefault().FirstOrDefault();
        }
        public static int CreateRegistrationProfileForNonLrsWithEM(string uln)
        {
            var createRegistrationProfile = "Insert into TqRegistrationProfile values(" + uln + ", 'Db FirstName','Db LastName','2001-01-01',Null,Null,1,Null,1,1,1,GETDATE(),'System', GETDATE(),'System')";
            var getRegProfileId = "Select top 1 id from TqRegistrationProfile where UniqueLearnerNumber='" + uln + "'";
            SqlDatabaseConncetionHelper.ExecuteSqlCommand(createRegistrationProfile, ConnectionString);
            var profileId = SqlDatabaseConncetionHelper.ReadDataFromDataBase(getRegProfileId, ConnectionString);
            return (int)profileId.FirstOrDefault().FirstOrDefault();
        }
        public static int CreateRegistrationPathwayForLrs(int profileId)
        {
            var tqProviderId = Constants.TqProviderIdForLrs;
            var createRegPathway = "Insert into TqRegistrationPathway values('" + profileId + "', '" + tqProviderId + "','2020', GETDATE(),NULL,1,1,GETDATE(),'System',NULL,NULL)";
            var getRegPathwayId = "select top 1 id from TqRegistrationPathway where TqRegistrationProfileId = '" + profileId + "'";
            SqlDatabaseConncetionHelper.ExecuteSqlCommand(createRegPathway, ConnectionString);
            var pathwayId = SqlDatabaseConncetionHelper.ReadDataFromDataBase(getRegPathwayId, ConnectionString);
            return (int)pathwayId.FirstOrDefault().FirstOrDefault();
        }
        public static int CreateRegistrationPathwayForDudley(int profileId)
        {
            var tqProviderId = Constants.DudleyProviderIdForLrs;
            var createRegPathway = "Insert into TqRegistrationPathway values('" + profileId + "', '" + tqProviderId + "','2021', GETDATE(),NULL,1,1,Null,Null,GETDATE(),'System',NULL,NULL)";
            var getRegPathwayId = "select top 1 id from TqRegistrationPathway where TqRegistrationProfileId = '" + profileId + "'";
            SqlDatabaseConncetionHelper.ExecuteSqlCommand(createRegPathway, ConnectionString);
            var pathwayId = SqlDatabaseConncetionHelper.ReadDataFromDataBase(getRegPathwayId, ConnectionString);
            return (int)pathwayId.FirstOrDefault().FirstOrDefault();
        }
        public static void CreateQualificationAcheivedForLrs(int profileId)
        {
            var createQualificationAcheived = "Insert into QualificationAchieved values ('" + profileId + "',38,8,1,GETDATE(),'SYSTEM',GETDATE(),'SYSTEM')";
            SqlDatabaseConncetionHelper.ExecuteSqlCommand(createQualificationAcheived, ConnectionString);

            var createQualificationAcheived1 = "Insert into QualificationAchieved values ('" + profileId + "',69,8,1,GETDATE(),'SYSTEM',GETDATE(),'SYSTEM')";
            SqlDatabaseConncetionHelper.ExecuteSqlCommand(createQualificationAcheived1, ConnectionString);
        }
        public static void CreateIndustryPlacement (int pathwayId, int status)
        {
            var createIpData = "Insert into IndustryPlacement values ('" + pathwayId + "','" + status + "',GETDATE(),'SYSTEM',GETDATE(),'SYSTEM')";
            SqlDatabaseConncetionHelper.ExecuteSqlCommand(createIpData, ConnectionString);
        }
        public static int CreateRegSpecialismForLrs(int pathwayId)
        {
            var tlSpecialismId = Constants.TlSpecialismId;
            var createRegSpecialism = "Insert into TqRegistrationSpecialism values('" + pathwayId + "','" + tlSpecialismId + "',GETDATE(),NULL,1,0,GETDATE(),'System',Null,Null )";
            var getSpecialismId = "select top 1 id from TqRegistrationSpecialism where TqRegistrationPathwayId  = '" + pathwayId + "'";
            SqlDatabaseConncetionHelper.ExecuteSqlCommand(createRegSpecialism, ConnectionString);
            var specialismId = SqlDatabaseConncetionHelper.ReadDataFromDataBase(getSpecialismId, ConnectionString);
            return (int)specialismId.FirstOrDefault().FirstOrDefault();
        }
        public static void UpdateRegWithdrawn(string uln)
        {
            var modifyRegPathway = "Update TqRegistrationPathway set status=4, EndDate=GETDATE(),ModifiedOn=GETDATE(),ModifiedBy='SYSTEM' from TqRegistrationPathway rp join TqRegistrationProfile pr on rp.TqRegistrationProfileId = pr.Id where UniqueLearnerNumber = '" + uln + "'";
            SqlDatabaseConncetionHelper.UpdateSqlCommand(modifyRegPathway, ConnectionString);
            var modifyRegSpecialism = "Update TqRegistrationSpecialism set EndDate=GETDATE(),ModifiedOn=GETDATE(),ModifiedBy='SYSTEM' from TqRegistrationSpecialism rs join TqRegistrationPathway rp on rs.TqRegistrationPathwayId = rp.Id join TqRegistrationProfile pr on rp.TqRegistrationProfileId = pr.Id where UniqueLearnerNumber = '" + uln + "'";
            SqlDatabaseConncetionHelper.UpdateSqlCommand(modifyRegSpecialism, ConnectionString);
            var modifyPathwayAssessment = "Update TqPathwayAssessment set EndDate=GETDATE(),ModifiedOn=GETDATE(),ModifiedBy='SYSTEM' from TqPathwayAssessment pa join TqRegistrationPathway rp on rp.Id = pa.TqRegistrationPathwayId join TqRegistrationProfile pf on pf.id = rp.TqRegistrationProfileId where UniqueLearnerNumber = '" + uln + "'";
            SqlDatabaseConncetionHelper.UpdateSqlCommand(modifyPathwayAssessment, ConnectionString);
            var modifyPathwayResult = "update TqPathwayResult set EndDate=GETDATE(),ModifiedOn=GETDATE(),ModifiedBy='SYSTEM' from TqPathwayResult pr join TqPathwayAssessment pa on pr.TqPathwayAssessmentId = pa.Id join TqRegistrationPathway rp on rp.Id = pa.TqRegistrationPathwayId join TqRegistrationProfile pf on pf.id = rp.TqRegistrationProfileId where UniqueLearnerNumber = '" + uln + "'";
            SqlDatabaseConncetionHelper.UpdateSqlCommand(modifyPathwayResult, ConnectionString);
        }


        public static string ReturnLastActiveGrade(string uln)
        {
            var returnLastActiveGrade = "select top 1 Tll.Value from TqRegistrationProfile TQPR, TqRegistrationPathway TQPA, TqPathwayAssessment TQPAS, TqPathwayResult TQR, TlLookup Tll where TQPR.ID = TQPA.TqRegistrationProfileId and TQPA.id = TQPAS.TqRegistrationPathwayId and TQPAS.ID = TQR.TqPathwayAssessmentId and TQR.TlLookupId = Tll.id and TQPR.uniquelearnernumber = " + uln + " and TQPA.EndDate is not Null order by TQR.Id desc";
            var grade = SqlDatabaseConncetionHelper.ReadDataFromDataBase(returnLastActiveGrade, ConnectionString);
            return (string)grade.FirstOrDefault().FirstOrDefault();
        }

        public static int ReturnLastActiveGradeCount(string uln)
        {
            var returnLastActiveGradeCount = "select count(Tll.Value) from TlLookup TLL, TqPathwayResult TQR where TQR.TlLookupId = Tll.id and TQR.tqpathwayassessmentid in (select id from TqPathwayAssessment where TqRegistrationPathwayId in  (select top 1 TQPA.ID from TqRegistrationProfile TQPR, TqRegistrationPathway TQPA where TQPR.ID = TQPA.TqRegistrationProfileId and TQPR.uniquelearnernumber = " + uln + "and TQPA.EndDate is not Null order by TQPA.EndDate desc)) and IsOptedin > 0   group by Tll.Value";
            var records = SqlDatabaseConncetionHelper.ReadDataFromDataBase(returnLastActiveGradeCount, ConnectionString);
            int result = Convert.ToInt32(records.Count);
            return result;
        }

        public static int VerifyRegistrationDeleted(string uln)
        {
            var returnRegistrationRecords = "select count(TQPR.Id) from TqRegistrationProfile TQPR, TqRegistrationPathway TQPA where TQPR.ID = TQPA.TqRegistrationProfileId and TQPR.uniquelearnernumber = " + uln;
            var records = SqlDatabaseConncetionHelper.ReadDataFromDataBase(returnRegistrationRecords, ConnectionString);
            int result = Convert.ToInt32(records[0][0]);
            return result;
        }

        public static int RetrievePathwayAssessmentID(string uln)
        {
            var pathwayAssessmentId = " select pa.Id from TqPathwayAssessment pa join TqRegistrationPathway rw ON pa.TqRegistrationPathwayId = rw.Id join TqRegistrationProfile rp on rw.TqRegistrationProfileId = rp.Id where UniqueLearnerNumber = " + uln;
            var paid = SqlDatabaseConncetionHelper.ReadDataFromDataBase(pathwayAssessmentId, ConnectionString);
            int result = Convert.ToInt32(paid[0][0]);
            return result;
        }

        public static void CreateQualificationAcheivedForLrsMathsAEnglishNA(int profileId)
        {
            var createQualificationAcheived = "Insert into QualificationAchieved values ('" + profileId + "',38,8,1,GETDATE(),'SYSTEM',GETDATE(),'SYSTEM')";
            SqlDatabaseConncetionHelper.ExecuteSqlCommand(createQualificationAcheived, ConnectionString);

            var createQualificationAcheived1 = "Insert into QualificationAchieved values ('" + profileId + "',69,9,0,GETDATE(),'SYSTEM',GETDATE(),'SYSTEM')";
            SqlDatabaseConncetionHelper.ExecuteSqlCommand(createQualificationAcheived1, ConnectionString);
        }

        public static void CreateQualificationAcheivedForLrsMathsNAEnglishA(int profileId)
        {
            var createQualificationAcheived = "Insert into QualificationAchieved values ('" + profileId + "',38,9,0,GETDATE(),'SYSTEM',GETDATE(),'SYSTEM')";
            SqlDatabaseConncetionHelper.ExecuteSqlCommand(createQualificationAcheived, ConnectionString);

            var createQualificationAcheived1 = "Insert into QualificationAchieved values ('" + profileId + "',69,8,1,GETDATE(),'SYSTEM',GETDATE(),'SYSTEM')";
            SqlDatabaseConncetionHelper.ExecuteSqlCommand(createQualificationAcheived1, ConnectionString);
        }

        public static int CreateRegistrationProfileForLrsMathsAndEnglishNotAchieved(string uln)
        {
            var createRegistrationProfile = "Insert into TqRegistrationProfile values(" + uln + ", 'Db FirstName','Db LastName','2001-01-01',Null,1,0,0,0,GETDATE(),'System', GETDATE(),'System')";
            var getRegProfileId = "Select top 1 id from TqRegistrationProfile where UniqueLearnerNumber='" + uln + "'";
            SqlDatabaseConncetionHelper.ExecuteSqlCommand(createRegistrationProfile, ConnectionString);
            var profileId = SqlDatabaseConncetionHelper.ReadDataFromDataBase(getRegProfileId, ConnectionString);
            return (int)profileId.FirstOrDefault().FirstOrDefault();
        }

        public static int CreateRegistrationProfileForNonLRS(string uln)
        {
            var createRegistrationProfile = "Insert into TqRegistrationProfile values(" + uln + ", 'Db FirstName','Db LastName','2001-01-01',Null,Null,Null,Null,NULL,NULL,NULL,GETDATE(),'System', GETDATE(),'System')";
            var getRegProfileId = "Select top 1 id from TqRegistrationProfile where UniqueLearnerNumber='" + uln + "'";
            SqlDatabaseConncetionHelper.ExecuteSqlCommand(createRegistrationProfile, ConnectionString);
            var profileId = SqlDatabaseConncetionHelper.ReadDataFromDataBase(getRegProfileId, ConnectionString);
            return (int)profileId.FirstOrDefault().FirstOrDefault();
        }

        public static int ReturnIPStatus(string uln)
        {
            var returnIpStatus = "select status from IndustryPlacement where TqRegistrationPathwayId in (  Select max (id) from TqRegistrationPathway where TqRegistrationProfileId in (select id from TqRegistrationProfile where uniquelearnernumber =" + uln +"))";
            var records = SqlDatabaseConncetionHelper.ReadDataFromDataBase(returnIpStatus, ConnectionString);
            int result = Convert.ToInt32(records[0][0]);
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
            var getRegPathwayId = "select top 1 id from TqRegistrationPathway where TqRegistrationProfileId = '" + profileId + "'";
            var pathwayId = SqlDatabaseConncetionHelper.ReadDataFromDataBase(getRegPathwayId, ConnectionString);
            return (int)pathwayId.FirstOrDefault().FirstOrDefault();
        }

        public static void UpdateRegistrationProfileRecord(string SQL)
        {
            SqlDatabaseConncetionHelper.ExecuteSqlCommand(SQL, ConnectionString);
        }

        public static void CreateQualificationAcheivedForLrsSEND(int profileId)
        {
            var createQualificationAcheived = "Insert into QualificationAchieved values ('" + profileId + "',517,8,1,GETDATE(),'SYSTEM',GETDATE(),'SYSTEM')";
            SqlDatabaseConncetionHelper.ExecuteSqlCommand(createQualificationAcheived, ConnectionString);

            var createQualificationAcheived1 = "Insert into QualificationAchieved values ('" + profileId + "',596,8,1,GETDATE(),'SYSTEM',GETDATE(),'SYSTEM')";
            SqlDatabaseConncetionHelper.ExecuteSqlCommand(createQualificationAcheived1, ConnectionString);
        }

        public static int ReturnRegistrationProfileID(string uln)
        {
            var getRegProfileId = "Select top 1 id from TqRegistrationProfile where UniqueLearnerNumber='" + uln + "'";
            var profileId = SqlDatabaseConncetionHelper.ReadDataFromDataBase(getRegProfileId, ConnectionString);
            return (int)profileId.FirstOrDefault().FirstOrDefault();
        }
        public static void DeleteAddress()
        {
            var deletePrintCertificate = "delete pc from PrintCertificate pc join PrintBatchItem pb on pc.PrintBatchItemId = pb.BatchId";
            var deletePrintBatchItem = "delete pb from PrintBatchItem pb join TlProviderAddress pa on pb.TlProviderAddressId=pa.Id";
            var deleteAddress = "Delete pa from TlProviderAddress pa join  TlProvider tp on pa.TlProviderId = tp.Id where tp.Name ='Barnsley College'";
            SqlDatabaseConncetionHelper.ExecuteDeleteSqlCommand(deletePrintCertificate, ConnectionString);
            SqlDatabaseConncetionHelper.ExecuteDeleteSqlCommand(deletePrintBatchItem, ConnectionString);
            SqlDatabaseConncetionHelper.ExecuteDeleteSqlCommand(deleteAddress, ConnectionString);
        }
        public static void InsertAddress()
        {
            var providerId = "Select Id from TlProvider where Name='Barnsley College'";
            var getProviderId  = SqlDatabaseConncetionHelper.ReadDataFromDataBase(providerId, ConnectionString);
            int result = Convert.ToInt32(getProviderId[0][0]);
            var insertAddress = "Insert Into TlProviderAddress values ('"+ result +"','Department', 'BARNSLEY COLLEGE','CHURCH STREET',NULL,'BARNSLEY','S70 2AX',1,GETDATE(),'System',Null,Null)";
            SqlDatabaseConncetionHelper.ExecuteSqlCommand(insertAddress, ConnectionString);
        }

        public static int CreateWithdrawnRegistrationPathwayRecord(int profileId)
        {
            var tqProviderId = Constants.TqProviderIdForLrs;
            var createRegPathway = "Insert into TqRegistrationPathway values('" + profileId + "', '" + tqProviderId + "','2020', GETDATE(),GETDATE(),4,1,GETDATE(),'System',NULL,NULL)";
            var getRegPathwayId = "select top 1 id from TqRegistrationPathway where TqRegistrationProfileId = '" + profileId + "'";
            SqlDatabaseConncetionHelper.ExecuteSqlCommand(createRegPathway, ConnectionString);
            var pathwayId = SqlDatabaseConncetionHelper.ReadDataFromDataBase(getRegPathwayId, ConnectionString);
            return (int)pathwayId.FirstOrDefault().FirstOrDefault();
        }

        public static int CreateRegistrationProfileForLrsCombination(string uln, string IsLearnerVerified, string IsEmAchieved, string SendLearner, string IsRcFeed)
        {
            var createRegistrationProfile = "Insert into TqRegistrationProfile values(" + uln + ", 'Db FirstName','Db LastName','2001-01-01',Null," + IsLearnerVerified + "," + IsEmAchieved + "," + SendLearner + "," + IsRcFeed + ",3,3,GETDATE(),'System', GETDATE(),'System')";
            Console.WriteLine(createRegistrationProfile);
            string getRegProfileId = "Select top 1 id from TqRegistrationProfile where UniqueLearnerNumber='" + uln + "'";
            SqlDatabaseConncetionHelper.ExecuteSqlCommand(createRegistrationProfile, ConnectionString);
            var profileId = SqlDatabaseConncetionHelper.ReadDataFromDataBase(getRegProfileId, ConnectionString);
            return (int)profileId.FirstOrDefault().FirstOrDefault();
        }

        public static int CreateRegistrationPathwayForLrsCombination(int profileId)
        {
            var tqProviderId = Constants.TqProviderIdForLrs;
            var createRegPathway = "Insert into TqRegistrationPathway values('" + profileId + "', '" + tqProviderId + "','2020', GETDATE(),GETDATE(),4,0,GETDATE(),'System',NULL,NULL)";
            var getRegPathwayId = "select top 1 id from TqRegistrationPathway where TqRegistrationProfileId = '" + profileId + "'";
            SqlDatabaseConncetionHelper.ExecuteSqlCommand(createRegPathway, ConnectionString);
            var pathwayId = SqlDatabaseConncetionHelper.ReadDataFromDataBase(getRegPathwayId, ConnectionString);
            return (int)pathwayId.FirstOrDefault().FirstOrDefault();
        }

        public static void CreateQualificationAcheivedForLrsMathsNaEnglishNa(int profileId)
        {
            var createQualificationAcheived = "Insert into QualificationAchieved values ('" + profileId + "',38,9,0,GETDATE(),'SYSTEM',GETDATE(),'SYSTEM')";
            SqlDatabaseConncetionHelper.ExecuteSqlCommand(createQualificationAcheived, ConnectionString);

            var createQualificationAcheived1 = "Insert into QualificationAchieved values ('" + profileId + "',69,9,1,GETDATE(),'SYSTEM',GETDATE(),'SYSTEM')";
            SqlDatabaseConncetionHelper.ExecuteSqlCommand(createQualificationAcheived1, ConnectionString);
        }

        public static void DeletePrintTableRecords(string uln)
        {
            var recordCountSql = "select count(*) from PrintCertificate where uln =" + uln;
            var recordCount = SqlDatabaseConncetionHelper.ReadDataFromDataBase(recordCountSql, ConnectionString);
            int recordCount1 = Convert.ToInt32(recordCount[0][0]);
           
            if (recordCount1 == 0)
            {
                Console.WriteLine("Do Nothing");
            }
            else
            {
                var retrievePrintBatchItemId = "select top 1 printbatchitemid from PrintCertificate where uln =" + uln;
                var printBatchItemId = SqlDatabaseConncetionHelper.ReadDataFromDataBase(retrievePrintBatchItemId, ConnectionString);
                var retrieveBatchId = "Select top 1 batchID from PrintBatchItem where id in (select printbatchitemid from PrintCertificate where uln =" + uln + ")";
                var batchId = SqlDatabaseConncetionHelper.ReadDataFromDataBase(retrieveBatchId, ConnectionString);
                var deletePrintCertificateRecord = "delete from PrintCertificate where ULN =" + uln;
                var deletePrintBatchItemRecord = "delete from PrintBatchItem where id =" + printBatchItemId[0][0];
                var deleteBatchRecord = "delete from batch where id =" + batchId[0][0];
                SqlDatabaseConncetionHelper.ExecuteSqlCommand(deletePrintCertificateRecord, ConnectionString);
                SqlDatabaseConncetionHelper.ExecuteSqlCommand(deletePrintBatchItemRecord, ConnectionString);
                SqlDatabaseConncetionHelper.ExecuteSqlCommand(deleteBatchRecord, ConnectionString);
            }
        }

        public static string CreateRegistrationAppealUrl(string uln)
        {
            var profileId = SqlQueries.ReturnRegistrationProfileForLrs(uln);
            var pathwayId = SqlQueries.ReturnRegistrationPathwayForLrs(profileId);
            var retrieveTqPathwayAssessmentId = "Select top 1 Id from TqPathwayAssessment where TqRegistrationPathwayId =" + pathwayId;
            var pathwayAssessmentId = SqlDatabaseConncetionHelper.ReadDataFromDataBase(retrieveTqPathwayAssessmentId, ConnectionString);
            var url = "https://test.manage-tlevel-results.tlevels.gov.uk/reviews-and-appeals-learner-status/" + profileId + "/" + pathwayAssessmentId[0][0];
            return url;
        }

        public static string RetrieveResultUpdatedData(string uln)
        {
            var profileId = SqlQueries.ReturnRegistrationProfileForLrs(uln);
            var pathwayId = SqlQueries.ReturnRegistrationPathwayForLrs(profileId);
            var retrieveTqPathwayAssessmentId = "Select top 1 Id from TqPathwayAssessment where TqRegistrationPathwayId =" + pathwayId;
            var pathwayAssessmentId = SqlDatabaseConncetionHelper.ReadDataFromDataBase(retrieveTqPathwayAssessmentId, ConnectionString);
            var tqPathwayResultCreatedByValue = "select top 1 createdby from TqPathwayResult where TqPathwayAssessmentId =" + pathwayAssessmentId[0][0] + " order by id desc";
            var createdByValue = SqlDatabaseConncetionHelper.ReadDataFromDataBase(tqPathwayResultCreatedByValue, ConnectionString);
            var createdByValue1 = Convert.ToString(createdByValue[0][0]);
            return createdByValue1;
        }

        public static string RetrieveResultCreatedOnData(string uln)
        {
            var profileId = SqlQueries.ReturnRegistrationProfileForLrs(uln);
            var pathwayId = SqlQueries.ReturnRegistrationPathwayForLrs(profileId);
            var retrieveTqPathwayAssessmentId = "Select top 1 Id from TqPathwayAssessment where TqRegistrationPathwayId =" + pathwayId;
            var pathwayAssessmentId = SqlDatabaseConncetionHelper.ReadDataFromDataBase(retrieveTqPathwayAssessmentId, ConnectionString);
            var tqPathwayResultCreatedByValue = "select top 1 createdOn from TqPathwayResult where TqPathwayAssessmentId =" + pathwayAssessmentId[0][0] + " order by id desc";
            var createdOnValue = SqlDatabaseConncetionHelper.ReadDataFromDataBase(tqPathwayResultCreatedByValue, ConnectionString);
            var createdOnValue1 = Convert.ToString(createdOnValue[0][0]);
            return createdOnValue1;
        }
        

        public static int RetrieveResultStatus(string uln)
        {
            var profileId = SqlQueries.ReturnRegistrationProfileForLrs(uln);
            var pathwayId = SqlQueries.ReturnRegistrationPathwayForLrs(profileId);
            var retrieveTqPathwayAssessmentId = "Select top 1 Id from TqPathwayAssessment where TqRegistrationPathwayId =" + pathwayId;
            var pathwayAssessmentId = SqlDatabaseConncetionHelper.ReadDataFromDataBase(retrieveTqPathwayAssessmentId, ConnectionString);
            var tqPathwayResultStatusValue = "select top 1 prsstatus from TqPathwayResult where TqPathwayAssessmentId =" + pathwayAssessmentId[0][0] + " order by id desc";
            var resultStatusValue = SqlDatabaseConncetionHelper.ReadDataFromDataBase(tqPathwayResultStatusValue, ConnectionString);
            int resultStatusValue1 = Convert.ToInt32(resultStatusValue[0][0]);
            return resultStatusValue1;
        }

        public static string RetrieveLatestGrade(string uln)
        {
            var profileId = SqlQueries.ReturnRegistrationProfileForLrs(uln);
            var pathwayId = SqlQueries.ReturnRegistrationPathwayForLrs(profileId);
            var retrieveTqPathwayAssessmentId = "Select top 1 Id from TqPathwayAssessment where TqRegistrationPathwayId =" + pathwayId;
            var pathwayAssessmentId = SqlDatabaseConncetionHelper.ReadDataFromDataBase(retrieveTqPathwayAssessmentId, ConnectionString);
            var tqPathwayResultGradeLookup = "select top 1 TlLookupId from TqPathwayResult where TqPathwayAssessmentId =" + pathwayAssessmentId[0][0] + " order by id desc";
            var gradeLookupValue = SqlDatabaseConncetionHelper.ReadDataFromDataBase(tqPathwayResultGradeLookup, ConnectionString);
            var lookupGrade = "select value from TlLookup where ID = " + gradeLookupValue[0][0];
            var grade = SqlDatabaseConncetionHelper.ReadDataFromDataBase(lookupGrade, ConnectionString);
            var grade1 = Convert.ToString(grade[0][0]);
            return grade1;
        }

        protected static void UpdateAutumn2021AssessmentSeriesWithPastDate()
        {
            var createQualificationAcheived = "update AssessmentSeries set appealenddate = '2021-08-04 00:00:00.000' where id = 1";
            SqlDatabaseConncetionHelper.ExecuteSqlCommand(createQualificationAcheived, ConnectionString);
        }

        protected static void UpdateAutumn2021AssessmentSeriesWithFutureDate()
        {
            var createQualificationAcheived = "update AssessmentSeries set appealenddate = '2021-09-24 00:00:00.000' where id = 1";
            SqlDatabaseConncetionHelper.ExecuteSqlCommand(createQualificationAcheived, ConnectionString);
        }

        public static void SetAllTLevelsToNotReviewed()
        {
            var setAllTLevelsToNotReviewed = "Update TqAwardingOrganisation set ReviewStatus=1 where TlAwardingOrganisatonId=1";
            SqlDatabaseConncetionHelper.ExecuteSqlCommand(setAllTLevelsToNotReviewed, ConnectionString);
        }
        public static void SetAllTLevelsToReviewed()
        {
            var setAllTLevelsToNotReviewed = "Update TqAwardingOrganisation set ReviewStatus=2 where TlAwardingOrganisatonId=1";
            SqlDatabaseConncetionHelper.ExecuteSqlCommand(setAllTLevelsToNotReviewed, ConnectionString);
        }

        protected static void SetAllTLevelsToQueried()
        {
            var setAllTLevelsToNotReviewed = "Update TqAwardingOrganisation set ReviewStatus=3 where TlAwardingOrganisatonId=1";
            SqlDatabaseConncetionHelper.ExecuteSqlCommand(setAllTLevelsToNotReviewed, ConnectionString);
        }

        protected static void SetTwoTLevelsToNotReviewed()
        {
            var setTwoTLevelsToNotReviewed = "update TqAwardingOrganisation set reviewstatus = 1 where TlPathwayId in (select ao.TlPathwayId from TqAwardingOrganisation AO, TlPathway p where AO.TlPathwayId = p.id and ao.TlAwardingOrganisatonId = 1 and p.TlevelTitle in ('T Level in Agriculture, Environmental and Animal Care','T Level in Business and Administration'))";
            SqlDatabaseConncetionHelper.ExecuteSqlCommand(setTwoTLevelsToNotReviewed, ConnectionString);
        }

        protected static void SetThreeTLevelsToNotReviewed()
        {
            string SetTwoTLevelsToNotReviewed = "update TqAwardingOrganisation set reviewstatus = 1 where TlPathwayId in (select ao.TlPathwayId from TqAwardingOrganisation AO, TlPathway p where AO.TlPathwayId = p.id and ao.TlAwardingOrganisatonId = 1 and p.TlevelTitle in ('T Level in Agriculture, Environmental and Animal Care','T Level in Business and Administration','T Level in Digital Business Services'))";
            SqlDatabaseConncetionHelper.ExecuteSqlCommand(SetTwoTLevelsToNotReviewed, ConnectionString);
        }

        protected static void SetOneTLevelsToNotReviewed()
        {
            var setTwoTLevelsToNotReviewed = "update TqAwardingOrganisation set reviewstatus = 1 where TlPathwayId in (select ao.TlPathwayId from TqAwardingOrganisation AO, TlPathway p where AO.TlPathwayId = p.id and ao.TlAwardingOrganisatonId = 1 and p.TlevelTitle in ('T Level in Agriculture, Environmental and Animal Care'))";
            SqlDatabaseConncetionHelper.ExecuteSqlCommand(setTwoTLevelsToNotReviewed, ConnectionString);
        }

        public static void SetTLevelstoReviewedQueriedUnconfirmed()
        {
            var setThreeTLevelsToReviewed = "update TqAwardingOrganisation set reviewstatus = 2, modifiedon = GETDATE(), ModifiedBy = 'Test User' where TlPathwayId in (select ao.TlPathwayId from TqAwardingOrganisation AO, TlPathway p where AO.TlPathwayId = p.id and ao.TlAwardingOrganisatonId = 1 and p.TlevelTitle in ('T Level in Agriculture, Environmental and Animal Care','T Level in Business and Administration','T Level in Digital Business Services'))";
            SqlDatabaseConncetionHelper.ExecuteSqlCommand(setThreeTLevelsToReviewed, ConnectionString);
            var setThreeTLevelsToQueried = "update TqAwardingOrganisation set reviewstatus = 3, modifiedon = GETDATE(), ModifiedBy = 'Test User' where TlPathwayId in (select ao.TlPathwayId from TqAwardingOrganisation AO, TlPathway p where AO.TlPathwayId = p.id and ao.TlAwardingOrganisatonId = 1 and p.TlevelTitle in ('T Level in Digital Support Services','T Level in Education and Childcare','T Level in Engineering and Manufacturing'))";
            SqlDatabaseConncetionHelper.ExecuteSqlCommand(setThreeTLevelsToQueried, ConnectionString);
            var setFourTLevelsToUnconfirmed = "update TqAwardingOrganisation set reviewstatus = 1, modifiedon = GETDATE(), ModifiedBy = 'Test User' where TlPathwayId in (select ao.TlPathwayId from TqAwardingOrganisation AO, TlPathway p where AO.TlPathwayId = p.id and ao.TlAwardingOrganisatonId = 1 and p.TlevelTitle in ('T Level in Health','T Level in Healthcare Science','T Level in Legal, Finance and Accounting','T Level in Science'))";
            SqlDatabaseConncetionHelper.ExecuteSqlCommand(setFourTLevelsToUnconfirmed, ConnectionString);
        }
        public static string GetAcademicYear()
        {
            var getAcademicYear = "Select Name from dbo.AcademicYear where getdate() >= StartDate and getdate() <= EndDate" ;
            var academicYear = SqlDatabaseConncetionHelper.ReadDataFromDataBase(getAcademicYear, ConnectionString);
            var result = Convert.ToString(academicYear[0][0]);
            return result;
        }
        public static string GetAssessmentSeries()
        {
            var getAssessmentSeries = "Select Name from dbo.AssessmentSeries where getdate() >= StartDate and getdate() <= EndDate and ComponentType=1";
            var assessmentSeries = SqlDatabaseConncetionHelper.ReadDataFromDataBase(getAssessmentSeries, ConnectionString);
            var result = Convert.ToString(assessmentSeries[0][0]);
            return result;
        }

        public static string GetSpecialismAssessmentSeries()
        {
            var getSpecialismAssessmentSeries = "Select Name from dbo.AssessmentSeries where getdate() >= StartDate and getdate() <= EndDate and ComponentType=2";
            var specialismAssessmentSeries = SqlDatabaseConncetionHelper.ReadDataFromDataBase(getSpecialismAssessmentSeries, ConnectionString);
            var result = Convert.ToString(specialismAssessmentSeries[0][0]);
            return result;
        }

        public static void UpdateAcademicYearToPreviousYear()
        {
            var getAcademicYear = "Select Name from dbo.AcademicYear where getdate() >= StartDate and getdate() <= EndDate";
            var academicYear = SqlDatabaseConncetionHelper.ReadDataFromDataBase(getAcademicYear, ConnectionString);
            var result = Convert.ToString(academicYear[0][0]);
            var previousAcademicYear = result.Substring(0, 4);
            int x = Int32.Parse(previousAcademicYear);
            x = x - 1;
            var updateRegistrationYear = "Update TqRegistrationPathway set AcademicYear = " + x + " where tqregistrationprofileid in (select id from TqRegistrationProfile where  UniqueLearnerNumber like '99%')";
            SqlDatabaseConncetionHelper.ExecuteSqlCommand(updateRegistrationYear, ConnectionString);
        }

        public static void UpdateAssessmentSeriesToPastOne(string Uln)
        {
            var updateAssessmentSeries = "update TqPathwayAssessment set AssessmentSeriesId = 1 where Id in (select max(Id) from TqPathwayAssessment where TqRegistrationPathwayId in (select Id from TqRegistrationPathway where tqregistrationprofileid in (select id from TqRegistrationProfile where UniqueLearnerNumber = " + Uln + ")))";
            SqlDatabaseConncetionHelper.ExecuteSqlCommand(updateAssessmentSeries, ConnectionString);
        }

        public static int InsertSummer2021SpecialismAssessSeries()
        {
            var InsertSummer2021SpecialismSeriesSQL = "insert into assessmentSeries values (2,'Summer 2021', 'Summer 2021', '2021','2020-10-01','2021-08-01','2021-09-24','2021-11-17',GetDate(),'System',GetDate(),'System')";
            SqlDatabaseConncetionHelper.ExecuteSqlCommand(InsertSummer2021SpecialismSeriesSQL, ConnectionString);
            var getSummer2021SpecialismSeriesIDSQL = "select id from assessmentSeries where Name = 'Summer 2021' and ComponentType= 2";
            var Summer2021SeriesID = SqlDatabaseConncetionHelper.ReadDataFromDataBase(getSummer2021SpecialismSeriesIDSQL, ConnectionString);
            int resultStatusValue1 = Convert.ToInt32(Summer2021SeriesID[0][0]);
            return resultStatusValue1;     
        }

        public static void DeleteSummer2021SpecialismAssessSeries()
        {
            var deleteSummer2021SpecialismSeriesSQL = "delete from assessmentSeries where Name = 'Summer 2021' and ComponentType= 2;";
            SqlDatabaseConncetionHelper.ExecuteSqlCommand(deleteSummer2021SpecialismSeriesSQL, ConnectionString);
        }

    }
}
