Feature: 4704 - BULK UPLOAD ASSESSMENT: Single occupational specialism and core stage 4 validations
		As users can now add specialisms to a series, we need to ensure all the validation rules are in place to ensure only the correct information is entered into the database
		This is applicable to resit.

		*Prevent adding single occupational specialism to next assessment series as previous entry has no result 
		*If a result associated to the assessment entry and user attempts to remove assessment entry - validation message 

Background: 
Given I have logged in as a "CityAndGuildsAdmin" user

@RegressionTest @AssessmentEntries
Scenario: 4704 Attempt to add a specialism assessment entry through bulk upload for current series when previous specialism assessment series does not have a result added
And I have a registration with Specialism assessment series added for previous assessment year with no grade with <ULN>
And I am on Assessment entries upload page
And I have a active Specialism Assessment Series in "4704AssessmentEntryData.csv"
When I upload "4704AssessmentEntryData.csv" file
And I click on "Upload" button
And I download the error file and verify
Then I should see all of the stage 4 validation errors related to Assessments in file "4704ExpectedErrorReport.csv"

Examples: 
| ULN         |
| 9900000005  |


@RegressionTest @AssessmentEntries
Scenario: 4704 Cannot remove previous specialism assessment entry which has a result using bulk assessment upload file
And I have a registration with Specialism assessment series added for previous assessment year with a grade with <ULN>
And I am on Assessment entries upload page
When I upload "4704AssessmentEntryDataRemoveAssessSeries.csv" file
And I click on "Upload" button
And I download the error file and verify
Then I should see all of the stage 4 validation errors related to Assessments in file "4704AssessmentEntryDataRemoveAssessSeriesErrReport.csv"

Examples: 
| ULN         |
| 9900000005  |

@RegressionTest @AssessmentEntries
Scenario: 4704 Attempt to remove current specialism assessment entry which has a result through bulk upload
And I have a registration with Specialism assessment series added for current assessment series with a grade with <ULN>
And I am on Assessment entries upload page
When I upload "4704AssessmentEntryDataRemoveAssessSeries.csv" file
And I click on "Upload" button
And I download the error file and verify
Then I should see all of the stage 4 validation errors related to Assessments in file "4704AssessmentEntryDataRemoveAssessSeriesErrReport.csv"

Examples: 
| ULN         |
| 9900000005  |

