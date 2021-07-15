Feature: 3478 Post Results Services - Core component being appealed
	As an AO with a results editor user role, 
	I need to confirm that this learner’s core component is the one I want to appeal before I continue 
	so that I can be sure all of the information is correct.

Background: 
Given I have logged in as a "ResultsEditor" user
And I have a registration with result
When I click on "Reviews and appeals" link


@RegressionTest @ReviewsAndAppeals
Scenario: 3478_Validate Core Component Grade Status page and Back link
Given I navigate to the Review and Appeals Learner Component Grade status page using the URL
And I press the update button next to the grade I would like to appeal
Then I am shown the Core component being appealed page
And when I press the Back link on the Core component being appealed page
Then the Review and Appeals Learner Component Grade status page is displayed as per the acceptance criteria
And the registration for this test is deleted

@RegressionTest @ReviewsAndAppeals
Scenario: 3478_Verify error message on Core component being appealed page
Given I navigate to the Review and Appeals Learner Component Grade status page using the URL
And I press the update button next to the grade I would like to appeal
And I press Submit without selecting a radio button on the Core component being appealed page
Then I am shown an error message on the Core component being appealed page stating 'Please select whether a grade is being appealed'
And the registration for this test is deleted