Feature: 1932_Update Registration Details Page
	As a Registrations Editor
	I need to be able to view and amend a learner's assessment entries
	So that I can ensure the entry data is up to date


Background: 
Given I have logged in as a "RegistrationEditor" user

@RegressionTest @AssessmentEntries
Scenario: 1932_The Withdrawn registration details page will not have a link to the assessment entries page
And I create a new registration which I subsequently withdraw
Then there will not be a View and amend this learner's assessment entries link on the Withdrawn registration deals page 


@RegressionTest @AssessmentEntries
Scenario: 1932_The Active registration details page will have a link to the assessment entries page
And I click on Add a new registration link
And I create a manual registration
And I search for my registration
Then I should see results in the page
And the ULN status will be Active
Given I click the View and amend this learner's assessment entries link
Then I am shown the Learner's Assessment Entries page with details for <ULN>
And I cleared the data in DB
Examples: 
| ULN         |
| 9900000001  |


