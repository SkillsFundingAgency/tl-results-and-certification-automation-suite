using Sfa.Tl.ResultsAndCertificationAutomation.Data;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers
{
    public class SqlQueriesBulkUploads
    {
        private static readonly string ConnectionString = WebDriverFactory.Config["DBConnectionString"];
        private static readonly string DeleteIpData = "Delete ip from IndustryPlacement ip join TqRegistrationPathway pw on ip.TqRegistrationPathwayId = pw.Id join TqRegistrationProfile rp on rp.Id=pw.TqRegistrationProfileId where rp.UniqueLearnerNumber like '94%'";
        private static readonly string DeleteEMData = "Delete qa from QualificationAchieved qa join TqRegistrationProfile rp on qa.TqRegistrationProfileId = rp.Id where rp.UniquelearnerNumber like '94%'";
        private static readonly string DeletePathwayResults = "Delete pr from TqPathwayResult pr join TqPathwayAssessment pa on pr.TqPathwayAssessmentId = pa.Id join TqRegistrationPathway rw ON pa.TqRegistrationPathwayId = rw.Id join TqRegistrationProfile rp on rw.TqRegistrationProfileId =rp.Id where UniqueLearnerNumber like '94%'";
        private static readonly string DeleteAssessmentSpecialism = "Delete sa from TqSpecialismAssessment sa join TqRegistrationSpecialism rs ON sa.TqRegistrationSpecialismId = rs.Id join TqRegistrationPathway rp on  rs.TqRegistrationPathwayId=rp.Id join TqRegistrationProfile tr on  rp.TqRegistrationProfileId =tr.Id where UniqueLearnerNumber like '94%'";
        private static readonly string DeleteAssessmentPathway = "Delete pa from TqPathwayAssessment pa join TqRegistrationPathway rw ON pa.TqRegistrationPathwayId = rw.Id join TqRegistrationProfile rp on rw.TqRegistrationProfileId =rp.Id where UniqueLearnerNumber like '94%'";
        private static readonly string DeleteRegistrationSpecialism = "Delete rs from TqRegistrationSpecialism rs join TqRegistrationPathway rw ON rs.TqRegistrationPathwayId = rw.Id join TqRegistrationProfile rp on rw.TqRegistrationProfileId =rp.Id where UniqueLearnerNumber like '94%'";
        private static readonly string DeleteRegistrationPathway = "Delete from TqRegistrationPathway where TqRegistrationProfileId In (select Id from TqRegistrationProfile where UniqueLearnerNumber like '94%')";
        private static readonly string DeleteRegistrationProfile = "Delete from TqRegistrationProfile where UniqueLearnerNumber like '94%'";

        public static void DeleteBulkUploadData()
        {
            SqlDatabaseConncetionHelper.ExecuteDeleteSqlCommand(DeleteIpData, ConnectionString);
            SqlDatabaseConncetionHelper.ExecuteDeleteSqlCommand(DeleteEMData, ConnectionString);
            SqlDatabaseConncetionHelper.ExecuteDeleteSqlCommand(DeletePathwayResults, ConnectionString);
            SqlDatabaseConncetionHelper.ExecuteDeleteSqlCommand(DeleteAssessmentPathway, ConnectionString);
            SqlDatabaseConncetionHelper.ExecuteDeleteSqlCommand(DeleteAssessmentSpecialism, ConnectionString);
            SqlDatabaseConncetionHelper.ExecuteDeleteSqlCommand(DeleteRegistrationSpecialism, ConnectionString);
            SqlDatabaseConncetionHelper.ExecuteDeleteSqlCommand(DeleteRegistrationPathway, ConnectionString);
            SqlDatabaseConncetionHelper.ExecuteDeleteSqlCommand(DeleteRegistrationProfile, ConnectionString);
        }
        public static void UpdateAcademicYear(int year)
        {
            string UpdateAcademicYear = "Update TqRegistrationPathway set AcademicYear= "+ year +" where TqRegistrationProfileId In (select Id from TqRegistrationProfile where UniqueLearnerNumber like '95%')";
            SqlDatabaseConncetionHelper.ExecuteDeleteSqlCommand(UpdateAcademicYear, ConnectionString);
        }
        public static void DeleteRegistrations(List<long> ulns)
        {
            var uln = string.Join(",", ulns);
            string DeletePathwayResults = "Delete pr from TqPathwayResult pr join TqPathwayAssessment pa on pr.TqPathwayAssessmentId = pa.Id join TqRegistrationPathway rw ON pa.TqRegistrationPathwayId = rw.Id join TqRegistrationProfile rp on rw.TqRegistrationProfileId = rp.Id where UniqueLearnerNumber in (" + uln + ")";
            string DeleteRegSpecialism = "Delete rs from TqRegistrationSpecialism rs join TqRegistrationPathway rw ON rs.TqRegistrationPathwayId = rw.Id join TqRegistrationProfile rp on rw.TqRegistrationProfileId =rp.Id where UniqueLearnerNumber in (" + uln + ")";
            string DeleteRegPathway = "Delete from TqRegistrationPathway where TqRegistrationProfileId In (select Id from TqRegistrationProfile where UniqueLearnerNumber in (" + uln + "))";
            string DeleteRegProfile = "Delete from TqRegistrationProfile where UniqueLearnerNumber in (" + uln + ")";
            string DeleteAssPathway = "Delete pa from TqPathwayAssessment pa join TqRegistrationPathway rw ON pa.TqRegistrationPathwayId = rw.Id join TqRegistrationProfile rp on rw.TqRegistrationProfileId =rp.Id where UniqueLearnerNumber in (" + uln + ")";
            string DeleteAssSpecialism = "Delete sa from TqSpecialismAssessment sa join TqRegistrationSpecialism rs ON sa.TqRegistrationSpecialismId = rs.Id join TqRegistrationPathway rp on  rs.TqRegistrationPathwayId=rp.Id join TqRegistrationProfile tr on  rp.TqRegistrationProfileId =tr.Id where UniqueLearnerNumber in (" + uln + ")";
            SqlDatabaseConncetionHelper.ExecuteDeleteSqlCommand(DeletePathwayResults, ConnectionString);
            SqlDatabaseConncetionHelper.ExecuteDeleteSqlCommand(DeleteAssPathway, ConnectionString);
            SqlDatabaseConncetionHelper.ExecuteDeleteSqlCommand(DeleteAssSpecialism, ConnectionString);
            SqlDatabaseConncetionHelper.ExecuteDeleteSqlCommand(DeleteRegSpecialism, ConnectionString);
            SqlDatabaseConncetionHelper.ExecuteDeleteSqlCommand(DeleteRegPathway, ConnectionString);
            SqlDatabaseConncetionHelper.ExecuteDeleteSqlCommand(DeleteRegProfile, ConnectionString);
        }
        public static List<long> getUlns(int ukprn)
        {
            string getUlnNo = "SELECT [tqProfile].[UniqueLearnerNumber] FROM [TqRegistrationPathway] AS [tqPathway] INNER JOIN [TqProvider] AS [tqProvider] ON [tqPathway].[TqProviderId] = [tqProvider].[Id] INNER JOIN [TqAwardingOrganisation] AS [tqAo] ON [tqProvider].[TqAwardingOrganisationId] = [tqAo].[Id] INNER JOIN [TlAwardingOrganisation] AS [tlAo] ON [tqAo].[TlAwardingOrganisatonId] = [tlAo].[Id] INNER JOIN [TqRegistrationProfile] AS [tqProfile] ON [tqPathway].[TqRegistrationProfileId] = [tqProfile].[Id] WHERE [tlAo].[UkPrn] = '" + ukprn + "'";
            List<long> ulnId = SqlDatabaseConncetionHelper.GetUlnsFromDatabse(getUlnNo, ConnectionString);
            return ulnId;
        }
        public static void DeleteAORecords(int ukprn)
        {
            var ulns = getUlns(ukprn);
            if(ulns.Count > 0)
            {
                DeleteRegistrations(ulns);
            }
            else { Console.WriteLine("No Ulns found"); }
        }
        public static void UpdateToWithdrawn(string uln)
        {
            string UpdatePathway = "Update TqRegistrationPathway set status=4, EndDate=GETDATE(),ModifiedOn=GETDATE(),ModifiedBy='SYSTEM' from TqRegistrationPathway rp join TqRegistrationProfile pr on rp.TqRegistrationProfileId = pr.Id where UniqueLearnerNumber = " + uln + "";
            string UpdateSpecialism = "Update TqRegistrationSpecialism set EndDate=GETDATE(),ModifiedOn=GETDATE(),ModifiedBy='SYSTEM' from TqRegistrationSpecialism rs join TqRegistrationPathway rp on rs.TqRegistrationPathwayId = rp.Id join TqRegistrationProfile pr on rp.TqRegistrationProfileId = pr.Id where UniqueLearnerNumber =" + uln + "";
            string UpdateAssessment = "Update TqPathwayAssessment set EndDate=GETDATE(),ModifiedOn=GETDATE(),ModifiedBy='SYSTEM' from TqPathwayAssessment pa join TqRegistrationPathway rp on rp.Id = pa.TqRegistrationPathwayId join TqRegistrationProfile pf on pf.id = rp.TqRegistrationProfileId where UniqueLearnerNumber =" + uln + "";
            string UpdateResult = "Update TqPathwayResult set EndDate=GETDATE(),ModifiedOn=GETDATE(),ModifiedBy='SYSTEM' from TqPathwayResult pr join TqPathwayAssessment pa on pr.TqPathwayAssessmentId = pa.Id join TqRegistrationPathway rp on rp.Id = pa.TqRegistrationPathwayId join TqRegistrationProfile pf on pf.id = rp.TqRegistrationProfileId where UniqueLearnerNumber =" + uln + "";
            SqlDatabaseConncetionHelper.ExecuteDeleteSqlCommand(UpdateResult, ConnectionString);
            SqlDatabaseConncetionHelper.ExecuteDeleteSqlCommand(UpdateAssessment, ConnectionString);
            SqlDatabaseConncetionHelper.ExecuteDeleteSqlCommand(UpdateSpecialism, ConnectionString);
            SqlDatabaseConncetionHelper.ExecuteDeleteSqlCommand(UpdatePathway, ConnectionString);
        }
    }
}
