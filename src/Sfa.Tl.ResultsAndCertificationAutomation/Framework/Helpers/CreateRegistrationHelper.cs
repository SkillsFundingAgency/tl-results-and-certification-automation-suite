using System;
using System.Linq;
using Sfa.Tl.ResultsAndCertificationAutomation.Data;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;

public class CreateRegistrationHelper : ElementHelper
{
    private static readonly string ConnectionString = WebDriverFactory.Config["DBConnectionString"];

    public static int CreateRegistrationProfileForNcfe(string uln)
    {
        var getReviewStatus = "Select ReviewStatus from TqAwardingOrganisation where TlPathwayId in (select Id from TlPathway where TLevelTitle = 'T Level in Education and Childcare')";
        var updateReviewStatus = "update TqAwardingOrganisation set reviewstatus = 2 where TlPathwayId in (select Id from TlPathway where TLevelTitle = 'T Level in Education and Childcare')";
        var getRegProfileId = "Select top 1 id from TqRegistrationProfile where UniqueLearnerNumber='"+ uln + "'";
        var reviewStatus1 = SqlDatabaseConncetionHelper.ReadDataFromDataBase(getReviewStatus, ConnectionString);
        int reviewStatus = Convert.ToInt32(reviewStatus1[0][0]);
        if (reviewStatus == 2)
        {
            Console.WriteLine("Do Nothing");
        }
        else
        {
            SqlDatabaseConncetionHelper.ExecuteSqlCommand(updateReviewStatus, ConnectionString);
        }

        SqlQueries.CreateRegProfile(uln);
        var profileId = SqlDatabaseConncetionHelper.ReadDataFromDataBase(getRegProfileId, ConnectionString);
        return (int)profileId.FirstOrDefault().FirstOrDefault();
    }

    public static int CreateRegistrationWithPathwayForNcfe(string uln)
    {
        var profileId = CreateRegistrationProfileForNcfe(uln);
        var createRegPathway = "Insert into TqRegistrationPathway values('" + profileId + "','18487' ,'2020', GETDATE(),NULL,1,0,GETDATE(),'System',NULL,NULL)";
        var getRegPathwayId = "select top 1 id from TqRegistrationPathway where TqRegistrationProfileId = '" + profileId + "'";
        SqlDatabaseConncetionHelper.ExecuteSqlCommand(createRegPathway, ConnectionString);
        var pathwayId = SqlDatabaseConncetionHelper.ReadDataFromDataBase(getRegPathwayId, ConnectionString);
        return (int)pathwayId.FirstOrDefault().FirstOrDefault();
    }
}