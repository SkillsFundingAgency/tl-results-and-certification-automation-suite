Feature: 3632 Post Results Services - Component grade status - Final result
	As an AO, 
	I need to know that the learner’s core component has been successfully changed to ‘Final’ 
	so that I can be sure I have successfully recorded the outcome of the appeal.

Background: 
Given I have logged in as a "ResultsEditor" user
And I have a registration with result
When I click on "Appeals" link


@RegressionTest @ReviewsAndAppeals
Scenario: 3632_Validate Core Component Grade Status shows grade status as 'FINAL' when grade was kept the same after appeal
Given I navigate to the Review and Appeals Learner Component Grade status page using the URL
When  I select 'The grade is the same' radio button on the Add outcome of appeal page 
And I select Submit on the Appeals Check and submit page
Then I am shown the component grade status page
And there will be a success banner showing the grade is Final
And the orignal grade and a status of ‘Final’ will now be shown on the ‘grade’ row of the core details table 
And the result on the database is set to final
And the registration for this test is deleted

@RegressionTest @ReviewsAndAppeals
Scenario: 3632_Validate Core Component Grade Status shows grade status as 'FINAL' when grade was appealed
Given I navigate to the Review and Appeals Learner Component Grade status page using the URL
When I select I need to change the grade radio button on the Add outcome of appeal page  
And I click the grade B radio button on the Update grade for appeal outcome page
And I select Submit on the Appeals Check and submit page
Then I am shown the component grade status page
And there will be a success banner showing the grade is Final
And the new grade 'B' and a status of ‘Final’ will now be shown on the ‘grade’ row of the core details table
And the result on the database is set to final
When I refresh the Component Grade status page
Then the success banner is not shown on the Component Grade status page
And the registration for this test is deleted

@RegressionTest @ReviewsAndAppeals
Scenario: 3632_Verify breadcrumbs and Search again button on Core Component Grade Status page after FINAL status is shown
Given I navigate to the Review and Appeals Learner Component Grade status page using the URL
When  I select 'The grade is the same' radio button on the Add outcome of appeal page 
And I select Submit on the Appeals Check and submit page
Then I am shown the component grade status page
When I press the Search for a learner breadcrumb on the Review and Appeals Learner Component Grade status page
Then the Review and Appeals Search page is displayed
When I press the Reviews and Appeals breadcrumb on the Review and Appeals Learner Component Grade status page
Then the Reviews and Appeals start page is displayed
When I press the Home breadcrumb on the Review and Appeals Learner Component Grade status page
Then I will be navigated to the T Levels Dashboard page
When I press the Search again button on the Review and Appeals Learner Component Grade status page
Then the Review and Appeals Search page is displayed
And the registration for this test is deleted