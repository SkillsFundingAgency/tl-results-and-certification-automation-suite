Feature: 3631 Post Results Services - Update grade for appeal outcome
	As an AO with a results editor user role 
	I need to be able to change the grade of the learner as part of the appeal outcome journey 
	so that I know you have the most up to date result on the system

Background: 
Given I have logged in as a "ResultsEditor" user
And I have a registration with result
When I click on "Reviews and appeals" link


@RegressionTest @ReviewsAndAppeals
Scenario: 3631_Validate Update grade for appeal outcome page
Given I navigate to the Review and Appeals Learner Component Grade status page using the URL
When I select I need to change the grade radio button on the Add outcome of appeal page  
Then the Update grade for appeal outcome page is displayed
And the radio buttons will not be selected on page entry
When I click the Back link on the Update grade for appeal outcome page
Then the Add outcome of appeal page is displayed
And the registration for this test is deleted

@RegressionTest @ReviewsAndAppeals
Scenario: 3631_Validate error message on Update grade for appeal outcome page
Given I navigate to the Review and Appeals Learner Component Grade status page using the URL
When I select I need to change the grade radio button on the Add outcome of appeal page  
Then the Update grade for appeal outcome page is displayed
When I click the Continue button without selecting a radio button on the Update grade for appeal outcome page
Then the following error message will be displayed 'Please select the new core component grade'
And the registration for this test is deleted


