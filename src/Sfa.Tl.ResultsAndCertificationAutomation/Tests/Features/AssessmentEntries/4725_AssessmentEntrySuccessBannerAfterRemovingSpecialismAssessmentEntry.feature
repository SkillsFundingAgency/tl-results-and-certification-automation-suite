Feature: TLRC_4725 MANUAL JOURNEY: ASSESSMENT ENTRY CHANGES - success banner after removing specialism assessment entry
	BUSINESS NEED:  journey and accessibility improvements to the page and from Summer 2022 onwards - to show users that they have successfully removed specialism assessment entry
	SUMMARY/CONTEXT: provides more learner details, learner details structured with accessibility in mind, give clear information to user that they have successfully removed specialism assessment entry.

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

@RegressionTest @AssessmentEntries
Scenario: 4725_Verify the success banner when removing Assessment Series for multiple specialisms
When I enter the following <ULN>
And I add a specialism entry 
And I click the remove link on the Assessment Details page for the specialism/s
And I click the Yes, remove the entry radio button and press Submit
Then I am navigated to the Assessment Details page for <ULN>
And the specialism section will state No assessment entries have yet been recorded for the current open assessment period 
And the specialism section Add/Remove link will state "Add an assessment entry for Heating Engineering (10202101) and Plumbing (10202102)"
And the Specialism code will display "Heating Engineering (10202101) and Plumbing (10202102)"
And the success banner is shown for the specialism assessment series removed for "Heating Engineering (10202101) and Plumbing (10202102)"
And I cleared the data in DB

Examples: 
| ULN         | 
| 9900000012  |

@RegressionTest @AssessmentEntries
Scenario: 4725_Verify the success banner when removing Assessment Series for single specialism
When I enter the following <ULN>
And I add a specialism assessment entry for a single specialism
And I click the remove link on the Assessment Details page for the specialism/s
And I click the Yes, remove the entry radio button and press Submit
Then I am navigated to the Assessment Details page for <ULN>
And the specialism section will state No assessment entries have yet been recorded for the current open assessment period 
And the specialism section Add/Remove link will state "Add an assessment entry for Gas Engineering (ZTLOS029)"
And the Specialism code will display "Gas Engineering (ZTLOS029)"
And the success banner is shown for the specialism assessment series removed for "Gas Engineering (ZTLOS029)"
And I cleared the data in DB

Examples: 
| ULN         | 
| 9900000011  |






