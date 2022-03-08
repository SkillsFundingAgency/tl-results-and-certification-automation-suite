using CsvHelper.Configuration.Attributes;

namespace CSVReaderHelper
{
    public class CsvCoreResultsData
    {
        [Name("ULN")]
        public string UlnNo { get; set; }
        [Name("Component code (core)")]
        public string ComponentCodeCore { get; set; }
        [Name("Assessment series (core)")]
        public string AssessmentSeriesCore { get; set; }
        [Name("Component grade (core)")]
        public string ComponenetGradeCore { get; set; }
    }
}
