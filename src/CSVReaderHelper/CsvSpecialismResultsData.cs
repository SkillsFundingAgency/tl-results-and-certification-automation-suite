using CsvHelper.Configuration.Attributes;

namespace CSVReaderHelper
{
    public class CsvSpecialismResultsData
    {
        [Name("ULN")]
        public string UlnNo { get; set; }
        [Name("Component code (specialism)")]
        public string ComponentCodeSpecialism { get; set; }
        [Name("Assessment series (specialism)")]
        public string AssessmentSeriesSpecialism { get; set; }
        [Name("Component grade (specialism)")]
        public string ComponenetGradeSpecialism { get; set; }
    }
}
