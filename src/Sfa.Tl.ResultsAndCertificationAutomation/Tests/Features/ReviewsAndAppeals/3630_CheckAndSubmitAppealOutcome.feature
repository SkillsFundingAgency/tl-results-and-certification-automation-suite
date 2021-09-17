Feature: 3630 Post Results Services - Check & submit appeal outcome
	As an AO with a results editor user role 
	I need to check that I have recorded the correct appeal outcome before I finalise the grade 
	so that I can make sure I am inputting the correct information. 

Background: 
Given I have logged in as a "ResultsEditor" user
And I have a registration with result
When I click on "Appeals" link


@RegressionTest @ReviewsAndAppeals
Scenario: 3630_Validate Check and submit outcome of appeal page
Given I navigate to the Review and Appeals Learner Component Grade status page using the URL
When  I select 'The grade is the same' radio button on the Add outcome of appeal page  
Then the Check & submit appeal outcome page is displayed
And the New grade is the same as the old grade 
And the help text for the page will be displayed
When I click the Back link on the Check & submit appeal outcome page
Then the Add outcome of appeal page is displayed
And the registration for this test is deleted


