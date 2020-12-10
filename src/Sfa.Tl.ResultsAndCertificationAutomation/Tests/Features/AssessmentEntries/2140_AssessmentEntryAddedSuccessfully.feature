Feature: 2140_Create 'Assessment entry added successfully' page
	As a Registrations Editor
	I need to be able to able to see that I have added an assessment series
	So that I can ensure I have completed my action

	
Background: 
Given I have logged in as a "RegistrationEditor" user
And I upload a single registration and navigate to the Search for a learner page

@RegressionTest @AssessmentEntries
Scenario: 2140_Add an assessment entry for the learner and validate the success page
Given I navigate to the Search for a learner page and enter the <ULN>
Then I am shown the Learner's Assessment Entries page with details for <ULN>
And the Core Assessment entry displays "not Specified"
When I click the Add Entry link
Then I am shown the Do you want to add core assessment entry page
When I click the Yes radio button
Then I am shown the Assessment Entry Added Successfully page for <ULN>
When I click the Back to Learner's Assessment Entries button
Then I am shown the Learner's Assessment Entries page with details for <ULN>
And the Core Assessment entry 'Summer 2021' is displayed underneath
Examples: 
| ULN         |
| 9900000001  |