Feature: 2001_Create Learner's assessment entries (withdrawn record)
	As a Registrations Editor
	I need to be able to understand that I cannot search for a ULN which has been withdrawn
	So that I can search for a different ULN


Background: 
Given I have logged in as a "RegistrationEditor" user
And I create a new registration which I subsequently withdraw
And I press the Home breadcrumb on the registration details page
And I navigate to the Search for a learner page


@RegressionTest @AssessmentEntries
Scenario: 2001_Search for a withdrawn learner and validate the title, URL and page headings
And I enter the following <ULN>
Then I am shown the Assessment Entries Withdrawn Learner page
Examples: 
| ULN         |
| 9900000001  |


@RegressionTest @AssessmentEntries
Scenario: 2001_Click the View this learner’s registration details’ link
And I enter the following <ULN>
Then I am shown the Assessment Entries Withdrawn Learner page
When I click the View this learner’s registration details’ link
Then I am taken to the Registrations Details page of the given withdrawn learner
Examples: 
| ULN         |
| 9900000001  |


@RegressionTest @AssessmentEntries
Scenario: 2001_Click the Search again link 
And I enter the following <ULN>
Then I am shown the Assessment Entries Withdrawn Learner page
When I click the Search again link
Then I am navigated back to the Search for a learner page
And the Search for a learner page search entry will not be retained
Examples: 
| ULN         |
| 9900000001  |


@RegressionTest @AssessmentEntries
Scenario: 2001_Validate breadcrumb links on the Search for a learner page
And I enter the following <ULN>
Then I am shown the Assessment Entries Withdrawn Learner page
And I press the Assessment Entries breadcrumb link on the Assessment Entries Withdrawn Learner page
Then I am navigated to the Assessment Entries page
Given I navigate back to the Search for a learner page
And I enter the following <ULN>
And I press the Home breadcrumb link on the Assessment Entries Withdrawn Learner page
Then I am taken to the home page
Given I navigate to the Search for a learner page
And I enter the following <ULN>
And I press the Search for a learner breadcrumb link on the Assessment Entries Withdrawn Learner page
Then I am navigated back to the Search for a learner page
Examples: 
| ULN         |
| 9900000001  |