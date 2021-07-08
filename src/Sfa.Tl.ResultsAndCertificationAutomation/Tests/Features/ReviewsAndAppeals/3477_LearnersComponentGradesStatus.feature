Feature: 3477 Post Results Services - Learner's component grades status
	As an AO with a results editor user role, 
	once I have searched a valid ULN I need to see the learner’s component grades status 
	so that I can review it before I choose to request the appeal

Background: 
Given I have logged in as a "ResultsEditor" user
And I have a registration with result
When I click on "Reviews and appeals" link


@RegressionTest @ReviewsAndAppeals
Scenario: 3477_Verify learner component grade status page
Given I navigate to the Review and Appeals Learner Component Grade status page using the URL
Then the Review and Appeals Learner Component Grade status page is displayed as per the acceptane criteria
And the registration for this test is deleted