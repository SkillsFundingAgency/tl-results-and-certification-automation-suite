Feature: TLRC_4714 MANUAL JOURNEY: ASSESSMENT ENTRY CHANGES - Details page - 2nd year learners and those going into 3rd-4th years
	Journey and accessibility improvements to the page and to allow users to add assessment entries for core post Autumn 2021 
	and specialisms from Summer 2022.
	Give users clear understanding of the learner’s assessment entries status, provides more learner details, 
	learner details structured with accessibility in mind, 
	give clear information of what learner can add and not add and when.

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
Scenario: 4714_Navigate to Assessment Details page for a learner in 2nd year with a single specialism code and Press Search again
When I enter the following <ULN>
Then I am navigated to the Assessment Details page for <ULN>
And the Core section will state No assessment entries have yet been recorded for the current open assessment period 
And the Core section Add/Remove link will state "Add an assessment entry for Building Services Engineering (60369115)" 
And the core code will display "Building Services Engineering (60369115)"
And the specialism section will state No assessment entries have yet been recorded for the current open assessment period 
And the specialism section Add/Remove link will state "Add an assessment entry for Gas Engineering (ZTLOS029)"
And the Specialism code will display "Gas Engineering (ZTLOS029)"
When I press the Search again button on the Assessment Details page
Then I am navigated to the Assessment Search for a learner page
And I cleared the data in DB

Examples: 
| ULN         |
| 9900000011  |


@RegressionTest @AssessmentEntriesUpload
Scenario: 4714_Navigate to Assessment Details page for a learner in 2nd year with no specialism codes recorded
When I enter the following <ULN>
Then I am navigated to the Assessment Details page for <ULN>
And the Core section will state No assessment entries have yet been recorded for the current open assessment period 
And the Core section Add/Remove link will state "Add an assessment entry for Building Services Engineering (60369115)" 
And the core code will display "Building Services Engineering (60369115)"
And the specialism section will state "This learner does not have an occupational specialism recorded on this service"
And when I click on the Add an occupational specialism recorded on this service link
Then I am navigated to the Registration Details page for the learner's <ULN>
And I cleared the data in DB

Examples: 
| ULN         |
| 9900000013  |


@RegressionTest @AssessmentEntriesUpload
Scenario: 4714_Navigate to Assessment Details page for a learner in 2nd year with multiple specialism codes
When I enter the following <ULN>
Then I am navigated to the Assessment Details page for <ULN>
And the Core section will state No assessment entries have yet been recorded for the current open assessment period 
And the Core section Add/Remove link will state "Add an assessment entry for Building Services Engineering (60369115)"  
And the core code will display "Building Services Engineering (60369115)"
And the specialism section will state No assessment entries have yet been recorded for the current open assessment period 
And the specialism section Add/Remove link will state "Add an assessment entry for Heating Engineering (10202101) and Plumbing (10202102)"
And the Specialism code will display "Heating Engineering (10202101) and Plumbing (10202102)"
And I cleared the data in DB

Examples: 
| ULN         |
| 9900000012  |


@RegressionTest @AssessmentEntriesUpload
Scenario: 4714_Assessment details page - search for a ULN with a closed assessment entry which doesn't have a result recorded
Given I navigate to the Home page from the Assessment Search for a learner page
And I am on Assessment entries upload page
And I have a active Assessment Series in "4714AssessmentData.csv"
When I upload "4714AssessmentData.csv" file
And I click on "Upload" button
And I update the assessment series for <ULN>
And I navigate to the Assesment Search for a learner page
When I enter the following <ULN>
Then I am navigated to the Assessment Details page for <ULN>
And the Core section Add/Remove link will state "add a result to this learner's previous assessment" 
And the core code will display "Building Services Engineering (60369115)"
And the specialism section will state No assessment entries have yet been recorded for the current open assessment period 
And the specialism section Add/Remove link will state "Add an assessment entry for Gas Engineering (ZTLOS029)"
And the Specialism code will display "Gas Engineering (ZTLOS029)"
And I cleared the data in DB

Examples: 
| ULN         |
| 9900000011  |

