using System;
using System.Collections.Generic;

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
            var updateAcademicYear = "Update TqRegistrationPathway set AcademicYear= "+ year +" where TqRegistrationProfileId In (select Id from TqRegistrationProfile where UniqueLearnerNumber like '95%')";
            SqlDatabaseConncetionHelper.ExecuteDeleteSqlCommand(updateAcademicYear, ConnectionString);
        }
        public static void UpdateAcademicYearTo2020()
        {
            var updateAcademicYear = "Update TqRegistrationPathway set AcademicYear= 2020 where TqRegistrationProfileId In (select Id from TqRegistrationProfile where UniqueLearnerNumber like '99%')";
            SqlDatabaseConncetionHelper.ExecuteDeleteSqlCommand(updateAcademicYear, ConnectionString);
        }

        private static void DeleteRegistrations(List<long> ulns)
        {
            var uln = string.Join(",", ulns);
            var deletePathwayResults = "Delete pr from TqPathwayResult pr join TqPathwayAssessment pa on pr.TqPathwayAssessmentId = pa.Id join TqRegistrationPathway rw ON pa.TqRegistrationPathwayId = rw.Id join TqRegistrationProfile rp on rw.TqRegistrationProfileId = rp.Id where UniqueLearnerNumber in (" + uln + ")";
            var deleteRegSpecialism = "Delete rs from TqRegistrationSpecialism rs join TqRegistrationPathway rw ON rs.TqRegistrationPathwayId = rw.Id join TqRegistrationProfile rp on rw.TqRegistrationProfileId =rp.Id where UniqueLearnerNumber in (" + uln + ")";
            var deleteRegPathway = "Delete from TqRegistrationPathway where TqRegistrationProfileId In (select Id from TqRegistrationProfile where UniqueLearnerNumber in (" + uln + "))";
            var deleteRegProfile = "Delete from TqRegistrationProfile where UniqueLearnerNumber in (" + uln + ")";
            var deleteAssPathway = "Delete pa from TqPathwayAssessment pa join TqRegistrationPathway rw ON pa.TqRegistrationPathwayId = rw.Id join TqRegistrationProfile rp on rw.TqRegistrationProfileId =rp.Id where UniqueLearnerNumber in (" + uln + ")";
            var deleteAssSpecialism = "Delete sa from TqSpecialismAssessment sa join TqRegistrationSpecialism rs ON sa.TqRegistrationSpecialismId = rs.Id join TqRegistrationPathway rp on  rs.TqRegistrationPathwayId=rp.Id join TqRegistrationProfile tr on  rp.TqRegistrationProfileId =tr.Id where UniqueLearnerNumber in (" + uln + ")";
            SqlDatabaseConncetionHelper.ExecuteDeleteSqlCommand(deletePathwayResults, ConnectionString);
            SqlDatabaseConncetionHelper.ExecuteDeleteSqlCommand(deleteAssPathway, ConnectionString);
            SqlDatabaseConncetionHelper.ExecuteDeleteSqlCommand(deleteAssSpecialism, ConnectionString);
            SqlDatabaseConncetionHelper.ExecuteDeleteSqlCommand(deleteRegSpecialism, ConnectionString);
            SqlDatabaseConncetionHelper.ExecuteDeleteSqlCommand(deleteRegPathway, ConnectionString);
            SqlDatabaseConncetionHelper.ExecuteDeleteSqlCommand(deleteRegProfile, ConnectionString);
        }

        private static List<long> GetUlns(int ukprn)
        {
            var getUlnNo = "SELECT [tqProfile].[UniqueLearnerNumber] FROM [TqRegistrationPathway] AS [tqPathway] INNER JOIN [TqProvider] AS [tqProvider] ON [tqPathway].[TqProviderId] = [tqProvider].[Id] INNER JOIN [TqAwardingOrganisation] AS [tqAo] ON [tqProvider].[TqAwardingOrganisationId] = [tqAo].[Id] INNER JOIN [TlAwardingOrganisation] AS [tlAo] ON [tqAo].[TlAwardingOrganisatonId] = [tlAo].[Id] INNER JOIN [TqRegistrationProfile] AS [tqProfile] ON [tqPathway].[TqRegistrationProfileId] = [tqProfile].[Id] WHERE [tlAo].[UkPrn] = '" + ukprn + "'";
            List<long> ulnId = SqlDatabaseConncetionHelper.GetUlnsFromDatabse(getUlnNo, ConnectionString);
            return ulnId;
        }
        public static void DeleteAoRecords(int ukprn)
        {
            var ulns = GetUlns(ukprn);
            if(ulns.Count > 0)
            {
                DeleteRegistrations(ulns);
            }
            else { Console.WriteLine("No Ulns found"); }
        }
        public static void UpdateToWithdrawn(string uln)
        {
            var updatePathway = "Update TqRegistrationPathway set status=4, EndDate=GETDATE(),ModifiedOn=GETDATE(),ModifiedBy='SYSTEM' from TqRegistrationPathway rp join TqRegistrationProfile pr on rp.TqRegistrationProfileId = pr.Id where UniqueLearnerNumber = " + uln + "";
            var updateSpecialism = "Update TqRegistrationSpecialism set EndDate=GETDATE(),ModifiedOn=GETDATE(),ModifiedBy='SYSTEM' from TqRegistrationSpecialism rs join TqRegistrationPathway rp on rs.TqRegistrationPathwayId = rp.Id join TqRegistrationProfile pr on rp.TqRegistrationProfileId = pr.Id where UniqueLearnerNumber =" + uln + "";
            var updateAssessment = "Update TqPathwayAssessment set EndDate=GETDATE(),ModifiedOn=GETDATE(),ModifiedBy='SYSTEM' from TqPathwayAssessment pa join TqRegistrationPathway rp on rp.Id = pa.TqRegistrationPathwayId join TqRegistrationProfile pf on pf.id = rp.TqRegistrationProfileId where UniqueLearnerNumber =" + uln + "";
            var updateResult = "Update TqPathwayResult set EndDate=GETDATE(),ModifiedOn=GETDATE(),ModifiedBy='SYSTEM' from TqPathwayResult pr join TqPathwayAssessment pa on pr.TqPathwayAssessmentId = pa.Id join TqRegistrationPathway rp on rp.Id = pa.TqRegistrationPathwayId join TqRegistrationProfile pf on pf.id = rp.TqRegistrationProfileId where UniqueLearnerNumber =" + uln + "";
            SqlDatabaseConncetionHelper.ExecuteDeleteSqlCommand(updateResult, ConnectionString);
            SqlDatabaseConncetionHelper.ExecuteDeleteSqlCommand(updateAssessment, ConnectionString);
            SqlDatabaseConncetionHelper.ExecuteDeleteSqlCommand(updateSpecialism, ConnectionString);
            SqlDatabaseConncetionHelper.ExecuteDeleteSqlCommand(updatePathway, ConnectionString);
        }
    }
}
