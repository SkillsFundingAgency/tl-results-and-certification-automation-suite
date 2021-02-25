Feature: 2311_Create Learner's Results page
	As a Results Editor
	I need to be able to view Results details for students
	So that I can add results manually for individual students

		
Background: 
Given I have logged in as a "SiteAdmin" user
And I initially clear the database 
And I am on Registrations upload page
And I upload "2311RegistrationsData.csv" file
And I navigated Home page
And I am on Assessment entries upload page
When I upload "2311AssessmentData.csv" file
And I click on "Submit" button
Then I will be shown the Assessments Upload success page
Given I navigate to the Results Search for a learner page
When I click on "Results" link
Then I should be navigated to Results dashboard page
When I click on "Search for a learner" link
Then I will be navigated to the Results Search for a Learner page


@RegressionTest @Results
Scenario: 2311_Results learners page for a registration with no assessment entry and a specialism is added
Given I search for a <ULN>
Then the Learners Results page will be displayed for <ULN>
And the Core is displayed as "Core: Agriculture, Environmental and Animal Care (77777777)"
And Specialism is displayed as "Specialism: Agriculture, Land Management and Production (70000002)"
And the text below the Core will display "Core result cannot be entered until an assessment entry is added."
And the text below the Specialism will display "Specialism result cannot be entered until an assessment entry is added."
When I click the Search again link on the Results Learners Results page
Then I will be navigated to the Results Search for a Learner page
And I cleared the data in DB

Examples: 
| ULN         |
| 9900000006  |

@RegressionTest @Results
Scenario: 2311_Results learners page for a registration with no assessment entry and a specialism is not added
Given I search for a <ULN>
Then the Learners Results page will be displayed for <ULN>
And the Core is displayed as "Core: Agriculture, Environmental and Animal Care (77777777)"
And Specialism is displayed as "Specialism: Not specified"
And the text below the Core will display "Core result cannot be entered until an assessment entry is added."
And there will no text below the Specialism
And I cleared the data in DB
Examples: 
| ULN         |
| 9900000007  |

@RegressionTest @Results
Scenario: 2311_Results learners page for a registration with an assessment entry and a specialism is added
Given I search for a <ULN>
Then the Learners Results page will be displayed for <ULN>
And the Core is displayed as "Core: Agriculture, Environmental and Animal Care (77777777)"
And Specialism is displayed as "Specialism: Agriculture, Land Management and Production (70000002)"
And the text below the Core will display the assessment series as "Summer 2021" and "Grade: Not received"
And "Add result" link is displayed
And the text below the Specialism will display "Specialism result cannot be entered until an assessment entry is added."
And I cleared the data in DB
Examples: 
| ULN         |
| 9900000008  |

@RegressionTest @Results
Scenario: 2311_Results learners page for a registration with an assessment entry but no specialism
Given I search for a <ULN>
Then the Learners Results page will be displayed for <ULN>
And the Core is displayed as "Core: Agriculture, Environmental and Animal Care (77777777)"
And Specialism is displayed as "Specialism: Not specified"
And the text below the Core will display the assessment series as "Summer 2021" and "Grade: Not received"
And there will no text below the Specialism
And I cleared the data in DB
Examples: 
| ULN         |
| 9900000009  |

@RegressionTest @Results
Scenario: 2311_Breadcrumbs verification
Given I search for a <ULN>
Then the Learners Results page will be displayed for <ULN>
When I click the Search for a Learner breadcrumb link on the Learner's results page
Then I will be navigated to the Results Search for a Learner page
Given I navigate back to the Results Learners Results page from the Results Search for a learner page using <ULN> and click the Results breadcrumb
And I click the Results breadcrumb link
Then I should be navigated to Results dashboard page
Given I navigate back to the Results Learners Results page from the Results dashboard using <ULN> and click the Home breadcrumb
And I click the Home breadcrumb link
Then I am taken to the home page
And I cleared the data in DB
Examples: 
| ULN         |
| 9900000010  |