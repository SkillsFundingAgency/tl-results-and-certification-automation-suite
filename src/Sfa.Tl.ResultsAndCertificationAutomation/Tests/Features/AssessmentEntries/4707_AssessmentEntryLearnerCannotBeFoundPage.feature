﻿Feature: 4707_MANUAL JOURNEY: ASSESSMENT ENTRY CHANGES - learner not found
	As a Registrations Editor
    I need to be able to understand that I cannot search for a ULN which is registered with a different AO
	So that I can search for a different ULN


@RegressionTest @AssessmentEntries
Scenario: 4707_Verify ULN cannot be found page headings, URL, page title
Given I have logged in as a "RegistrationEditor" user
And I navigate to the Search for a learner page
And I enter the unregistered <ULN>
Then I am navigated to the ULN connot be found page which shows a header with the <ULN>
Examples: 
| ULN         |
| 9900000005  |


@RegressionTest @AssessmentEntries
Scenario: 4707_Verify searching for a ULN which is registered to another AO results in the ULN not found page being displayed
Given I have logged in as a "PearsonSiteAdmin" user
And I click on Add a new registration link
And I create a manual registration for Pearson
When I click on Sign Out link
Then I should be redirectted to Tlevel Start page
Given I have logged in as a "RegistrationEditor" user
And I navigate to the Search for a learner page
And I enter the following <ULN>
Then I am navigated to the ULN connot be found page which shows a header with the <ULN>
Examples: 
| ULN         |
| 9900000005  |


@RegressionTest @AssessmentEntries
Scenario: 4707_Verify button navigation on the Assessment ULN not found page
Given I have logged in as a "RegistrationEditor" user
And I navigate to the Search for a learner page
And I enter the following <ULN>
Then I am navigated to the ULN connot be found page which shows a header with the <ULN>
When I press the Back link on the Assessment ULN not found page
Then I am navigated back to the Search for a learner page 
And the search field on the ULN not found page still shows the <ULN> entered
When I enter the following <ULN>
And I press the Search again button on the ULN not found page
Then I am navigated back to the Search for a learner page 
And Search field on the ULN not found page is shown and the Search field is empty
When I enter the following <ULN>
And I press the Back to home button
Then I should be navigated back to home page

Examples: 
| ULN         |
| 9900000099  |



