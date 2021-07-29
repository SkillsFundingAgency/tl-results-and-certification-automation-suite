Feature: 3727 Post - Results Services - Multiple assessment entries
	As an AO with a results editor user role, 
	I need to select the relevant assessment series I am looking to appeal 
	so that I can make sure I record the data accurately 

Background: 
Given I have logged in as a "ResultsEditor" user
And I have a registration with a result and two assessment entries
When I click on "Reviews and appeals" link


@RegressionTest @ReviewsAndAppeals
Scenario: 3727_Validate Select assessment entry page and back link navigation
Given I navigate to the Review and Appeals Learner Component Grade status page using the URL
Then the Select exam period page is displayed 
When I press the back link on the Select assessment entry page
Then the Review and appeals Search for a learner page is displayed
And the registration for this test is deleted

@RegressionTest @ReviewsAndAppeals
Scenario: 3727_Validate error message when no radio button is selected
Given I navigate to the Review and Appeals Learner Component Grade status page using the URL
Then the Select exam period page is displayed 
When I press the Submit button on the Select assessment entry page
Then the following error message is displayed on the Select exam period page "Please select the exam period"
And the registration for this test is deleted

@RegressionTest @ReviewsAndAppeals
Scenario: 3727_Select a assessment series with a grade against it
Given I navigate to the Review and Appeals Learner Component Grade status page using the URL
Then the Select exam period page is displayed 
When I select an assessment series which has a grade against it
Then the Review and Appeals Learner Component Grade status page is displayed as per the acceptance criteria
And the registration for this test is deleted

@RegressionTest @ReviewsAndAppeals
Scenario: 3727_Select a assessment series without a grade against it
Given I navigate to the Review and Appeals Learner Component Grade status page using the URL
Then the Select exam period page is displayed 
When I select an assessment series which has not got a grade against it
Then the no grades to appeal page will reflect the assessment series selected on the radio button
And the registration for this test is deleted


