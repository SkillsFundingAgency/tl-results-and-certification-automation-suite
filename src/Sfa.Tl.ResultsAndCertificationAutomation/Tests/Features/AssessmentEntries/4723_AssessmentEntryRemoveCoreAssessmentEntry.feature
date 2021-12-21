Feature: TLRC_4723 MANUAL JOURNEY: ASSESSMENT ENTRY CHANGES - add core to open assessment entry
	Journey and accessibility improvements to the page and to allow users to remove assessment entry for cores from Summer 2022 onwards.
	Provides more learner details, learner details structured with accessibility in mind, give clear information to user what they will be removing.

Background:
Given I have logged in as a "CityAndGuildsAdmin" user
And I cleared the data in DB
And I am on Registrations upload page
And I am on upload registration page
And I have a Academic Year in "4714RegistrationsData.csv"
When I upload "4714RegistrationsData.csv" file	
And I click on "Upload" button
And I update the registrations to the previous year
And I navigated Home page
And I navigate to the Search for a learner page

@RegressionTest @AssessmentEntriesUpload
Scenario: 4723_Verify success banner is displayed when adding a core assessment entry to a registration with one specialism
Given I enter the following <ULN>
Then I am navigated to the Assessment Details page for <ULN>
When I click the Add assessment series link 
And I select the Yes radio button and press Submit on the Add Core assessment entry page
And I click the remove link on the Assessment Details page
Then I am navigated to the Remove core assessment entry page for <ULN>
And I cleared the data in DB

Examples: 
| ULN         |
| 9900000011  |

@RegressionTest @AssessmentEntriesUpload
Scenario: 4723_Press submit without selecting a radio button onthe add core assessment entry page
Given I enter the following <ULN>
Then I am navigated to the Assessment Details page for <ULN>
When I click the Add assessment series link 
And I select the Yes radio button and press Submit on the Add Core assessment entry page
And I click the remove link on the Assessment Details page
Then I am navigated to the Remove core assessment entry page for <ULN>
And I click Submit on the Remove Core assessment entry page without selecting a radio button
Then I am shown an error message on the Remove core assessment entry page
And I cleared the data in DB

Examples: 
| ULN         |
| 9900000011  |

@RegressionTest @AssessmentEntriesUpload
Scenario: 4723_Click the back link on the core assessment entry page
Given I enter the following <ULN>
Then I am navigated to the Assessment Details page for <ULN>
When I click the Add assessment series link 
And I select the Yes radio button and press Submit on the Add Core assessment entry page
And I click the remove link on the Assessment Details page
And I click the Back link on the Remove Core assessment entry page without selecting a radio button
Then I am navigated to the Assessment Details page for <ULN>
And the new assessment entry which has been added is displayed in the Core(code) section
And I cleared the data in DB

Examples: 
| ULN         |
| 9900000011  |

@RegressionTest @AssessmentEntriesUpload
Scenario: 4723_Verify navigation when selecting the No radio button and pressing Submit on the core assessment entry page
Given I enter the following <ULN>
Then I am navigated to the Assessment Details page for <ULN>
When I click the Add assessment series link 
And I select the Yes radio button and press Submit on the Add Core assessment entry page
And I click the remove link on the Assessment Details page
And I select the No radio button and press Submit on the Remove Core assessment entry page
Then I am navigated to the Assessment Details page for <ULN>
And the new assessment entry which has been added is displayed in the Core(code) section
And I cleared the data in DB

Examples: 
| ULN         |
| 9900000011  |
