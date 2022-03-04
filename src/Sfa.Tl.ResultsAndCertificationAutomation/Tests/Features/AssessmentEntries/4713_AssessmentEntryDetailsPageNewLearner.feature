Feature: 4713_MANUAL JOURNEY: ASSESSMENT ENTRY CHANGES - Details page - New learner
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
And I navigated Home page
And I navigate to the Search for a learner page

@Ignore @RegressionTest @AssessmentEntriesUpload
Scenario: 4713_Navigate to Assessment Details page for a new learner with a single specialism code
When I enter the following <ULN>
Then I am navigated to the Assessment Details page for <ULN>
And the Core section will state "You cannot register this learner for a core component assessment until the summer 2022 window opens." 
And the core code will display "Building Services Engineering (60369115)"
And the specialism section will state "You cannot register this learner for an occupational specialism assessment until the summer 2023 window opens."
And the Specialism code will display "Gas Engineering (ZTLOS029)"
And I cleared the data in DB

Examples: 
| ULN         |
| 9900000011  |


@RegressionTest @AssessmentEntriesUpload
Scenario: 4713_Navigate to Assessment Details page for a new learner with no specialism codes recorded
When I enter the following <ULN>
Then I am navigated to the Assessment Details page for <ULN>
And the Core section will state "You cannot register this learner for a core component assessment until the summer 2022 window opens." 
And the core code will display "Building Services Engineering (60369115)"
And the specialism section will state "This learner does not have an occupational specialism recorded on this service"
And when I click on the Add an occupational specialism recorded on this service link
Then I am navigated to the Registration Details page for the learner's <ULN>
And I cleared the data in DB

Examples: 
| ULN         |
| 9900000013  |


@Ignore @RegressionTest @AssessmentEntriesUpload
Scenario: 4713_Navigate to Assessment Details page for a new learner with multiple specialism codes
When I enter the following <ULN>
Then I am navigated to the Assessment Details page for <ULN>
And the Core section will state "You cannot register this learner for a core component assessment until the summer 2022 window opens." 
And the core code will display "Building Services Engineering (60369115)"
And the specialism section will state "You cannot register this learner for an occupational specialism assessment until the summer 2023 window opens."
And the Specialism code will display "Heating Engineering (10202101) and Plumbing (10202102)"
And I cleared the data in DB

Examples: 
| ULN         |
| 9900000012  |


@RegressionTest @AssessmentEntriesUpload
Scenario: 4713_Validate the breadcrumbs on the Assessment Entry Learner Details page
When I enter the following <ULN>
Then I am navigated to the Assessment Details page for <ULN>
When I click the Search for a learner breadcrumb on the Assessment Entry Learner Details page
Then I am navigated to the Search for a learner page
When I search for the <ULN> and click the Asessments breadcrumb on the Assessment Entry Learner Details page
Then I am navigated to the assessments dashboard
When I search for the <ULN> and click the Home breadcrumb on the Assessment Entry Learner Details page
Then I am navigated to the Home page
And I cleared the data in DB

Examples: 
| ULN         |
| 9900000012  |