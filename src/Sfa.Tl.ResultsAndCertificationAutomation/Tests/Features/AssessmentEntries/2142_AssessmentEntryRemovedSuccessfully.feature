Feature: 2142_Create 'Assessment entry removed successfully' page
	As a Registrations Editor
	I need to be able to see that I have removed an assessment entry
	So that I can see that I have completed my task

	
Background: 
Given I have logged in as a "RegistrationEditor" user
And I upload registrations and associated assessments

@RegressionTest @AssessmentEntries
Scenario: 2142_Remove an assessment entry for the learner and validate the success page
Given I navigate to the Search for a learner page and enter the <ULN>
Then I am shown the Learner's Assessment Entries page with details for <ULN>
And the Core Assessment entry is displayed underneath
When I click the Remove entry link
And I select the Yes radio button on the remove assessment entry page and press Submit
Then I am shown the Assessment Entry Removed Successfully pagefor <ULN>
When I click the Back to Learner's Assessment Entries button on the Assessment Entry Removed Successfully page
Then I am shown the Learner's Assessment Entries page with details for <ULN>
And the Core Assessment entry displays "not Specified"
And I cleared the data in DB
Examples: 
| ULN         |
| 9900000001  |