using CsvHelper.Configuration.Attributes;

namespace CSVReaderHelper
{
    public class CsvSpecialismAssessmentsData
    {
        [Name("ULN")]
        public string UlnNo { get; set; }
        [Name("Specialism code(s)")]
        public string SpecialismCodes { get; set; }
        [Name("Specialism assessment entry")]
        public string SpecialismAssessmentEntry { get; set; }
    }
}
