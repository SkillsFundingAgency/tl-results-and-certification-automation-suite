Feature: TLRC_4727 MANUAL JOURNEY: ASSESSMENT ENTRY CHANGES - success banner after adding core assessment entry
	journey and accessibility improvements to the page and from Summer 2022 onwards - to show users that they have successfully added a core assessment entry.
	provides more learner details, learner details structured with accessibility in mind, give clear information to user that they have successfully added a core assessment entry.

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
Scenario: 4727_Verify success banner is displayed when adding a core assessment entry to a registration with one specialism
When I enter the following <ULN>
Then I am navigated to the Assessment Details page for <ULN>
And the Core section will state No assessment entries have yet been recorded for the current open assessment period 
And the Core section Add/Remove link will state "Add an assessment entry for Building Services Engineering (60369115)"  
When I click the Add assessment series link 
And I select the Yes radio button and press Submit on the Add Core assessment entry page
Then I am navigated to the Assessment Details page for <ULN>
And the success banner is displayed for the core assessment series added for "Building Services Engineering (60369115)"
And the new assessment entry which has been added is displayed in the Core(code) section
And the specialism section will state No assessment entries have yet been recorded for the current open assessment period 
And the specialism section Add/Remove link will state "Add an assessment entry for Gas Engineering (ZTLOS029)"
And the Specialism code will display "Gas Engineering (ZTLOS029)"
And the remove link will be displayed next to the Core Assessment series details
And I cleared the data in DB

Examples: 
| ULN         |
| 9900000011  |

@RegressionTest @AssessmentEntriesUpload
Scenario: 4727_Verify success banner is displayed when adding a core assessment entry to a registration with multiple specialism codes
When I enter the following <ULN>
Then I am navigated to the Assessment Details page for <ULN>
And the Core section will state No assessment entries have yet been recorded for the current open assessment period 
And the Core section Add/Remove link will state "Add an assessment entry for Building Services Engineering (60369115)" 
When I click the Add assessment series link 
And I select the Yes radio button and press Submit on the Add Core assessment entry page
Then I am navigated to the Assessment Details page for <ULN>
And the success banner is displayed for the core assessment series added for "Building Services Engineering (60369115)"
And the new assessment entry which has been added is displayed in the Core(code) section
And the specialism section will state No assessment entries have yet been recorded for the current open assessment period 
And the specialism section Add/Remove link will state "Add an assessment entry for Heating Engineering (10202101) and Plumbing (10202102)"
And the Specialism code will display "Heating Engineering (10202101) and Plumbing (10202102)"
And the remove link will be displayed next to the Core Assessment series details
And I cleared the data in DB

Examples: 
| ULN         |
| 9900000012  |


