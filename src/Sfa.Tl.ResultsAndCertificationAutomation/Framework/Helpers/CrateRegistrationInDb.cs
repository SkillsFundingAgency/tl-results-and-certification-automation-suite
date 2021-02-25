using Sfa.Tl.ResultsAndCertificationAutomation.Data;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers
{
    public class CrateRegistrationInDb : ElementHelper
    {
        //public string uln = UlnHelper.GenerateUln().ToString();
        private static readonly string ConnectionString = WebDriverFactory.Config["DBConnectionString"];
        public void CreateDbRegistation()
        {
            var uln = UlnHelper.GenerateUln().ToString();
            var profileId = SqlQueries.CreateRegistrationProfile(uln);
            var pathwayId = SqlQueries.CreateRegistrationPathway(profileId);
            SqlQueries.CreateRegSpecialism(pathwayId);
        }

        public void CreateDbRegWithAssessment(string uln)
        {
            var profileId = SqlQueries.CreateRegistrationProfile(uln);
            var pathwayId = SqlQueries.CreateRegistrationPathway(profileId);
            SqlQueries.CreateRegSpecialism(pathwayId);
            SqlQueries.CreatePathwayAssessment(pathwayId);
        }
        public void CreateDbRegWithResult(string uln)
        {
            //var uln = UlnHelper.GenerateUln().ToString();
            var profileId = SqlQueries.CreateRegistrationProfile(uln);
            var pathwayId = SqlQueries.CreateRegistrationPathway(profileId);
            SqlQueries.CreateRegSpecialism(pathwayId);
            var pathwayAssessmentId = SqlQueries.CreatePathwayAssessment(pathwayId);
            SqlQueries.CreatePathwayResult(pathwayAssessmentId);
        }
        public void CreateDbRegInWithdrawn(string uln)
        {
            SqlQueries.UpdateRegWithdrawn(uln);
        }
        public void DeleteRegistrationFromTables(string uln)
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

    }
}
