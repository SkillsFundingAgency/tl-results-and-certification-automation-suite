Feature: 2371 Create Select the core result page (change)

As a Results Editor
I need to be able to manually change the result for a learner
So that the results data can be kept up to date
			
Background: 
Given I have logged in as a "SiteAdmin" user
And I initially clear the database 
And I am on Registrations upload page
And I upload "2311RegistrationsData.csv" file
And I navigated Home page
And I am on Assessment entries upload page
When I upload "2311AssessmentData.csv" file
And I click on "Upload" button
Then I will be shown the Assessments Upload success page
##Given I navigate to the Results Search for a learner page
When I click on "add results" link
Then I should be navigated to Results dashboard page
When I click on "Manage a result" link
Then I will be navigated to the Results Search for a Learner page


@RegressionTest @Results
Scenario: 2371_Navigate to the Change Core Result page and press the back link 
Given I have a <ULN> with core result of "A*" with core "Agriculture, Environmental and Animal Care (77777777)" and assessment series "Autumn 2021" and specialism "Agriculture, Land Management and Production (70000002)"
When I press the Change link on the Results Learners Results page
Then the Results Change Result page is displayed for is displayed for the registration with core "Agriculture, Environmental and Animal Care (77777777)" and assessment series of "Autumn 2021"
When I press the back link in the Results Change Results page
Then the Core is displayed as "Core (code): Agriculture, Environmental and Animal Care (77777777)"
And the text below the Core will display the assessment series as "Autumn 2021" and "A*"
And I cleared the data in DB
Examples: 
| ULN         |
| 9900000008  |


@RegressionTest @Results
Scenario: 2371_Navigate to the Change Core Result page and press the Change button without changing the result
Given I have a <ULN> with core result of "A*" with core "Agriculture, Environmental and Animal Care (77777777)" and assessment series "Autumn 2021" and specialism "Agriculture, Land Management and Production (70000002)"
When I press the Change link on the Results Learners Results page
Then the Results Change Result page is displayed for is displayed for the registration with core "Agriculture, Environmental and Animal Care (77777777)" and assessment series of "Autumn 2021"
When I press the Change button on the Results Change Results page without changing the grade
Then the Core is displayed as "Core (code): Agriculture, Environmental and Animal Care (77777777)"
And the text below the Core will display the assessment series as "Autumn 2021" and "A*"
And I cleared the data in DB
Examples: 
| ULN         |
| 9900000008  |