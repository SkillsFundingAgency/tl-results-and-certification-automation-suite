using CsvHelper.Configuration.Attributes;

namespace CSVReaderHelper
{
    public class CsvErrors
    {
        [Name("Line")]
        public int LineNo { get; set; }
        [Name("ULN")]
        public string UlnNo { get; set; }
        [Name("Error")]
        public string ErrorMsg { get; set; }
    }
}
