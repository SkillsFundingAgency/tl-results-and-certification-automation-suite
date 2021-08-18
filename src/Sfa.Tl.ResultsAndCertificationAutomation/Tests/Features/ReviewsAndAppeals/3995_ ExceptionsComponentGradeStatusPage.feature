Feature: 3995 Post Results Services - Exceptions - Component grade status page
	As an AO with a results editor user role 
	I need to know that the grade is final once the appeal deadline has passed 
	so that I can enter the exceptions process if I still wish to put the grade on appeal

Background: 
Given I have logged in as a "ResultsEditor" user
And I have a registration with result
And I set the End date for the Autumn Assessment Series to a date in the past
When I click on "Appeals" link


@RegressionTest @ReviewsAndAppeals
Scenario: 3995_Verify Component grade status page when the date for appeal has passed
Given I navigate to the Review and Appeals Learner Component Grade status page using the URL
Then I am shown the component grade status page
And the orignal grade and a status of ‘Final’ will now be shown on the ‘grade’ row of the core details table 
And the user will be shown text to state the result is final as the date for appeal has passed
And the registration for this test is deleted
And the End date for the Summer Assessment Series is reset to the date in the future

@RegressionTest @ReviewsAndAppeals
Scenario: 3995_Verify breadcrumbs and Search again button on Core Component Grade Status page after the date for appeal has passed
Given I navigate to the Review and Appeals Learner Component Grade status page using the URL
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
And the End date for the Summer Assessment Series is reset to the date in the future

