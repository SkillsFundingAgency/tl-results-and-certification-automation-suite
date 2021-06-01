using Sfa.Tl.ResultsAndCertificationAutomation.Data;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers
{
    public class CrateRegistrationInDb : ElementHelper
    {
        //public string uln = UlnHelper.GenerateUln().ToString();
        private static readonly string ConnectionString = WebDriverFactory.Config["DBConnectionString"];
        public void CreateDbRegistation(string uln)
        {
            var profileId = SqlQueries.CreateRegistrationProfile(uln);
            var pathwayId = SqlQueries.CreateRegistrationPathway(profileId);
            SqlQueries.CreateRegSpecialism(pathwayId);
        }
        public void CreateDbRegistationForLrs(string uln)
        {
            var profileId = SqlQueries.CreateRegistrationProfileForLrs(uln);
            var pathwayId = SqlQueries.CreateRegistrationPathwayForLrs(profileId);
            SqlQueries.CreateRegSpecialismForLrs(pathwayId);
            SqlQueries.CreateQualificationAcheivedForLrs(profileId);
        }
        public void CreateDbRegistationForLrsWithEMAcheived(string uln)
        {
            var profileId = SqlQueries.CreateRegistrationProfileForLrsWithEM(uln);
            var pathwayId = SqlQueries.CreateRegistrationPathwayForLrs(profileId);
            SqlQueries.CreateRegSpecialismForLrs(pathwayId);
            SqlQueries.CreateQualificationAcheivedForLrs(profileId);
        }
        public void CreateDbRegistationForLrsWithEMAndIP(string uln)
        {
            var profileId = SqlQueries.CreateRegistrationProfileForLrsWithEM(uln);
            var pathwayId = SqlQueries.CreateRegistrationPathwayForLrs(profileId);
            SqlQueries.CreateRegSpecialismForLrs(pathwayId);
            SqlQueries.CreateQualificationAcheivedForLrs(profileId);
            SqlQueries.CreateIndustryPlacement(pathwayId, 1);
        }
        public void CreateLrsRegWithEMAndIPForDudley(string uln)
        {
            var profileId = SqlQueries.CreateRegistrationProfileForLrsWithEM(uln);
            var pathwayId = SqlQueries.CreateRegistrationPathwayForDudley(profileId);
            SqlQueries.CreateRegSpecialismForLrs(pathwayId);
            SqlQueries.CreateQualificationAcheivedForLrs(profileId);
            SqlQueries.CreateIndustryPlacement(pathwayId, 1);
        }
        public void CreateDbRegistationNonLrsWithEMAndIP(string uln)
        {
            var profileId = SqlQueries.CreateRegistrationProfileForNonLrsWithEM(uln);
            var pathwayId = SqlQueries.CreateRegistrationPathwayForLrs(profileId);
            SqlQueries.CreateRegSpecialismForLrs(pathwayId);
            SqlQueries.CreateIndustryPlacement(pathwayId, 1);
        }
        public void CreateDbRegWithAssessment(string uln)
        {
            var profileId = SqlQueries.CreateRegistrationProfile(uln);
            var pathwayId = SqlQueries.CreateRegistrationPathway(profileId);
            SqlQueries.CreateRegSpecialism(pathwayId);
            SqlQueries.CreatePathwayAssessment(pathwayId);
        }
        public void CreateDbRegWithAssessmentForLrs(string uln)
        {
            var profileId = SqlQueries.CreateRegistrationProfileForLrs(uln);
            var pathwayId = SqlQueries.CreateRegistrationPathwayForLrs(profileId);
            SqlQueries.CreateRegSpecialismForLrs(pathwayId);
            SqlQueries.CreatePathwayAssessment(pathwayId);
            SqlQueries.CreateQualificationAcheivedForLrs(profileId);
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
        public void CreateDbRegWithResultForLrs(string uln)
        {
            //var uln = UlnHelper.GenerateUln().ToString();
            var profileId = SqlQueries.CreateRegistrationProfileForLrs(uln);
            var pathwayId = SqlQueries.CreateRegistrationPathwayForLrs(profileId);
            SqlQueries.CreateRegSpecialismForLrs(pathwayId);
            var pathwayAssessmentId = SqlQueries.CreatePathwayAssessment(pathwayId);
            SqlQueries.CreatePathwayResult(pathwayAssessmentId);
            SqlQueries.CreateQualificationAcheivedForLrs(profileId);
        }
        public void CreateDbRegWithIpForLrs(string uln,int status)
        {
            var profileId = SqlQueries.CreateRegistrationProfileForLrsWithEM(uln);
            var pathwayId = SqlQueries.CreateRegistrationPathwayForLrs(profileId);
            SqlQueries.CreateRegSpecialismForLrs(pathwayId);
            var pathwayAssessmentId = SqlQueries.CreatePathwayAssessment(pathwayId);
            SqlQueries.CreatePathwayResult(pathwayAssessmentId);
            SqlQueries.CreateQualificationAcheivedForLrs(profileId);
            SqlQueries.CreateIndustryPlacement(pathwayId, status);
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

        public void DeleteLrsRecordsFromTables(string uln)
        {
            var pathwayId = getPathwayId(uln);
            string DeleteIpRecords = "Delete from IndustryPlacement where TqRegistrationPathwayId = '" + pathwayId + "'";
            SqlDatabaseConncetionHelper.ExecuteDeleteSqlCommand(DeleteIpRecords, ConnectionString);
            var profileId = GetProfileID(uln);
            string DeleteQualificationAcheived = "Delete from QualificationAchieved where TqRegistrationProfileId = '" + profileId + "'";
            SqlDatabaseConncetionHelper.ExecuteDeleteSqlCommand(DeleteQualificationAcheived, ConnectionString);
            DeleteRegistrationFromTables(uln);
        }
        public void DeleteLrsDataFromTables(string uln)
        {
            var pathwayIds = getPathwayIds(uln);
            string DeleteIpRecords = "Delete from IndustryPlacement where TqRegistrationPathwayId in (" + string.Join(",", pathwayIds)+")";
            SqlDatabaseConncetionHelper.ExecuteDeleteSqlCommand(DeleteIpRecords, ConnectionString);
            var profileId = GetProfileID(uln);
            string DeleteQualificationAcheived = "Delete from QualificationAchieved where TqRegistrationProfileId = '" + profileId + "'";
            SqlDatabaseConncetionHelper.ExecuteDeleteSqlCommand(DeleteQualificationAcheived, ConnectionString);
            DeleteRegistrationFromTables(uln);
        }
        public static int GetProfileID(string uln)
        {
            string getProfileId = "Select top 1 Id from TqRegistrationProfile where UniqueLearnerNumber = '" + uln + "'";
            var profileId = SqlDatabaseConncetionHelper.ReadDataFromDataBase(getProfileId, ConnectionString);
            int result = Convert.ToInt32(profileId[0][0]);
            return result;
        }
        public static int getPathwayId(string uln)
        {
            string getPathwayId = "select rs.TqRegistrationPathwayId from TqRegistrationSpecialism rs join TqRegistrationPathway rp on rp.Id = rs.TqRegistrationPathwayId join TqRegistrationProfile pr on pr.Id = rp.TqRegistrationProfileId where pr.UniqueLearnerNumber = '" + uln + "'";
            var pathwayId = SqlDatabaseConncetionHelper.ReadDataFromDataBase(getPathwayId, ConnectionString);
            int result = Convert.ToInt32(pathwayId[0][0]);
            return result;
        }
        public static List<int> getPathwayIds(string uln)
        {
            string getPathwayId = "select rs.TqRegistrationPathwayId from TqRegistrationSpecialism rs join TqRegistrationPathway rp on rp.Id = rs.TqRegistrationPathwayId join TqRegistrationProfile pr on pr.Id = rp.TqRegistrationProfileId where pr.UniqueLearnerNumber = '" + uln + "'";
            var pathwayIds = SqlDatabaseConncetionHelper.ReadDataFromDataBase(getPathwayId, ConnectionString);
            return pathwayIds.Select(x => Convert.ToInt32(x[0])).ToList();
        }

        public void CreateDbRegistationForLrsMathsAEnglishNA(string uln)
        {
            var profileId = SqlQueries.CreateRegistrationProfileForLrsMathsAndEnglishNotAchieved(uln);
            var pathwayId = SqlQueries.CreateRegistrationPathwayForLrs(profileId);
            SqlQueries.CreateRegSpecialismForLrs(pathwayId);
            SqlQueries.CreateQualificationAcheivedForLrsMathsAEnglishNA(profileId);
        }

        public void CreateDbRegistationForLrsMathsNAEnglishA(string uln)
        {
            var profileId = SqlQueries.CreateRegistrationProfileForLrsMathsAndEnglishNotAchieved(uln);
            var pathwayId = SqlQueries.CreateRegistrationPathwayForLrs(profileId);
            SqlQueries.CreateRegSpecialismForLrs(pathwayId);
            SqlQueries.CreateQualificationAcheivedForLrsMathsNAEnglishA(profileId);
        }
        public void CreateDbRegistationForNonLRS(string uln)
        {
            var profileId = SqlQueries.CreateRegistrationProfileForNonLRS(uln);
            var pathwayId = SqlQueries.CreateRegistrationPathwayForLrs(profileId);
            SqlQueries.CreateRegSpecialismForLrs(pathwayId);
        }
        public IndustryPlacementStatus GetIPStatus(string uln)
        {
            string profileIdQuery = "select  rep.Id from TqRegistrationProfile rp join TqRegistrationPathway rep on rp.Id = rep.TqRegistrationProfileId where rp.UniqueLearnerNumber = "+uln;
            var regPathwayId = SqlDatabaseConncetionHelper.ReadDataFromDataBase(profileIdQuery, ConnectionString);
            string IpQuery = "select status from IndustryPlacement where TqRegistrationPathwayId="+ Convert.ToInt32(regPathwayId[0][0]); ;
            var ipStatusId = SqlDatabaseConncetionHelper.ReadDataFromDataBase(IpQuery, ConnectionString);
            return (IndustryPlacementStatus)Convert.ToInt32(ipStatusId[0][0]);
        }
        public EnglishAndMathsStatus GetEMStatus(string uln)
        {
            string profileTableQuery = "select IsEnglishAndMathsAchieved from TqRegistrationProfile where UniqueLearnerNumber= " + uln;
            var englishMathsStatus = SqlDatabaseConncetionHelper.ReadDataFromDataBase(profileTableQuery, ConnectionString);
            return (EnglishAndMathsStatus)Convert.ToInt32(englishMathsStatus[0][0]);
        }
        public void CreateIndustryPlacementRecord(string uln)
        {
            var profileId = SqlQueries.ReturnRegistrationProfileForLrs(uln);
            var pathwayId = SqlQueries.ReturnRegistrationPathwayForLrs(profileId);
            SqlQueries.CreateIndustryPlacement(pathwayId, 1);
        }

        public void CreateDbRegistationForLrsWithEMOnly(string uln)
        {
            var profileId = SqlQueries.CreateRegistrationProfileForLrsWithEM(uln);
            var pathwayId = SqlQueries.CreateRegistrationPathwayForLrs(profileId);
            SqlQueries.CreateRegSpecialismForLrs(pathwayId);
            SqlQueries.CreateQualificationAcheivedForLrsSEND(profileId);
           
        }

        public void AddNonSendQualificationsToRegistration(string uln)
        {
            var profileId = SqlQueries.ReturnRegistrationProfileID(uln);
            SqlQueries.CreateQualificationAcheivedForLrs(profileId);
        }
        public void CreateRegistrationForBarnsley(string uln)
        {
            var profileId = SqlQueries.CreateRegistrationProfileForLrs(uln);
            var pathwayId = SqlQueries.CreateRegistrationPathwayForLrs(profileId);
            SqlQueries.CreateRegSpecialism(pathwayId);
        }
        public void CreateAndWithdrawRegBarnsley(string uln)
        {
            var profileId = SqlQueries.CreateRegistrationProfileForNonLRS(uln);
            var pathwayId = SqlQueries.CreateRegistrationPathwayForLrs(profileId);
            SqlQueries.CreateRegSpecialism(pathwayId);
            var pathwayAssessmentId = SqlQueries.CreatePathwayAssessment(pathwayId);
            SqlQueries.CreatePathwayResult(pathwayAssessmentId);
            SqlQueries.UpdateRegWithdrawn(uln);
        }

        public void CreateRegForBarnsleyNoCoreGrade_Withdrawn_IndPlacementNotComplete(string uln)
        {
            var profileId = SqlQueries.CreateRegistrationProfileForNonLrsWithEM(uln);
            var pathwayId = SqlQueries.CreateWithdrawnRegistrationPathwayRecord(profileId);
            SqlQueries.CreateRegSpecialism(pathwayId);
            SqlQueries.CreateIndustryPlacement(pathwayId, 3);
        }
    }
}
