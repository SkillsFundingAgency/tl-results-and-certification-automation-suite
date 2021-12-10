Feature: TLRC_4765 MANUAL JOURNEY: ASSESSMENT ENTRY CHANGES - add multiple specialism  resits to open assessment entry (test only)
	BUSINESS NEED: NEW PAGE - journey and accessibility improvements to the page and to allow users to add to open assessment entries for Specialisms from Summer 2022 onwards
	SUMMARY/CONTEXT: provides more learner details, learner details structured with accessibility in mind, give clear information to user what they will be adding to.

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
Scenario: 4765_Verify the Add Specialism assessment entry page
When I enter the following <ULN>
Then I am navigated to the Assessment Details page for <ULN>
And the specialism section will state No assessment entries have yet been recorded for the current open assessment period 
And the specialism section Add/Remove link will state "Add an assessment entry for Heating Engineering (10202101) and Plumbing (10202102)"
And the Specialism code will display "Heating Engineering (10202101) and Plumbing (10202102)"
When I click the Add specialism assessment series link 
Then I am navigated to the Add specialism assessment entry page multiple specialisms for <ULN> in "Heating Engineering (10202101) and Plumbing (10202102)"
And I cleared the data in DB

Examples: 
| ULN         | 
| 9900000012  |

@RegressionTest @AssessmentEntriesUpload
Scenario: 4765_Press submit without selecting a radio button on the Add Specialism assessment entry page
When I enter the following <ULN>
Then I am navigated to the Assessment Details page for <ULN>
And the specialism section will state No assessment entries have yet been recorded for the current open assessment period 
And the specialism section Add/Remove link will state "Add an assessment entry for Heating Engineering (10202101) and Plumbing (10202102)"
And the Specialism code will display "Heating Engineering (10202101) and Plumbing (10202102)"
When I click the Add specialism assessment series link 
And I click Submit on the Add specialism assessment entry page without selecting a radio button
Then I am shown an error message on the Add specialism assessment entry page
And I cleared the data in DB

Examples: 
| ULN         |
| 9900000012  |

@RegressionTest @AssessmentEntriesUpload
Scenario: 4765_Click the back link on the Specialism assessment entry page
When I enter the following <ULN>
Then I am navigated to the Assessment Details page for <ULN>
And the specialism section will state No assessment entries have yet been recorded for the current open assessment period 
And the specialism section Add/Remove link will state "Add an assessment entry for Heating Engineering (10202101) and Plumbing (10202102)"
And the Specialism code will display "Heating Engineering (10202101) and Plumbing (10202102)"
When I click the Add specialism assessment series link 
And I click the Back link on the Add specialism assessment entry page without selecting a radio button
Then I am navigated to the Assessment Details page for <ULN>
And the specialism section will state No assessment entries have yet been recorded for the current open assessment period 
And the specialism section Add/Remove link will state "Add an assessment entry for Heating Engineering (10202101) and Plumbing (10202102)"
And the Specialism code will display "Heating Engineering (10202101) and Plumbing (10202102)"
And I cleared the data in DB

Examples: 
| ULN         |
| 9900000012  |

@RegressionTest @AssessmentEntriesUpload
Scenario: 4765_Verify navigation when selecting the No radio button and pressing Submit on the core assessment entry page
When I enter the following <ULN>
Then I am navigated to the Assessment Details page for <ULN>
And the specialism section will state No assessment entries have yet been recorded for the current open assessment period 
And the specialism section Add/Remove link will state "Add an assessment entry for Heating Engineering (10202101) and Plumbing (10202102)"
And the Specialism code will display "Heating Engineering (10202101) and Plumbing (10202102)"
When I click the Add specialism assessment series link 
And I select the No radio button and press Submit on the Add specialism assessment entry page
Then I am navigated to the Assessment Details page for <ULN>
And the specialism section will state No assessment entries have yet been recorded for the current open assessment period 
And the specialism section Add/Remove link will state "Add an assessment entry for Heating Engineering (10202101) and Plumbing (10202102)"
And the Specialism code will display "Heating Engineering (10202101) and Plumbing (10202102)"
And I cleared the data in DB

Examples: 
| ULN         |
| 9900000012  |




