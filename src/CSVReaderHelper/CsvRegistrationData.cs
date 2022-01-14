using CsvHelper.Configuration.Attributes;

namespace CSVReaderHelper
{
    public class CsvRegistrationData
    {
        [Name("ULN")]
        public string UlnNo { get; set; }
        [Name("First name")]
        public string FirstName { get; set; }
        [Name("Last name")]
        public string LastName { get; set; }
        [Name("Date of birth")]
        public string DateOfBirth { get; set; }
        [Name("UKPRN")]
        public string Ukprn { get; set; }
        [Name("Academic year")]
        public string AcademicYear { get; set; }
        [Name("Core code")]
        public string CoreCode { get; set; }
        [Name("Specialism code(s)")]
        public string SpecialismCode { get; set; }
        [Name("Status")]
        public string Status { get; set; }
    }
}
