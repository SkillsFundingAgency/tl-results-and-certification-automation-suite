Feature: TLRC_4724 MANUAL JOURNEY: ASSESSMENT ENTRY CHANGES - success banner after removing core assessment entry
	Journey and accessibility improvements to the page and from Summer 2022 onwards - to show users that they have successfully removed core assessment entry.
	Provides more learner details, learner details structured with accessibility in mind, give clear information to user that they have successfully removed core assessment entry.

Background:
Given I have logged in as a "CityAndGuildsAdmin" user
And I am on Registrations upload page
And I am on upload registration page
And I have a Academic Year in "4714RegistrationsData.csv"
When I upload "4714RegistrationsData.csv" file	
And I click on "Upload" button
And I update the registrations to the previous year
And I navigated Home page
And I navigate to the Search for a learner page

@RegressionTest @AssessmentEntriesUpload
Scenario: 4724_Verify success banner is displayed when removing a core assessment entry for a registration with one specialism
Given I enter the following <ULN>
And I add an assessment entry for core
And I click the remove link on the Assessment Details page
And I click the Yes, remove the entry radio button and press Submit
Then I am navigated to the Assessment Details page for <ULN>
And the success banner is removed for the core assessment series added for "Building Services Engineering (60369115)"
And the specialism section will state No assessment entries have yet been recorded for the current open assessment period 
And the specialism section Add/Remove link will state "Add an assessment entry for Gas Engineering (ZTLOS029)"
And the Specialism code will display "Gas Engineering (ZTLOS029)"
And I cleared the data in DB

Examples: 
| ULN         |
| 9900000011  |

@RegressionTest @AssessmentEntriesUpload
Scenario: 4724_Verify success banner is displayed when removing a core assessment entry for a registration with multiple specialism codes
Given I enter the following <ULN>
And I add an assessment entry for core
And I click the remove link on the Assessment Details page
And I click the Yes, remove the entry radio button and press Submit
Then I am navigated to the Assessment Details page for <ULN>
And the success banner is removed for the core assessment series added for "Building Services Engineering (60369115)"
And the specialism section will state No assessment entries have yet been recorded for the current open assessment period 
And the specialism section Add/Remove link will state "Add an assessment entry for Heating Engineering (10202101) and Plumbing (10202102)"
And the Specialism code will display "Heating Engineering (10202101) and Plumbing (10202102)"
And I cleared the data in DB

Examples: 
| ULN         |
| 9900000012  |


