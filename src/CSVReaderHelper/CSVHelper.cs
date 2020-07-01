using CsvHelper;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;

namespace CSVReaderHelper
{
    public class CSVHelper
    {
        public IEnumerable<CsvErrors> Main(string folder, string filename)
        {
<<<<<<< HEAD
            using var reader = new StreamReader(folder + filename);
            using CsvReader csv = new CsvReader(reader, CultureInfo.InvariantCulture);
            csv.Configuration.HasHeaderRecord = true;
            IEnumerable<CsvErrors> records = csv.GetRecords<CsvErrors>();
=======
            using var reader = new StreamReader($"{folder}{filename}");
            using var csv = new CsvReader(reader,CultureInfo.InvariantCulture);
            csv.Configuration.HasHeaderRecord = true;
            var records = csv.GetRecords<CsvErrors>();
>>>>>>> a8392d3e210308f1e44bda8e04e0cdb02618617c
            return records.ToList();
        }

        public IEnumerable<CsvErrors> ExpectedData(string file)
        {
            using var reader1 = new StreamReader(file);
<<<<<<< HEAD
            using CsvReader csv1 = new CsvReader(reader1, CultureInfo.InvariantCulture);
            csv1.Configuration.HasHeaderRecord = true;
            IEnumerable<CsvErrors> records = csv1.GetRecords<CsvErrors>();
=======
            using var csv1 = new CsvReader(reader1, CultureInfo.InvariantCulture);
            csv1.Configuration.HasHeaderRecord = true;
            var records = csv1.GetRecords<CsvErrors>();
>>>>>>> a8392d3e210308f1e44bda8e04e0cdb02618617c
            return records.ToList();
        }
    }
}
