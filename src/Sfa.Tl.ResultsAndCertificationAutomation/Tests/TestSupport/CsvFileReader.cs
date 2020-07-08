﻿using CSVReaderHelper;
using NUnit.Framework;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;
using System;
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
                Assert.AreEqual(actualError.LineNo, expectedError.LineNo);
                Assert.AreEqual(actualError.UlnNo, expectedError.UlnNo);
                Assert.AreEqual(actualError.ErrorMsg, expectedError.ErrorMsg);

                index++;
            }
        }
    }
}