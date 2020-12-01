Feature: 1878_Create Search for a learner Page
	As a Registrations Editor
	I need to be able to search for a ULN
	So that I can update entry data

@RegressionTest @AssessmentEntries
Scenario: 1878_Verify search for a learner page headings, URL and page title
Given I have logged in as a "RegistrationEditor" user
And I navigate to the Search for a learner page
Then the heading, page title and URL will be as expected
And the expected page text will be displayed


@RegressionTest @AssessmentEntries
Scenario: 1878_search for an invalid ULN on the Search for a learner page
Given I have logged in as a "RegistrationEditor" user
And I navigate to the Search for a learner page
And I enter the following <ULN>
Then I am shown an error on the Assessment Entry Search for a learner page for invalid URL
Examples: 
| ULN        |
| 990000005  |
| 9900000ABC |


@RegressionTest @AssessmentEntries
Scenario: 1878_Press Submit without entering a ULN on the Search for a learner page
Given I have logged in as a "RegistrationEditor" user
And I navigate to the Search for a learner page
And I press Search without entering a ULN
Then I am shown an error on the Assessment Entry Search for a learner page for missing URL


@RegressionTest @AssessmentEntries
Scenario: 1878_Validate breadcrumb links on the Search for a learner page
Given I have logged in as a "RegistrationEditor" user
And I navigate to the Search for a learner page
And I press the Assessment Entries breadcrumb link
Then I am navigated to the Assessment Entries page
Given I navigate back to the Search for a learner page
And I press the Home breadcrumb link
Then I am taken to the home page