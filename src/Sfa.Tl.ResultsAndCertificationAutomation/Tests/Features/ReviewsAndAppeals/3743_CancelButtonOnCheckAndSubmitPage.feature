Feature: 3743 Post Results Services - Cancel button on check & submit
	As an AO with a results editor role, 
	I need to be able to cancel recording the outcome of an appeal from the check & submit page 
	so that I do not have to track back to the 'component grade status' page

Background: 
Given I have logged in as a "ResultsEditor" user
And I have a registration with result
When I click on "Appeals" link


@Ignore @RegressionTest @ReviewsAndAppeals
Scenario: 3743_Verify Cancel appeal update page and back link 
Given I navigate to the Review and Appeals Learner Component Grade status page using the URL
When I select I need to change the grade radio button on the Add outcome of appeal page  
And I click the grade B radio button on the Update grade for appeal outcome page
Then the Check & submit appeal outcome page is displayed showing the old and newly selected grades
When I click the Cancel link
Then the Cancel appeal update page is shown
When I press the Back link on the Check & submit appeal outcome page
Then the Check & submit appeal outcome page is displayed showing the old and newly selected grades
And the registration for this test is deleted

@Ignore @RegressionTest @ReviewsAndAppeals
Scenario: 3743_Click Continue button on Cancel appeal update page without selecting a radio button
Given I navigate to the Review and Appeals Learner Component Grade status page using the URL
When I select I need to change the grade radio button on the Add outcome of appeal page  
And I click the grade B radio button on the Update grade for appeal outcome page
Then the Check & submit appeal outcome page is displayed showing the old and newly selected grades
When I click the Cancel link
And I press the Continue button without selecting a radio button on the Add outcome of appeal page  
Then I am shown an error message on the Cancel appeal update page stating 'Please select whether you want to cancel the update to this appeal'
And the registration for this test is deleted

@Ignore @RegressionTest @ReviewsAndAppeals
Scenario: 3743_Click Yes, cancel, radio button on the Cancel appeal update page
Given I navigate to the Review and Appeals Learner Component Grade status page using the URL
When I select I need to change the grade radio button on the Add outcome of appeal page  
And I click the grade B radio button on the Update grade for appeal outcome page
Then the Check & submit appeal outcome page is displayed showing the old and newly selected grades
When I click the Cancel link
And I press the Yes, I want to cancel radio button on the Add outcome of appeal page  
Then the Review and Appeals Learner Component Grade status page is displayed with the original grade
And the registration for this test is deleted

@Ignore @RegressionTest @ReviewsAndAppeals
Scenario: 3743_Click 'No, I do not want to cancel' radio button on the Cancel appeal update page
Given I navigate to the Review and Appeals Learner Component Grade status page using the URL
When I select I need to change the grade radio button on the Add outcome of appeal page  
And I click the grade B radio button on the Update grade for appeal outcome page
Then the Check & submit appeal outcome page is displayed showing the old and newly selected grades
When I click the Cancel link
And I press the 'No, I do not want to cancel' radio button on the Add outcome of appeal page  
Then the Check & submit appeal outcome page is displayed showing the old and newly selected grades
And the registration for this test is deleted