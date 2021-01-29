Feature: 2139_Create 'Do you want to add a core assessment entry to the next available series' page (Summer 2021)
	As a Registrations Editor
	I need to understand that I can add the next available assessment entry for the core
	So that I can ensure I am adding the correct information

	
Background: 
Given I have logged in as a "RegistrationEditor" user
And I upload a single registration and navigate to the Search for a learner page

@RegressionTest @AssessmentEntries
Scenario: 2139_Validate the headings on the Do you want to add core assessment entry page and press the back link
Given I navigate to the Search for a learner page and enter the <ULN>
Then I am shown the Learner's Assessment Entries page with details for <ULN>
When I click the Add Entry link
Then I am shown the Do you want to add core assessment entry page
When I click the back link on the Do you want to add core assessment entry page
Then I am navigated back to the Learner's Assessment Entries page for <ULN>

Examples: 
| ULN         |
| 9900000001  |


@Ignore @RegressionTest @AssessmentEntries
Scenario: 2139_Press Submit button without selecting a radio button
Given I navigate to the Search for a learner page and enter the <ULN>
Then I am shown the Learner's Assessment Entries page with details for <ULN>
And the Core Assessment entry displays "not Specified"
When I click the Add Entry link
And I click Submit on Add Core Assessment page without selecting a radio button
Then I am shown an error message stating 'Select yes to add to Summer 2021'

Examples: 
| ULN         |
| 9900000001  |

@RegressionTest @AssessmentEntries
Scenario: 2139_Selecting No radio button will return user to the the Learner’s assessment entries page
Given I navigate to the Search for a learner page and enter the <ULN>
Then I am shown the Learner's Assessment Entries page with details for <ULN>
When I click the Add Entry link
And I select the No radio button and press Submit
Then I am shown the Learner's Assessment Entries page with details for <ULN>
And the Core Assessment entry displays "not Specified"
Examples: 
| ULN         |
| 9900000001  |

