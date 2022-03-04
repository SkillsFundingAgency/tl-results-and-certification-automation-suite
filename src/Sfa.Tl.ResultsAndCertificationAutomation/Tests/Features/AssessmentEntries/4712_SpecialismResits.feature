Feature: 4712_SpecialismResits

As an AO , I want to bulk upload assessment entry for a resit without affecting previous assessment result.

Background: 
Given I have logged in as a "CityAndGuildsAdmin" user

@RegressionTest @AssessmentEntries
Scenario: 4712 Add current specialism for a resit from bulkupload
And I have a registration with Specialism assessment series added for previous assessment year with grade
| Uln        |
| 9500000001 |
And I am on Assessment entries upload page
When I upload assessment "4712_AssessmentsValid.csv" file
Then assessment upload success message will be shown

@RegressionTest @AssessmentEntries
Scenario: 4712 Add current specialism for a resit manually
And I have a registration with Specialism assessment series added for previous assessment year with grades
And I am on Learner assessment entries page
When I add assessment for specialism couplets
Then success message is shown
