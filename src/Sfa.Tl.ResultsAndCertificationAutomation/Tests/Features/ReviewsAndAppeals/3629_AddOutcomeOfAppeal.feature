Feature: 3629 Post Results Services - Add outcome of appeal
	As an AO with a results editor user role 
	I need to be able to record the outcome of an appeal 
	so that I can finalise the grade for this record

Background: 
Given I have logged in as a "ResultsEditor" user
And I have a registration with result
When I click on "Appeals" link


@RegressionTest @ReviewsAndAppeals
Scenario: 3629_Validate Add outcome of appeal page and Back link
Given I navigate to the Review and Appeals Learner Component Grade status page using the URL
And my registration is set to BEING APPEALED
And I press the update button next to the grade I would like to appeal
Then the Add outcome of appeal page is displayed
When I press the Back link on the Add outcome of appeal page
Then the Review and Appeals Learner Component Grade status page is displayed 
And the registration for this test is deleted


@RegressionTest @ReviewsAndAppeals
Scenario: 3629_Verify error message displayed when no radio button is selected
Given I navigate to the Review and Appeals Learner Component Grade status page using the URL
And my registration is set to BEING APPEALED
And I press the update button next to the grade I would like to appeal
Then the Add outcome of appeal page is displayed
When I press the Continue button without selecting a radio button Add outcome of appeal page
Then the following error message 'Please select the outcome of the appeal' will be displayed
And the registration for this test is deleted