Feature: 2141_Create 'Are you sure you want to remove this core assessment entry from Summer 2021? page
	As a Registrations Editor
	I need to be able to remove an assessment entry
	So that assessment entry data can be kept up to date

	
Background: 
Given I have logged in as a "RegistrationEditor" user
And I upload registrations and associated assessments


@RegressionTest @AssessmentEntries
Scenario: 2141_Validate the headings on the Do you want to add core assessment entry page and press the back link
Given I navigate to the Search for a learner page and enter the <ULN>
Then I am shown the Learner's Assessment Entries page with details for <ULN>
And the Core Assessment entry is displayed underneath
When I click the Remove entry link
Then I am shown the Are you sure you want to remove the Core Assessment entry page
When I click the back link on the Are you sure you want to Core Assessment entry page
Then I am shown the Learner's Assessment Entries page with details for <ULN>
And the Core Assessment entry is displayed underneath

Examples: 
| ULN         |
| 9900000001  |


@RegressionTest @AssessmentEntries
Scenario: 2141_Press Submit button without selecting a radio button
Given I navigate to the Search for a learner page and enter the <ULN>
Then I am shown the Learner's Assessment Entries page with details for <ULN>
And the Core Assessment entry is displayed underneath
When I click the Remove entry link
Then I am shown the Are you sure you want to remove the Core Assessment entry page
When I click Submit on the Remove Core Assessment page without selecting a radio button
Then I am shown an error message for no radio button selected stating 'Select yes to remove the core entry'

Examples: 
| ULN         |
| 9900000001  |

@RegressionTest @AssessmentEntries
Scenario: 2141_Selecting No radio button will return user to the the Learner’s assessment entries page
Given I navigate to the Search for a learner page and enter the <ULN>
Then I am shown the Learner's Assessment Entries page with details for <ULN>
And the Core Assessment entry is displayed underneath
When I click the Remove entry link
Then I am shown the Are you sure you want to remove the Core Assessment entry page
When I select the No radio button on the remove assessment entry page and press Submit
Then I am shown the Learner's Assessment Entries page with details for <ULN>
And the Core Assessment entry is displayed underneath
Examples: 
| ULN         |
| 9900000001  |

