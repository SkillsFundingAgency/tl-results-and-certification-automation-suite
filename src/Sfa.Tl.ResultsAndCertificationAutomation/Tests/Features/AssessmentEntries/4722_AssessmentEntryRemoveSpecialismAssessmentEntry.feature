Feature: TLRC_4722 MANUAL JOURNEY: ASSESSMENT ENTRY CHANGES - remove specialism assessment entry
		  BUSINESS NEED: NEW PAGE - journey and accessibility improvements to the page and to allow users to remove assessment entry for Specialisms from Summer 2022 onwards
		  SUMMARY/CONTEXT: provides more learner details, learner details structured with accessibility in mind, give clear information to user what they will be removing.

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
Scenario: 4722_Verify the Remove occupational specialism(s) assessment entry page
When I enter the following <ULN>
And I add an assessment entry for a couplet specialism
And I click the remove link on the Assessment Details page for the specialism/s
Then I am shown the Remove specialism assessment entry page for <ULN> in "Heating Engineering (10202101) and Plumbing (10202102)" 
And I cleared the data in DB

Examples: 
| ULN         |
| 9900000012  |

@RegressionTest @AssessmentEntriesUpload
Scenario: 4722_Press submit without selecting a radio button on the Remove occupational specialism(s) assessment entry page
When I enter the following <ULN>
And I add an assessment entry for a couplet specialism
And I click the remove link on the Assessment Details page for the specialism/s
Then I am shown the Remove specialism assessment entry page for <ULN> in "Heating Engineering (10202101) and Plumbing (10202102)" 
When I click Submit on the Remove occupational specialism(s) assessment entry page without selecting a radio button
Then I am shown an error message on the Remove occupational specialism(s) assessment entry page
And I cleared the data in DB

Examples: 
| ULN         |
| 9900000012  |

@RegressionTest @AssessmentEntriesUpload
Scenario: 4722_Click the back link on the Remove occupational specialism(s) assessment entry page
When I enter the following <ULN>
And I add an assessment entry for a couplet specialism
And I click the remove link on the Assessment Details page for the specialism/s
Then I am shown the Remove specialism assessment entry page for <ULN> in "Heating Engineering (10202101) and Plumbing (10202102)" 
When I click the Back link on the Remove occupational specialism(s) assessment entry page
Then I am navigated to the Assessment Details page for <ULN>
And the remove link for the specialism assessment entry is still visible
And the specialism assessment entry details are displayed
And I cleared the data in DB

Examples: 
| ULN         |
| 9900000012  |

@RegressionTest @AssessmentEntriesUpload
Scenario: 4722_Verify navigation when selecting the No radio button and pressing Submit on the Remove occupational specialism(s) assessment entry page
When I enter the following <ULN>
And I add an assessment entry for a couplet specialism
And I click the remove link on the Assessment Details page for the specialism/s
Then I am shown the Remove specialism assessment entry page for <ULN> in "Heating Engineering (10202101) and Plumbing (10202102)" 
When I select the No radio button and press Submit on the Remove occupational specialism(s) assessment entry page
Then I am navigated to the Assessment Details page for <ULN>
And the remove link for the specialism assessment entry is still visible
And the specialism assessment entry details are displayed
And I cleared the data in DB

Examples: 
| ULN         |
| 9900000012  |

