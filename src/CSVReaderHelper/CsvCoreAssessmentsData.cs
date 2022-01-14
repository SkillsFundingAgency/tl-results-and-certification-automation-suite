using CsvHelper.Configuration.Attributes;

namespace CSVReaderHelper
{
    public class CsvCoreAssessmentsData
    {
        [Name("ULN")]
        public string UlnNo { get; set; }
        [Name("Core code")]
        public string CoreCode { get; set; }
        [Name("Core assessment entry")]
        public string CoreAssessmentEntry { get; set; }
    }
}
