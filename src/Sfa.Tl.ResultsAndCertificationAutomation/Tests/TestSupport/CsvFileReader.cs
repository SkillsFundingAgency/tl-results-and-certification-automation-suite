﻿using CSVReaderHelper;
using NUnit.Framework;
using Sfa.Tl.ResultsAndCertificationAutomation.Data;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;
using System;
using System.IO;
using System.Linq;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.TestSupport
{
    class CsvFileReader
    {
        private static string Folder => FileHelper.GetDownloadFolder();
        public static void CsvDataFileCompare(string file)
        {
            CSVHelper read = new CSVHelper();
            var actualErrors = read.Main(Folder, PageHelper.GetLatestFile(Folder, "*.csv"));
            string stage2Results = $"{AppDomain.CurrentDomain.BaseDirectory}{file}";
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
            var GetFile = $"{AppDomain.CurrentDomain.BaseDirectory}Data\\{fileName}";
            var AcademicYear = SqlQueries.GetAcademicYear();
            string text = File.ReadAllText(GetFile);
            text = text.Replace("{AcademicYear}", AcademicYear);
            File.WriteAllText(GetFile, text);
        }
        public static void CsvAssessmentSeriesUpdate(string fileName)
        {
            var GetFile = $"{AppDomain.CurrentDomain.BaseDirectory}Data\\{fileName}";
            var AssessmentSeries = SqlQueries.GetAssessmentSeries();
            string text = File.ReadAllText(GetFile);
            text = text.Replace("{AssessmentSeries}", AssessmentSeries);
            File.WriteAllText(GetFile, text);
        }
    }
}
