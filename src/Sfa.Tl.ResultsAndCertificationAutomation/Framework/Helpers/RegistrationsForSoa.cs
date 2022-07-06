using System.Linq;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.TestSupport;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;

public static class RegistrationsForSoa
{
    private static readonly string ConnectionString = WebDriverFactory.Config["DBConnectionString"];
    private static int InsertRegistrationProfile(string uln)
    {
        var createRegistrationProfile = "Insert into TqRegistrationProfile values(" + uln + ", 'Jonny','Walker','2001-01-01',Null,Null,Null,Null,Null,Null,Null,GETDATE(),'System', GETDATE(),'System')";
        var getRegProfileId = "Select top 1 id from TqRegistrationProfile where UniqueLearnerNumber='" + uln + "'";
        SqlDatabaseConncetionHelper.ExecuteSqlCommand(createRegistrationProfile, ConnectionString);
        var profileId = SqlDatabaseConncetionHelper.ReadDataFromDataBase(getRegProfileId, ConnectionString);
        return (int)profileId.FirstOrDefault().FirstOrDefault();
    }
    private static int InsertRegistrationPathway(int profileId,string providerId)
    {
        var createRegPathway = "Insert into TqRegistrationPathway values('" + profileId + "', '" + providerId + "','2020', GETDATE(),NULL,1,0,GETDATE(),'System',NULL,NULL)";
        var getRegPathwayId = "select top 1 id from TqRegistrationPathway where TqRegistrationProfileId = '" + profileId + "'";
        SqlDatabaseConncetionHelper.ExecuteSqlCommand(createRegPathway, ConnectionString);
        var pathwayId = SqlDatabaseConncetionHelper.ReadDataFromDataBase(getRegPathwayId, ConnectionString);
        return (int)pathwayId.FirstOrDefault().FirstOrDefault();
    }
    private static int InsertSpecialism(int pathwayId,string specialismId)
    {
        var createRegSpecialism = "Insert into TqRegistrationSpecialism values('" + pathwayId + "','" + specialismId + "',GETDATE(),NULL,1,0,GETDATE(),'System',Null,Null )";
        var getSpecialismId = "select top 1 id from TqRegistrationSpecialism where TqRegistrationPathwayId  = '" + pathwayId + "'";
        SqlDatabaseConncetionHelper.ExecuteSqlCommand(createRegSpecialism, ConnectionString);
        var specialism1Id = SqlDatabaseConncetionHelper.ReadDataFromDataBase(getSpecialismId, ConnectionString);
        return (int)specialism1Id.FirstOrDefault().FirstOrDefault();
    }

    public static void RegistrationForEducationChildCare(string uln)
    {
        var tqProviderId = Constants.EducationChildcareProvider;
        var tlSpecialismId = Constants.EarlyYearsEducator;
        var profileId = InsertRegistrationProfile(uln);
        var pathwayId = InsertRegistrationPathway(profileId, tqProviderId);
        InsertSpecialism(pathwayId, tlSpecialismId);
    }
    public static void RegistrationForHealth(string uln)
    {
        var tqProviderId = Constants.HealthProvider;
        var tlSpecialismId = Constants.SupportingHealthCare;
        var profileId = InsertRegistrationProfile(uln);
        var pathwayId = InsertRegistrationPathway(profileId, tqProviderId);
        InsertSpecialism(pathwayId, tlSpecialismId);
    }
    public static void RegistrationForScienceAndTech(string uln)
    {
        var tqProviderId = Constants.ScienceProvider;
        var tlSpecialismId = Constants.TechLaboratory;
        var profileId = InsertRegistrationProfile(uln);
        var pathwayId = InsertRegistrationPathway(profileId, tqProviderId);
        InsertSpecialism(pathwayId, tlSpecialismId);
    }
    public static void RegistrationForDigitalSupportService(string uln)
    {
        var tqProviderId = Constants.DigitalServiceProvider;
        var tlSpecialismId = Constants.DigitalSupport;
        var profileId = InsertRegistrationProfile(uln);
        var pathwayId = InsertRegistrationPathway(profileId, tqProviderId);
        InsertSpecialism(pathwayId, tlSpecialismId);
    }
    public static void RegistrationForDigitalBusinessService(string uln)
    {
        var tqProviderId = Constants.DigitalBusinessServiceProvider;
        var tlSpecialismId = Constants.DataTechnician;
        var profileId = InsertRegistrationProfile(uln);
        var pathwayId = InsertRegistrationPathway(profileId, tqProviderId);
        InsertSpecialism(pathwayId, tlSpecialismId);
    }
    public static void RegistrationForDigitalProductionDesign(string uln)
    {
        var tqProviderId = Constants.DigitalProducationDesignProvider;
        var tlSpecialismId = Constants.DigitalDesignDev;
        var profileId = InsertRegistrationProfile(uln);
        var pathwayId = InsertRegistrationPathway(profileId, tqProviderId);
        InsertSpecialism(pathwayId, tlSpecialismId);
    }
    public static void RegistrationForDesignSurveyPlanning(string uln)
    {
        var tqProviderId = Constants.DesignSurveyPlanningProvider;
        var tlSpecialismId = Constants.CivilEngineering;
        var profileId = InsertRegistrationProfile(uln);
        var pathwayId = InsertRegistrationPathway(profileId, tqProviderId);
        InsertSpecialism(pathwayId, tlSpecialismId);
    }
    public static void RegistrationForBuildingServiceEngineering(string uln)
    {
        var tqProviderId = Constants.BuildingServicesEngineeringProvider;
        var tlSpecialismId = Constants.GasEngineering;
        var profileId = InsertRegistrationProfile(uln);
        var pathwayId = InsertRegistrationPathway(profileId, tqProviderId);
        InsertSpecialism(pathwayId, tlSpecialismId);
    }
    public static void RegistrationForOnsiteConstruction(string uln)
    {
        var tqProviderId = Constants.OnsiteConstructionProvider;
        var tlSpecialismId = Constants.Painting;
        var profileId = InsertRegistrationProfile(uln);
        var pathwayId = InsertRegistrationPathway(profileId, tqProviderId);
        InsertSpecialism(pathwayId, tlSpecialismId);
    }
}