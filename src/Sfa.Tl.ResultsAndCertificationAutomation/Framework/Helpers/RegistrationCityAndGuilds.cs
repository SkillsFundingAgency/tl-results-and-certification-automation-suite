using System.Linq;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.TestSupport;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers
{
    public class RegistrationCityAndGuilds
    {
        private static readonly string ConnectionString = WebDriverFactory.Config["DBConnectionString"];
        private static int InsertRegistrationProfile(string uln)
        {
            var createRegistrationProfile = "Insert into TqRegistrationProfile values(" + uln + ", 'Db FirstName','Db LastName','2001-01-01',Null,Null,Null,Null,Null,GETDATE(),'System', GETDATE(),'System')";
            var getRegProfileId = "Select top 1 id from TqRegistrationProfile where UniqueLearnerNumber='" + uln + "'";
            SqlDatabaseConncetionHelper.ExecuteSqlCommand(createRegistrationProfile, ConnectionString);
            var profileId = SqlDatabaseConncetionHelper.ReadDataFromDataBase(getRegProfileId, ConnectionString);
            return (int)profileId.FirstOrDefault().FirstOrDefault();
        }
        private static int InsertRegistrationPathway(int profileId)
        {
            var tqProviderId = Constants.CityAndGuildsProviderId;
            var createRegPathway = "Insert into TqRegistrationPathway values('" + profileId + "', '" + tqProviderId + "','2020', GETDATE(),NULL,1,1,GETDATE(),'System',NULL,NULL)";
            var getRegPathwayId = "select top 1 id from TqRegistrationPathway where TqRegistrationProfileId = '" + profileId + "'";
            SqlDatabaseConncetionHelper.ExecuteSqlCommand(createRegPathway, ConnectionString);
            var pathwayId = SqlDatabaseConncetionHelper.ReadDataFromDataBase(getRegPathwayId, ConnectionString);
            return (int)pathwayId.FirstOrDefault().FirstOrDefault();
        }
        private static int InsertRegistrationSpecialism1(int pathwayId)
        {
            var tlSpecialismId1 = Constants.HeatingSpecialismId;
            var createRegSpecialism = "Insert into TqRegistrationSpecialism values('" + pathwayId + "','" + tlSpecialismId1 + "',GETDATE(),NULL,1,0,GETDATE(),'System',Null,Null )";
            var getSpecialismId = "select top 1 id from TqRegistrationSpecialism where TqRegistrationPathwayId  = '" + pathwayId + "'";
            SqlDatabaseConncetionHelper.ExecuteSqlCommand(createRegSpecialism, ConnectionString);
            var specialismId = SqlDatabaseConncetionHelper.ReadDataFromDataBase(getSpecialismId, ConnectionString);
            return (int)specialismId.FirstOrDefault().FirstOrDefault();
        }
        private static int InsertRegistrationSpecialism2(int pathwayId)
        {
            var tlSpecialismId2 = Constants.VentilationSpecialismId;
            var createRegSpecialism = "Insert into TqRegistrationSpecialism values('" + pathwayId + "','" + tlSpecialismId2 + "',GETDATE(),NULL,1,0,GETDATE(),'System',Null,Null )";
            var getSpecialismId = "select top 1 id from TqRegistrationSpecialism where TqRegistrationPathwayId  = '" + pathwayId + "'";
            SqlDatabaseConncetionHelper.ExecuteSqlCommand(createRegSpecialism, ConnectionString);
            var specialismId = SqlDatabaseConncetionHelper.ReadDataFromDataBase(getSpecialismId, ConnectionString);
            return (int)specialismId.FirstOrDefault().FirstOrDefault();
        }
        private static int InsertCoreAssessment(int pathwayId)
        {
            var pathwayAssessmentSeriesId = Constants.PathwayAssessmentSeriesId;
            var createPathwayAssessment = "Insert into TqPathwayAssessment values('" + pathwayId + "','"+ pathwayAssessmentSeriesId +"',GETDATE(),NULL,1,0,GETDATE(),'System',Null,Null )";
            var getRegPathwayId = "select top 1 id from TqPathwayAssessment where TqRegistrationPathwayId  = '" + pathwayId + "'";
            SqlDatabaseConncetionHelper.ExecuteSqlCommand(createPathwayAssessment, ConnectionString);
            var regPathwayId = SqlDatabaseConncetionHelper.ReadDataFromDataBase(getRegPathwayId, ConnectionString);
            return (int)regPathwayId.FirstOrDefault().FirstOrDefault();
        }
        private static void InsertSpecialismAssessment(int specialismId)
        {
            var tlAssessmentSeriesId = Constants.TlAssessmentSeriesId;
            var createSpecialismAssessment = "Insert into TqSpecialismAssessment values('" + specialismId + "','" + tlAssessmentSeriesId + "',GETDATE(),Null,1,0,GETDATE(),'System',GETDATE(),'System')";
            SqlDatabaseConncetionHelper.ExecuteSqlCommand(createSpecialismAssessment, ConnectionString);
        }
        private static void InsertCoreResult(int coreAssessmentId)
        {
            var coreAssessmentSeriesId = Constants.PathwayAssessmentSeriesId;
            var createPathwayResult = "Insert into TqPathwayResult values ('" + coreAssessmentId + "','"+ coreAssessmentSeriesId + "',GETDATE(),NULL,Null,1,0,GETDATE(),'SYSTEM',NULL,'SYSTEM')";
            SqlDatabaseConncetionHelper.ExecuteSqlCommand(createPathwayResult, ConnectionString);
        }
        private static void InsertAssessmentResult(int specialismAssessmentId)
        {
            var tlAssessmentSeriesId = Constants.TlAssessmentSeriesId;
            var createPathwayResult = "Insert into TqSpecialismResult values ('" + specialismAssessmentId + "','"+ tlAssessmentSeriesId +"',GETDATE(),NULL,Null,1,0,GETDATE(),'SYSTEM',NULL,'SYSTEM')";
            SqlDatabaseConncetionHelper.ExecuteSqlCommand(createPathwayResult, ConnectionString);
        }
        public void CreateRegistration(string uln)
        {
            var profileId = InsertRegistrationProfile(uln);
            var pathwayId = InsertRegistrationPathway(profileId);
            InsertRegistrationSpecialism1(pathwayId);
            InsertRegistrationSpecialism2(pathwayId);
        }

        public void RegWithCoreAssessment(string uln)
        {
            var profileId = InsertRegistrationProfile(uln);
            var pathwayId = InsertRegistrationPathway(profileId);
            InsertRegistrationSpecialism1(pathwayId);
            InsertRegistrationSpecialism2(pathwayId);
            InsertCoreAssessment(pathwayId);
        }
        public void RegWithCoreAndSpecialismAssessment(string uln)
        {
            var profileId = InsertRegistrationProfile(uln);
            var pathwayId = InsertRegistrationPathway(profileId);
            var specialismId1 = InsertRegistrationSpecialism1(pathwayId);
            var specialismId2 = InsertRegistrationSpecialism2(pathwayId);
            InsertCoreAssessment(pathwayId);
            InsertSpecialismAssessment(specialismId1);
            InsertSpecialismAssessment(specialismId2);
        }
        public void RegWithCoreAndSpecialismAssessmentResults(string uln)
        {
            var profileId = InsertRegistrationProfile(uln);
            var pathwayId = InsertRegistrationPathway(profileId);
            var specialismId1 = InsertRegistrationSpecialism1(pathwayId);
            var specialismId2 = InsertRegistrationSpecialism2(pathwayId);
            var coreAssessmentId = InsertCoreAssessment(pathwayId);
            InsertSpecialismAssessment(specialismId1);
            InsertSpecialismAssessment(specialismId2);
            InsertCoreResult(coreAssessmentId);
            InsertAssessmentResult(specialismId1);
            InsertAssessmentResult(specialismId2);
        }
    }
}
