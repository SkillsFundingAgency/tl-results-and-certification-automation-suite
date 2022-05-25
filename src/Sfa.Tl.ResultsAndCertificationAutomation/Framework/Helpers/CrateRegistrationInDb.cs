using Sfa.Tl.ResultsAndCertificationAutomation.Data;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Model;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.TestSupport;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers
{
    public class CrateRegistrationInDb : ElementHelper
    {
        //public string uln = UlnHelper.GenerateUln().ToString();
        private static readonly string ConnectionString = WebDriverFactory.Config["DBConnectionString"];

        protected static void CreateDbRegistation(string uln)
        {
            var profileId = SqlQueries.CreateRegistrationProfile(uln);
            var pathwayId = SqlQueries.CreateRegistrationPathway(profileId);
            SqlQueries.CreateRegSpecialism(pathwayId);
        }

        public static void RegistationWithoutEngMatIp(string uln, int year)
        {
            var profileId = SqlQueries.CreateRegProfile(uln);
            var pathwayId = SqlQueries.CreateRegPathway(profileId, year);
            SqlQueries.CreateRegSpecialism(pathwayId);
        }
        public void CreateDbRegistationForLrs(string uln)
        {
            var profileId = SqlQueries.CreateRegistrationProfileForLrs(uln);
            var pathwayId = SqlQueries.CreateRegistrationPathwayForLrs(profileId);
            SqlQueries.CreateRegSpecialismForLrs(pathwayId);
            SqlQueries.CreateQualificationAcheivedForLrs(profileId);
        }

        protected static void CreateDbRegistationForLrsWithEmAcheived(string uln)
        {
            var profileId = SqlQueries.CreateRegistrationProfileForLrsWithEM(uln);
            var pathwayId = SqlQueries.CreateRegistrationPathwayForLrs(profileId);
            SqlQueries.CreateRegSpecialismForLrs(pathwayId);
            SqlQueries.CreateQualificationAcheivedForLrs(profileId);
        }

        protected static void CreateDbRegistationForLrsWithEmAndIp(string uln)
        {
            var profileId = SqlQueries.CreateRegistrationProfileForLrsWithEM(uln);
            var pathwayId = SqlQueries.CreateRegistrationPathwayForLrs(profileId);
            SqlQueries.CreateRegSpecialismForLrs(pathwayId);
            SqlQueries.CreateQualificationAcheivedForLrs(profileId);
            SqlQueries.CreateIndustryPlacement(pathwayId, 1);
        }

        protected static void CreateLrsRegWithEmAndIpForDudley(string uln)
        {
            var profileId = SqlQueries.CreateRegistrationProfileForLrsWithEM(uln);
            var pathwayId = SqlQueries.CreateRegistrationPathwayForDudley(profileId);
            SqlQueries.CreateRegSpecialismForLrs(pathwayId);
            SqlQueries.CreateQualificationAcheivedForLrs(profileId);
            SqlQueries.CreateIndustryPlacement(pathwayId, 1);
        }

        protected static void CreateDbRegistationNonLrsWithEmAndIp(string uln)
        {
            var profileId = SqlQueries.CreateRegistrationProfileForNonLrsWithEM(uln);
            var pathwayId = SqlQueries.CreateRegistrationPathwayForLrs(profileId);
            SqlQueries.CreateRegSpecialismForLrs(pathwayId);
            SqlQueries.CreateIndustryPlacement(pathwayId, 1);
        }

        protected static void CreateDbRegWithAssessment(string uln)
        {
            var profileId = SqlQueries.CreateRegistrationProfile(uln);
            var pathwayId = SqlQueries.CreateRegistrationPathway(profileId);
            SqlQueries.CreateRegSpecialism(pathwayId);
            SqlQueries.CreatePathwayAssessment(pathwayId);
        }

        protected static void CreateDbRegWithSpecialismAssessment(string uln)
        {
            var profileId = SqlQueries.CreateRegistrationProfile(uln);
            var pathwayId = SqlQueries.CreateRegistrationPathway(profileId);
            var specialismId = SqlQueries.CreateRegSpecialism(pathwayId);
            SqlQueries.CreatePathwayAssessment(pathwayId);
            SqlQueries.CreateSpecialismAssessment(specialismId);
        }
        public void CreateDbRegWithAssessmentForLrs(string uln)
        {
            var profileId = SqlQueries.CreateRegistrationProfileForLrs(uln);
            var pathwayId = SqlQueries.CreateRegistrationPathwayForLrs(profileId);
            SqlQueries.CreateRegSpecialismForLrs(pathwayId);
            SqlQueries.CreatePathwayAssessment(pathwayId);
            SqlQueries.CreateQualificationAcheivedForLrs(profileId);
        }

        protected static void CreateDbRegWithResult(string uln)
        {
            var profileId = SqlQueries.CreateRegistrationProfile(uln);
            var pathwayId = SqlQueries.CreateRegistrationPathway(profileId);
            SqlQueries.CreateRegSpecialism(pathwayId);
            var pathwayAssessmentId = SqlQueries.CreatePathwayAssessment(pathwayId);
            SqlQueries.CreatePathwayResult(pathwayAssessmentId);
        }

        protected static void CreateDbRegWithResultAndTwoAssessmentEntries(string uln)
        {
            var profileId = SqlQueries.CreateRegistrationProfile(uln);
            var pathwayId = SqlQueries.CreateRegistrationPathway(profileId);
            SqlQueries.CreateRegSpecialism(pathwayId);
            var pathwayAssessmentId = SqlQueries.CreatePathwayAssessment(pathwayId);
            SqlQueries.CreatePathwayResult(pathwayAssessmentId);
            SqlQueries.CreateSecondPathwayAssessmentEntry(pathwayId);
            //SqlQueries.CreatePathwayResult(pathwayAssessmentId1);
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

        protected static void CreateDbRegWithIpForLrs(string uln,int status)
        {
            var profileId = SqlQueries.CreateRegistrationProfileForLrsWithEM(uln);
            var pathwayId = SqlQueries.CreateRegistrationPathwayForLrs(profileId);
            SqlQueries.CreateRegSpecialismForLrs(pathwayId);
            var pathwayAssessmentId = SqlQueries.CreatePathwayAssessment(pathwayId);
            SqlQueries.CreatePathwayResult(pathwayAssessmentId);
            SqlQueries.CreateQualificationAcheivedForLrs(profileId);
            SqlQueries.CreateIndustryPlacement(pathwayId, status);
        }

        public static void CreateDbRegInWithdrawn(string uln)
        {
            SqlQueries.UpdateRegWithdrawn(uln);
        }
        public static void DeleteRegistrationFromTables(string uln)
        {
            var deleteAssessmentResult = "Delete sr from TqSpecialismResult sr join TqSpecialismAssessment sa on sr.TqSpecialismAssessmentId = sa.Id join TqRegistrationSpecialism rs ON sa.TqRegistrationSpecialismId = rs.Id join TqRegistrationPathway rp on  rs.TqRegistrationPathwayId=rp.Id join TqRegistrationProfile tr on  rp.TqRegistrationProfileId =tr.Id where UniqueLearnerNumber = '" + uln + "'";
            var deletePathwayResults = "Delete pr from TqPathwayResult pr join TqPathwayAssessment pa on pr.TqPathwayAssessmentId = pa.Id join TqRegistrationPathway rw ON pa.TqRegistrationPathwayId = rw.Id join TqRegistrationProfile rp on rw.TqRegistrationProfileId = rp.Id where UniqueLearnerNumber = '" + uln + "'";
            var deleteRegSpecialism = "Delete rs from TqRegistrationSpecialism rs join TqRegistrationPathway rw ON rs.TqRegistrationPathwayId = rw.Id join TqRegistrationProfile rp on rw.TqRegistrationProfileId =rp.Id where UniqueLearnerNumber = '" + uln + "'";
            var deleteRegPathway = "Delete from TqRegistrationPathway where TqRegistrationProfileId In (select Id from TqRegistrationProfile where UniqueLearnerNumber= '" + uln + "')";
            var deleteRegProfile = "Delete from TqRegistrationProfile where UniqueLearnerNumber = '" + uln + "'";
            var deleteAssPathway = "Delete pa from TqPathwayAssessment pa join TqRegistrationPathway rw ON pa.TqRegistrationPathwayId = rw.Id join TqRegistrationProfile rp on rw.TqRegistrationProfileId =rp.Id where UniqueLearnerNumber= '" + uln + "'";
            var deleteAssSpecialism = "Delete sa from TqSpecialismAssessment sa join TqRegistrationSpecialism rs ON sa.TqRegistrationSpecialismId = rs.Id join TqRegistrationPathway rp on  rs.TqRegistrationPathwayId=rp.Id join TqRegistrationProfile tr on  rp.TqRegistrationProfileId =tr.Id where UniqueLearnerNumber= '" + uln + "'";
            SqlQueries.DeletePrintTableRecords(uln);
            SqlDatabaseConncetionHelper.ExecuteDeleteSqlCommand(deleteAssessmentResult, ConnectionString);
            SqlDatabaseConncetionHelper.ExecuteDeleteSqlCommand(deletePathwayResults, ConnectionString);
            SqlDatabaseConncetionHelper.ExecuteDeleteSqlCommand(deleteAssPathway, ConnectionString);
            SqlDatabaseConncetionHelper.ExecuteDeleteSqlCommand(deleteAssSpecialism, ConnectionString);
            SqlDatabaseConncetionHelper.ExecuteDeleteSqlCommand(deleteRegSpecialism, ConnectionString);
            SqlDatabaseConncetionHelper.ExecuteDeleteSqlCommand(deleteRegPathway, ConnectionString);
            SqlDatabaseConncetionHelper.ExecuteDeleteSqlCommand(deleteRegProfile, ConnectionString);
        }

        public static void DeleteLrsRecordsFromTables(string uln)
        {
            var pathwayId = GetPathwayId(uln);
            var deleteIpRecords = "Delete from IndustryPlacement where TqRegistrationPathwayId = '" + pathwayId + "'";
            SqlDatabaseConncetionHelper.ExecuteDeleteSqlCommand(deleteIpRecords, ConnectionString);
            var profileId = GetProfileId(uln);
            var deleteQualificationAcheived = "Delete from QualificationAchieved where TqRegistrationProfileId = '" + profileId + "'";
            SqlDatabaseConncetionHelper.ExecuteDeleteSqlCommand(deleteQualificationAcheived, ConnectionString);
            DeleteRegistrationFromTables(uln);
        }

        protected static void DeleteLrsDataFromTables(string uln)
        {
            var pathwayIds = GetPathwayIds(uln);
            var deleteIpRecords = "Delete from IndustryPlacement where TqRegistrationPathwayId in (" + string.Join(",", pathwayIds)+")";
            SqlDatabaseConncetionHelper.ExecuteDeleteSqlCommand(deleteIpRecords, ConnectionString);
            var profileId = GetProfileId(uln);
            var deleteQualificationAcheived = "Delete from QualificationAchieved where TqRegistrationProfileId = '" + profileId + "'";
            SqlDatabaseConncetionHelper.ExecuteDeleteSqlCommand(deleteQualificationAcheived, ConnectionString);
            DeleteRegistrationFromTables(uln);
        }

        private static int GetProfileId(string uln)
        {
            var getProfileId = "Select top 1 Id from TqRegistrationProfile where UniqueLearnerNumber = '" + uln + "'";
            var profileId = SqlDatabaseConncetionHelper.ReadDataFromDataBase(getProfileId, ConnectionString);
            var result = Convert.ToInt32(profileId[0][0]);
            return result;
        }

        private static int GetPathwayId(string uln)
        {
            var getPathwayId = "select rs.TqRegistrationPathwayId from TqRegistrationSpecialism rs join TqRegistrationPathway rp on rp.Id = rs.TqRegistrationPathwayId join TqRegistrationProfile pr on pr.Id = rp.TqRegistrationProfileId where pr.UniqueLearnerNumber = '" + uln + "'";
            var pathwayId = SqlDatabaseConncetionHelper.ReadDataFromDataBase(getPathwayId, ConnectionString);
            var result = Convert.ToInt32(pathwayId[0][0]);
            return result;
        }

        private static IEnumerable<int> GetPathwayIds(string uln)
        {
            var getPathwayId = "select rs.TqRegistrationPathwayId from TqRegistrationSpecialism rs join TqRegistrationPathway rp on rp.Id = rs.TqRegistrationPathwayId join TqRegistrationProfile pr on pr.Id = rp.TqRegistrationProfileId where pr.UniqueLearnerNumber = '" + uln + "'";
            var pathwayIds = SqlDatabaseConncetionHelper.ReadDataFromDataBase(getPathwayId, ConnectionString);
            return pathwayIds.Select(x => Convert.ToInt32(x[0])).ToList();
        }

        protected static void CreateDbRegistationForLrsMathsAEnglishNa(string uln)
        {
            var profileId = SqlQueries.CreateRegistrationProfileForLrsMathsAndEnglishNotAchieved(uln);
            var pathwayId = SqlQueries.CreateRegistrationPathwayForLrs(profileId);
            SqlQueries.CreateRegSpecialismForLrs(pathwayId);
            SqlQueries.CreateQualificationAcheivedForLrsMathsAEnglishNA(profileId);
        }

        protected static void CreateDbRegistationForLrsMathsNaEnglishA(string uln)
        {
            var profileId = SqlQueries.CreateRegistrationProfileForLrsMathsAndEnglishNotAchieved(uln);
            var pathwayId = SqlQueries.CreateRegistrationPathwayForLrs(profileId);
            SqlQueries.CreateRegSpecialismForLrs(pathwayId);
            SqlQueries.CreateQualificationAcheivedForLrsMathsNAEnglishA(profileId);
        }

        protected static void CreateDbRegistationForNonLrs(string uln)
        {
            var profileId = SqlQueries.CreateRegistrationProfileForNonLRS(uln);
            var pathwayId = SqlQueries.CreateRegistrationPathwayForLrs(profileId);
            SqlQueries.CreateRegSpecialismForLrs(pathwayId);
        }

        protected static IndustryPlacementStatus GetIpStatus(string uln)
        {
            var profileIdQuery = "select  rep.Id from TqRegistrationProfile rp join TqRegistrationPathway rep on rp.Id = rep.TqRegistrationProfileId where rp.UniqueLearnerNumber = "+uln;
            var regPathwayId = SqlDatabaseConncetionHelper.ReadDataFromDataBase(profileIdQuery, ConnectionString);
            var ipQuery = "select status from IndustryPlacement where TqRegistrationPathwayId="+ Convert.ToInt32(regPathwayId[0][0]);
            var ipStatusId = SqlDatabaseConncetionHelper.ReadDataFromDataBase(ipQuery, ConnectionString);
            return (IndustryPlacementStatus)Convert.ToInt32(ipStatusId[0][0]);
        }

        protected static EnglishAndMathsStatus GetEmStatus(string uln)
        {
            var profileTableQuery = "select IsEnglishAndMathsAchieved from TqRegistrationProfile where UniqueLearnerNumber= " + uln;
            var englishMathsStatus = SqlDatabaseConncetionHelper.ReadDataFromDataBase(profileTableQuery, ConnectionString);
            return (EnglishAndMathsStatus)Convert.ToInt32(englishMathsStatus[0][0]);
        }

        protected static void CreateIndustryPlacementRecord(string uln)
        {
            var profileId = SqlQueries.ReturnRegistrationProfileForLrs(uln);
            var pathwayId = SqlQueries.ReturnRegistrationPathwayForLrs(profileId);
            SqlQueries.CreateIndustryPlacement(pathwayId, 1);
        }

        protected static void CreateDbRegistationForLrsWithEMOnly(string uln)
        {
            var profileId = SqlQueries.CreateRegistrationProfileForLrsWithEM(uln);
            var pathwayId = SqlQueries.CreateRegistrationPathwayForLrs(profileId);
            SqlQueries.CreateRegSpecialismForLrs(pathwayId);
            SqlQueries.CreateQualificationAcheivedForLrsSEND(profileId);
           
        }

        protected static void AddNonSendQualificationsToRegistration(string uln)
        {
            var profileId = SqlQueries.ReturnRegistrationProfileID(uln);
            SqlQueries.CreateQualificationAcheivedForLrs(profileId);
        }

        protected static void CreateRegistrationForBarnsley(string uln)
        {
            var profileId = SqlQueries.CreateRegistrationProfileForLrs(uln);
            var pathwayId = SqlQueries.CreateRegistrationPathwayForLrs(profileId);
            SqlQueries.CreateRegSpecialism(pathwayId);
        }

        protected static void CreateAndWithdrawRegBarnsley(string uln)
        {
            var profileId = SqlQueries.CreateRegistrationProfileForNonLRS(uln);
            var pathwayId = SqlQueries.CreateRegistrationPathwayForLrs(profileId);
            SqlQueries.CreateRegSpecialism(pathwayId);
            var pathwayAssessmentId = SqlQueries.CreatePathwayAssessment(pathwayId);
            SqlQueries.CreatePathwayResult(pathwayAssessmentId);
            SqlQueries.UpdateRegWithdrawn(uln);
        }

        protected void CreateRegForBarnsleyNoCoreGrade_Withdrawn_IndPlacementNotComplete(string uln)
        {
            var profileId = SqlQueries.CreateRegistrationProfileForNonLrsWithEM(uln);
            var pathwayId = SqlQueries.CreateWithdrawnRegistrationPathwayRecord(profileId);
            SqlQueries.CreateRegSpecialism(pathwayId);
            SqlQueries.CreateIndustryPlacement(pathwayId, 3);
        }

        protected static void CreateDbRegistationForLrsCombination(string uln, string EmStatus, string IpStatus)
        {
            var ipStat = IpStatus switch
            {
                "IP completed" => 1,
                "IP completed with special consideration" => 2,
                _ => 3
            };

            switch (EmStatus)
            {
                case "MathEng not Achieved Min Standard Math-A Eng-NA":
                    var profileId = SqlQueries.CreateRegistrationProfileForLrsCombination(uln, "NULL", "0", "NULL", "0");
                    var pathwayId = SqlQueries.CreateRegistrationPathwayForLrsCombination(profileId);
                    SqlQueries.CreateRegSpecialismForLrs(pathwayId);
                    SqlQueries.CreateQualificationAcheivedForLrsMathsAEnglishNA(profileId);
                    SqlQueries.CreateIndustryPlacement(pathwayId, ipStat);
                    var pathwayAssessmentId = SqlQueries.CreatePathwayAssessment(pathwayId);
                    SqlQueries.CreatePathwayResult(pathwayAssessmentId);
                    break;

                case "MathEng not Achieved Min Standard Math-NA Eng-A":
                    var profileId1 = SqlQueries.CreateRegistrationProfileForLrsCombination(uln, "NULL", "0", "NULL", "0");
                    var pathwayId1 = SqlQueries.CreateRegistrationPathwayForLrsCombination(profileId1);
                    SqlQueries.CreateRegSpecialismForLrs(pathwayId1);
                    SqlQueries.CreateQualificationAcheivedForLrsMathsAEnglishNA(profileId1);
                    SqlQueries.CreateIndustryPlacement(pathwayId1, ipStat);
                    var pathwayAssessmentId1 = SqlQueries.CreatePathwayAssessment(pathwayId1);
                    SqlQueries.CreatePathwayResult(pathwayAssessmentId1);
                    break;

                case "MathEng not Achieved Min Standard Math-NA Eng-NA":
                    var profileId4 = SqlQueries.CreateRegistrationProfileForLrsCombination(uln, "NULL", "0", "NULL", "0");
                    var pathwayId4 = SqlQueries.CreateRegistrationPathwayForLrsCombination(profileId4);
                    SqlQueries.CreateRegSpecialismForLrs(pathwayId4);
                    SqlQueries.CreateQualificationAcheivedForLrsMathsNaEnglishNa(profileId4);
                    SqlQueries.CreateIndustryPlacement(pathwayId4, ipStat);
                    var pathwayAssessmentId4 = SqlQueries.CreatePathwayAssessment(pathwayId4);
                    SqlQueries.CreatePathwayResult(pathwayAssessmentId4);
                    break;

                case "MathEng Achieved with SEND":
                    var profileId2 = SqlQueries.CreateRegistrationProfileForLrsCombination(uln, "1", "1", "NULL", "0");
                    var pathwayId2 = SqlQueries.CreateRegistrationPathwayForLrsCombination(profileId2);
                    SqlQueries.CreateRegSpecialismForLrs(pathwayId2);
                    SqlQueries.CreateQualificationAcheivedForLrsSEND(profileId2);
                    SqlQueries.CreateIndustryPlacement(pathwayId2, ipStat);
                    var pathwayAssessmentId2 = SqlQueries.CreatePathwayAssessment(pathwayId2);
                    SqlQueries.CreatePathwayResult(pathwayAssessmentId2);
                    break;

                case "MathEng Achieved Min Standard":
                    var profileId3 = SqlQueries.CreateRegistrationProfileForLrsCombination(uln, "NULL", "1", "NULL", "0");
                    var pathwayId3 = SqlQueries.CreateRegistrationPathwayForLrsCombination(profileId3);
                    SqlQueries.CreateRegSpecialismForLrs(pathwayId3);
                    SqlQueries.CreateQualificationAcheivedForLrs(profileId3);
                    SqlQueries.CreateIndustryPlacement(pathwayId3, ipStat);
                    var pathwayAssessmentId3 = SqlQueries.CreatePathwayAssessment(pathwayId3);
                    SqlQueries.CreatePathwayResult(pathwayAssessmentId3);
                    break;
            }
        }

        protected static void CreateDbRegistationForNonLrsCombination(string uln, string EmStatus, string IpStatus)
        {
            var ipStat = IpStatus switch
            {
                "IP completed" => 1,
                "IP completed with special consideration" => 2,
                _ => 3
            };

            switch (EmStatus)
            {
                case "MathEng achieved the minimum standard":
                    var profileId = SqlQueries.CreateRegistrationProfileForLrsCombination(uln, "0", "1", "NULL", "1");
                    var pathwayId = SqlQueries.CreateRegistrationPathwayForLrsCombination(profileId);
                    SqlQueries.CreateRegSpecialismForLrs(pathwayId);
                    SqlQueries.CreateIndustryPlacement(pathwayId, ipStat);
                    var pathwayAssessmentId = SqlQueries.CreatePathwayAssessment(pathwayId);
                    SqlQueries.CreatePathwayResult(pathwayAssessmentId);
                    break;

                case "MathEng achieved the minimum standard for learners with SEND":
                    var profileId1 = SqlQueries.CreateRegistrationProfileForLrsCombination(uln, "0", "1", "1", "1");
                    var pathwayId1 = SqlQueries.CreateRegistrationPathwayForLrsCombination(profileId1);
                    SqlQueries.CreateRegSpecialismForLrs(pathwayId1);
                    SqlQueries.CreateIndustryPlacement(pathwayId1, ipStat);
                    var pathwayAssessmentId1 = SqlQueries.CreatePathwayAssessment(pathwayId1);
                    SqlQueries.CreatePathwayResult(pathwayAssessmentId1);
                    break;

                case "MathEng not achieved the minimum standard":
                    var profileId4 = SqlQueries.CreateRegistrationProfileForLrsCombination(uln, "0", "0", "NULL", "1");
                    var pathwayId4 = SqlQueries.CreateRegistrationPathwayForLrsCombination(profileId4);
                    SqlQueries.CreateRegSpecialismForLrs(pathwayId4);
                    SqlQueries.CreateIndustryPlacement(pathwayId4, ipStat);
                    var pathwayAssessmentId4 = SqlQueries.CreatePathwayAssessment(pathwayId4);
                    SqlQueries.CreatePathwayResult(pathwayAssessmentId4);
                    break;

            }
        }

        protected static void CreateRegWithAppealState(string uln)
        {
            var profileId = SqlQueries.CreateRegistrationProfile(uln);
            var pathwayId = SqlQueries.CreateRegistrationPathway(profileId);
            SqlQueries.CreateRegSpecialism(pathwayId);
            var pathwayAssessmentId = SqlQueries.CreatePathwayAssessment(pathwayId);
            SqlQueries.CreatePathwayResult(pathwayAssessmentId);
            var updateResult = "update TqPathwayResult set EndDate = GETDATE() where TqPathwayAssessmentId='" + pathwayAssessmentId + "'";
            SqlDatabaseConncetionHelper.UpdateSqlCommand(updateResult, ConnectionString);
            var insertAppealRow = "Insert into TqPathwayResult values('" + pathwayAssessmentId + "',2,GETDATE(),Null,3,1,0,GETDATE(),'System',GETDATE(),'System')";
            SqlDatabaseConncetionHelper.ExecuteSqlCommand(insertAppealRow, ConnectionString);
        }

        protected static void CreateRegWithFinalState(string uln)
        {
            var profileId = SqlQueries.CreateRegistrationProfile(uln);
            var pathwayId = SqlQueries.CreateRegistrationPathway(profileId);
            SqlQueries.CreateRegSpecialism(pathwayId);
            var pathwayAssessmentId = SqlQueries.CreatePathwayAssessment(pathwayId);
            SqlQueries.CreatePathwayResult(pathwayAssessmentId);
            var updateResult = "update TqPathwayResult set EndDate = GETDATE() where TqPathwayAssessmentId='" + pathwayAssessmentId + "'";
            SqlDatabaseConncetionHelper.UpdateSqlCommand(updateResult, ConnectionString);
            var insertAppealRow = "Insert into TqPathwayResult values('" + pathwayAssessmentId + "',2,GETDATE(),Null,3,1,0,GETDATE(),'System',GETDATE(),'System')";
            SqlDatabaseConncetionHelper.ExecuteSqlCommand(insertAppealRow, ConnectionString);
            var updateResult1 = "update TqPathwayResult set EndDate = GETDATE() where TqPathwayAssessmentId='" + pathwayAssessmentId + "' and PrsStatus=3";
            SqlDatabaseConncetionHelper.UpdateSqlCommand(updateResult1, ConnectionString);
            var insertFinalRow = "Insert into TqPathwayResult values('" + pathwayAssessmentId + "',2,GETDATE(),Null,4,1,0,GETDATE(),'System',GETDATE(),'System')";
            SqlDatabaseConncetionHelper.ExecuteSqlCommand(insertFinalRow, ConnectionString);
        }

        protected static void RegisterWithdrawnLearnerWithAnotherAo(string uln)
        {
            var profileId = SqlQueries.ReturnRegistrationProfileID(uln);

            //var createNewRegPathway = "Insert into TqRegistrationPathway values('" + profileId + "', '" + "16133" + "','2020', GETDATE(),NULL,1,1,GETDATE(),'System',NULL,NULL)";
            var createNewRegPathway = "Insert into TqRegistrationPathway values('" + profileId + "', '" + Constants.PearsonTqProviderId + "','2020', GETDATE(),NULL,1,1,GETDATE(),'System',NULL,NULL)";

            SqlDatabaseConncetionHelper.ExecuteSqlCommand(createNewRegPathway, ConnectionString);

        }
    }
}
