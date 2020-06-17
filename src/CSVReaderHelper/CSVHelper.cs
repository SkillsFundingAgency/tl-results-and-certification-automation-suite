using CsvHelper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

namespace CSVReaderHelper
{
    public class CSVHelper
    {
        public void Main(string location)
        {
            using (var reader = new StreamReader(location))
            using (var csv = new CsvReader(reader,CultureInfo.InvariantCulture))
            {
                var records = csv.GetRecords<CsvErrors>();
            }
        }
    }
}
