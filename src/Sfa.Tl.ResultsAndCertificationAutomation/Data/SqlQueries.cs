using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;
using System;
using System.IO;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Data
{
    public class SqlQueries
    {
        private static readonly string ConnectionString = ConfigHelper.GetDBConnectionString();
        //Delete from Registration Tables
        private static readonly string DeleteRegistrationSpecialism = "Delete rs from TqRegistrationSpecialism rs join TqRegistrationPathway rw ON rs.TqRegistrationPathwayId = rw.Id join TqRegistrationProfile rp on rw.TqRegistrationProfileId =rp.Id where UniqueLearnerNumber like '99%'";
        private static readonly string DeleteRegistrationPathway = "Delete from TqRegistrationPathway where TqRegistrationProfileId In (select Id from TqRegistrationProfile where UniqueLearnerNumber like '99%')";
        private static readonly string DeleteRegistrationProfile = "Delete from TqRegistrationProfile where UniqueLearnerNumber like '99%'";
        private static readonly string DeleteAssessmentPathway = "Delete pa from TqPathwayAssessment pa join TqRegistrationPathway rw ON pa.TqRegistrationPathwayId = rw.Id join TqRegistrationProfile rp on rw.TqRegistrationProfileId =rp.Id where UniqueLearnerNumber like '99%'";
        private static readonly string DeleteAssessmentSpecialism = "Delete sa from TqSpecialismAssessment sa join TqRegistrationSpecialism rs ON sa.TqRegistrationSpecialismId = rs.Id join TqRegistrationPathway rp on  rs.TqRegistrationPathwayId=rp.Id join TqRegistrationProfile tr on  rp.TqRegistrationProfileId =tr.Id where UniqueLearnerNumber like '99%'";

        public static void DeleteFromRegistrationTables()
        {
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
        public static void InsertSingleTlRoute()
        {
        }

        public static void SeedScenarioData(string sqlFile)
        {
            string filepath = $"{AppDomain.CurrentDomain.BaseDirectory}Data\\{sqlFile}.sql";
            var sqlfileContent = File.ReadAllText(filepath);
            SqlDatabaseConncetionHelper.ExecuteSqlFile(sqlfileContent, ConnectionString);
        }
    }
}
