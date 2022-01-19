﻿using CsvHelper.Configuration;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using CsvHelper;

namespace CSVReaderHelper
{
    public class CSVHelperCoreResultsData
    {
        public IEnumerable<CsvCoreResultsData> Main(string folder, string filename)
        {
            using var reader = new StreamReader($"{folder}{filename}");
            using var csv = new CsvReader(reader, BuildCsvConfiguration());
            var records = csv.GetRecords<CsvCoreResultsData>();
            return records.ToList();
        }

        public IEnumerable<CsvCoreResultsData> ExpectedData(string file)
        {
            using var reader1 = new StreamReader(file);
            using var csv1 = new CsvReader(reader1, BuildCsvConfiguration());
            var records = csv1.GetRecords<CsvCoreResultsData>();
            return records.ToList();
        }
        private static CsvConfiguration BuildCsvConfiguration()
        {
            return new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                HasHeaderRecord = true,
            };
        }
    }
}
