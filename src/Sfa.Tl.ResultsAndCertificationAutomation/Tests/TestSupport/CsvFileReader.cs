using CSVReaderHelper;
using NUnit.Framework;
using Sfa.Tl.ResultsAndCertificationAutomation.Data;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;
using System;
using System.IO;
using System.Linq;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.TestSupport
{
    internal static class CsvFileReader
    {
        private static string Folder => FileHelper.GetDownloadFolder();
        public static void CsvDataFileCompare(string file)
        {
            CSVHelper read = new CSVHelper();
            var actualErrors = read.Main(Folder, PageHelper.GetLatestFile(Folder, "*.csv"));
            var stage2Results = $"{AppDomain.CurrentDomain.BaseDirectory}{file}";
            var expectedErrors = read.ExpectedData(stage2Results);

            var index = 0;
            foreach (var expectedError in expectedErrors)
            {
                var actualError = actualErrors.Skip(index).First();
                Assert.AreEqual(expectedError.LineNo, actualError.LineNo);
                Assert.AreEqual(expectedError.UlnNo, actualError.UlnNo);
                Assert.AreEqual(expectedError.ErrorMsg, actualError.ErrorMsg);

                index++;
            }
        }
        public static void CsvAcademicYearUpdate(string fileName)
        {
            var getFile = $"{AppDomain.CurrentDomain.BaseDirectory}Data\\{fileName}";
            var academicYear = SqlQueries.GetAcademicYear();
            var text = File.ReadAllText(getFile);
            text = text.Replace("{AcademicYear}", academicYear);
            File.WriteAllText(getFile, text);
        }
        public static void CsvAssessmentSeriesUpdate(string fileName)
        {
            var getFile = $"{AppDomain.CurrentDomain.BaseDirectory}Data\\{fileName}";
            var AssessmentSeries = SqlQueries.GetAssessmentSeries();
            var text = File.ReadAllText(getFile);
            text = text.Replace("{AssessmentSeries}", AssessmentSeries);
            File.WriteAllText(getFile, text);
        }
        public static void CsvRegistrationDataFileCompare(string file)
        {
            CSVHelperRegistrationData read = new CSVHelperRegistrationData();
            var actualErrors = read.Main(Folder, PageHelper.GetLatestFile(Folder, "*.csv"));
            var registrationDataFile = $"{AppDomain.CurrentDomain.BaseDirectory}{file}";
            var expectedErrors = read.ExpectedData(registrationDataFile);

            var index = 0;
            foreach (var expectedError in expectedErrors)
            {
                var actualError = actualErrors.Skip(index).First();
                Assert.AreEqual(expectedError.UlnNo, actualError.UlnNo);
                Assert.AreEqual(expectedError.FirstName, actualError.FirstName);
                Assert.AreEqual(expectedError.LastName, actualError.LastName);
                Assert.AreEqual(expectedError.DateOfBirth, actualError.DateOfBirth);
                Assert.AreEqual(expectedError.Ukprn, actualError.Ukprn);
                Assert.AreEqual(expectedError.AcademicYear, actualError.AcademicYear);
                Assert.AreEqual(expectedError.CoreCode, actualError.CoreCode);
                Assert.AreEqual(expectedError.SpecialismCode, actualError.SpecialismCode);
                Assert.AreEqual(expectedError.Status, actualError.Status);

                index++;
            }
        }
        public static void CsvCoreAssessmentDataFileCompare(string file)
        {
            CSVHelperCoreAssessmentData read = new CSVHelperCoreAssessmentData();
            var actualErrors = read.Main(Folder, PageHelper.GetLatestFile(Folder, "*.csv"));
            var coreAssessmentDataFile = $"{AppDomain.CurrentDomain.BaseDirectory}{file}";
            var expectedErrors = read.ExpectedData(coreAssessmentDataFile);

            var index = 0;
            foreach (var expectedError in expectedErrors)
            {
                var actualError = actualErrors.Skip(index).First();
                Assert.AreEqual(expectedError.UlnNo, actualError.UlnNo);
                Assert.AreEqual(expectedError.CoreCode, actualError.CoreCode);
                Assert.AreEqual(expectedError.CoreAssessmentEntry, actualError.CoreAssessmentEntry);

                index++;
            }
        }
        public static void CsvSpecialismAssessmentDataFileCompare(string file)
        {
            CSVHelperSpecialismAssessmentData read = new CSVHelperSpecialismAssessmentData();
            var actualErrors = read.Main(Folder, PageHelper.GetLatestFile(Folder, "*.csv"));
            var specialismAssessmentDataFile = $"{AppDomain.CurrentDomain.BaseDirectory}{file}";
            var expectedErrors = read.ExpectedData(specialismAssessmentDataFile);

            var index = 0;
            foreach (var expectedError in expectedErrors)
            {
                var actualError = actualErrors.Skip(index).First();
                Assert.AreEqual(expectedError.UlnNo, actualError.UlnNo);
                Assert.AreEqual(expectedError.SpecialismCodes, actualError.SpecialismCodes);
                Assert.AreEqual(expectedError.SpecialismAssessmentEntry, actualError.SpecialismAssessmentEntry);

                index++;
            }
        }
        public static void CsvCoreResultsDataFileCompare(string file)
        {
            CSVHelperCoreResultsData read = new CSVHelperCoreResultsData();
            var actualErrors = read.Main(Folder, PageHelper.GetLatestFile(Folder, "*.csv"));
            var coreResultsDataFile = $"{AppDomain.CurrentDomain.BaseDirectory}{file}";
            var expectedErrors = read.ExpectedData(coreResultsDataFile);

            var index = 0;
            foreach (var expectedError in expectedErrors)
            {
                var actualError = actualErrors.Skip(index).First();
                Assert.AreEqual(expectedError.UlnNo, actualError.UlnNo);
                Assert.AreEqual(expectedError.ComponentCodeCore, actualError.ComponentCodeCore);
                Assert.AreEqual(expectedError.AssessmentSeriesCore, actualError.AssessmentSeriesCore);
                Assert.AreEqual(expectedError.ComponenetGradeCore, actualError.ComponenetGradeCore);

                index++;
            }
        }

        public static void CsvSpecialismResultsDataFileCompare(string file)
        {
            CSVHelperSpecialismResultsData read = new CSVHelperSpecialismResultsData();
            var actualErrors = read.Main(Folder, PageHelper.GetLatestFile(Folder, "*.csv"));
            var SpecialismResultsDataFile = $"{AppDomain.CurrentDomain.BaseDirectory}{file}";
            var expectedErrors = read.ExpectedData(SpecialismResultsDataFile);

            var index = 0;
            foreach (var expectedError in expectedErrors)
            {
                var actualError = actualErrors.Skip(index).First();
                Assert.AreEqual(expectedError.UlnNo, actualError.UlnNo);
                Assert.AreEqual(expectedError.ComponentCodeSpecialism, actualError.ComponentCodeSpecialism);
                Assert.AreEqual(expectedError.AssessmentSeriesSpecialism, actualError.AssessmentSeriesSpecialism);
                Assert.AreEqual(expectedError.ComponenetGradeSpecialism, actualError.ComponenetGradeSpecialism);

                index++;
            }
        }



    }
}
