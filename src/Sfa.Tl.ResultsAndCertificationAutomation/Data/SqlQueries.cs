using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Data
{
    public class SqlQueries
    {
        private static readonly string ConnectionString = WebDriverFactory.Config["DBConnectionString"];
        //Delete from Registration Tables
        private static readonly string DeleteRegistrationSpecialism = "Delete rs from TqRegistrationSpecialism rs join TqRegistrationPathway rw ON rs.TqRegistrationPathwayId = rw.Id join TqRegistrationProfile rp on rw.TqRegistrationProfileId =rp.Id where UniqueLearnerNumber like '99%'";
        private static readonly string DeleteRegistrationPathway = "Delete from TqRegistrationPathway where TqRegistrationProfileId In (select Id from TqRegistrationProfile where UniqueLearnerNumber like '99%')";
        private static readonly string DeleteRegistrationProfile = "Delete from TqRegistrationProfile where UniqueLearnerNumber like '99%'";

        public static void DeleteFromRegistrationTables()
        {
            SqlDatabaseConncetionHelper.ExecuteDeleteSqlCommand(DeleteRegistrationSpecialism, ConnectionString);
            SqlDatabaseConncetionHelper.ExecuteDeleteSqlCommand(DeleteRegistrationPathway, ConnectionString);
            SqlDatabaseConncetionHelper.ExecuteDeleteSqlCommand(DeleteRegistrationProfile, ConnectionString);
        }
    }
}
