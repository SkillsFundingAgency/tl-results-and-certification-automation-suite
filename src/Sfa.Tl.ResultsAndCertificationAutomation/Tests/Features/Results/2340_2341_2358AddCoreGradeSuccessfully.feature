Feature: 2340_Create Select the core result page (add)
	As a Results Editor
	I need to be able to manually add the result for a learner
	So that the results data can be kept up to date

Feature: 2341_Create result added confirmation page
	As a Results Editor
	I need to be able to see that I have added a result to a learner
	So that I can ensure results data is updated

	
Feature: 2358_Learner's results page (with result added)
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
##Given I navigate to the Results Search for a learner page
When I click on "add results" link
Then I should be navigated to Results dashboard page
When I click on "Manage a result" link
Then I will be navigated to the Results Search for a Learner page



@RegressionTest @Results
Scenario: 2340_Press Submit on the Select Core page without changing the default grade
Given I search for a <ULN>
Then the Learners Results page will be displayed for <ULN>
When I click the Add result link
Then the Select the core result page is displayed  for a registration with core "Agriculture, Environmental and Animal Care (77777777)" and assessment series of "Autumn 2021"
When I click Submit on the Select a core result page without making any changes
Then the Learners Results page will be displayed for <ULN> 
And the Core is displayed as "Core (code): Agriculture, Environmental and Animal Care (77777777)"
And the text below the Core will display the assessment series as "Autumn 2021" and "Not received"
And I cleared the data in DB
Examples: 
| ULN         |
| 9900000008  |


@RegressionTest @Results
Scenario: 2340_Press back link on the Select Core page 
Given I search for a <ULN>
Then the Learners Results page will be displayed for <ULN>
When I click the Add result link
Then the Select the core result page is displayed  for a registration with core "Agriculture, Environmental and Animal Care (77777777)" and assessment series of "Autumn 2021"
When I click the back link on the results select core page
Then the Learners Results page will be displayed for <ULN> 
And the Core is displayed as "Core (code): Agriculture, Environmental and Animal Care (77777777)"
And the text below the Core will display the assessment series as "Autumn 2021" and "Not received"
And I cleared the data in DB
Examples: 
| ULN         |
| 9900000008  |

@RegressionTest @Results
Scenario: 2341_2358_Add a grade and verify the result is added and  validate the result added confirmation page   
Given I search for a <ULN>
Then the Learners Results page will be displayed for <ULN>
When I click the Add result link
Then the Select the core result page is displayed  for a registration with core "Agriculture, Environmental and Animal Care (77777777)" and assessment series of "Autumn 2021"
When I select a core result as "A*"
Then the result added successfully confirmation page is displayed for <ULN>
When I press the Back to learners results button
Then the Learners Results page will be displayed for <ULN> 
And the Core is displayed as "Core (code): Agriculture, Environmental and Animal Care (77777777)"
And the text below the Core will display the assessment series as "Autumn 2021" and "A*"
And "Change" link is displayed
And I cleared the data in DB
Examples: 
| ULN         |
| 9900000008  |