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
        private static string DownloadFolder = Config["DownloadFolder"];
        public IEnumerable<CsvErrors> Main(string filename)
        {
            using (var reader = new StreamReader(DownloadFolder + filename))
            using (var csv = new CsvReader(reader,CultureInfo.InvariantCulture))
            {
                csv.Configuration.HasHeaderRecord = true;
                var records = csv.GetRecords<CsvErrors>();
                return records.ToList();
            }
        }

        public IEnumerable<CsvErrors> ExpectedData(string file)
        {
            using (var reader1 = new StreamReader(file))
            using (var csv1 = new CsvReader(reader1, CultureInfo.InvariantCulture))
            {
                csv1.Configuration.HasHeaderRecord = true;
                var records = csv1.GetRecords<CsvErrors>();
                return records.ToList();
            }
        }

        private static IConfigurationRoot _config;
        private static IConfigurationRoot Config
        {
            get
            {
                if (_config == null)
                {

                    var builder = new ConfigurationBuilder()
                        .SetBasePath(Directory.GetCurrentDirectory())
                        .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
                    _config = builder.Build();
                }
                return _config;
            }
        }
    }
}
