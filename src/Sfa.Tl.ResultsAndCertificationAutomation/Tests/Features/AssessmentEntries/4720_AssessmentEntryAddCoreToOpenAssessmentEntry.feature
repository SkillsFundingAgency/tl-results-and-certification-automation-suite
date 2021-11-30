Feature: TLRC_4720 MANUAL JOURNEY: ASSESSMENT ENTRY CHANGES - add core to open assessment entry
	journey and accessibility improvements to the page and to allow users to add to open assessment entries for core post Autumn 2021
	provides more learner details, learner details structured with accessibility in mind, give clear information to user what they will be adding to.

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
Scenario: 4720_Verify the Add core assessment entry page
When I enter the following <ULN>
Then I am navigated to the Assessment Details page for <ULN>
And the Core section will state No assessment entries have yet been recorded for the current open assessment period 
And the Core section Add/Remove link will state "Add an assessment entry for Building Services Engineering (60369115)"  
When I click the Add assessment series link 
Then I am navigated to the Add core assessment entry page for <ULN>
And I cleared the data in DB

Examples: 
| ULN         |
| 9900000011  |

@RegressionTest @AssessmentEntriesUpload
Scenario: 4720_Press submit without selecting a radio button onthe add core assessment entry page
When I enter the following <ULN>
Then I am navigated to the Assessment Details page for <ULN>
And the Core section will state No assessment entries have yet been recorded for the current open assessment period 
And the Core section Add/Remove link will state "Add an assessment entry for Building Services Engineering (60369115)"  
When I click the Add assessment series link 
And I click Submit on the Add Core assessment entry page without selecting a radio button
Then I am shown an error message on the Add core assessment entry page
And I cleared the data in DB

Examples: 
| ULN         |
| 9900000011  |

@RegressionTest @AssessmentEntriesUpload
Scenario: 4720_Click the back link on the core assessment entry page
When I enter the following <ULN>
Then I am navigated to the Assessment Details page for <ULN>
And the Core section will state No assessment entries have yet been recorded for the current open assessment period 
And the Core section Add/Remove link will state "Add an assessment entry for Building Services Engineering (60369115)"  
When I click the Add assessment series link 
And I click the Back link on the Add Core assessment entry page without selecting a radio button
Then I am navigated to the Assessment Details page for <ULN>
And the Core section will state No assessment entries have yet been recorded for the current open assessment period 
And the Core section Add/Remove link will state "Add an assessment entry for Building Services Engineering (60369115)"  
And I cleared the data in DB

Examples: 
| ULN         |
| 9900000011  |

@RegressionTest @AssessmentEntriesUpload
Scenario: 4720_Verify navigation when selecting the No radio button and pressing Submit on the core assessment entry page
When I enter the following <ULN>
Then I am navigated to the Assessment Details page for <ULN>
And the Core section will state No assessment entries have yet been recorded for the current open assessment period 
And the Core section Add/Remove link will state "Add an assessment entry for Building Services Engineering (60369115)"  
When I click the Add assessment series link 
And I select the No radio button and press Submit on the Add Core assessment entry page
Then I am navigated to the Assessment Details page for <ULN>
And the Core section will state No assessment entries have yet been recorded for the current open assessment period 
And the Core section Add/Remove link will state "Add an assessment entry for Building Services Engineering (60369115)"  
And I cleared the data in DB

Examples: 
| ULN         |
| 9900000011  |




