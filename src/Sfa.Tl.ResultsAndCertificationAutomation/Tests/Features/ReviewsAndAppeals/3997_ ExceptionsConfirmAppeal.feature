Feature: 3997 Post Results Services - Exceptions - Confirm Appeal page
	As an AO with a results editor user role 
	I need to review the learner details & confirm that I want to put this grade on appeal 
	so that I know I am completing my work accurately

Background: 
Given I have logged in as a "ResultsEditor" user
And I have a registration with result
And I set the End date for the Autumn Assessment Series to a date in the past
When I click on "Reviews and appeals" link


@RegressionTest @ReviewsAndAppeals
Scenario: 3997_Verify the Exceptions Confirm Appeal page and back link
Given I navigate to the Review and Appeals Learner Component Grade status page using the URL
When I click the Raise a request link
And I click Continue on the Exeptions Start Page
Then I am shown the Exceptions Confirm Appeal page
And the radio buttons will not be populated on the Exceptions Confirm Appeal page
When I click the back link on the Exceptions Confirm Appeal page
Then the Exceptions start page is displayed
And the registration for this test is deleted
And the End date for the Summer Assessment Series is reset to the date in the future

@RegressionTest @ReviewsAndAppeals
Scenario: 3997_Verify error message when pressing Submit on Exception Confirm Appeal page without selecting a redio button
Given I navigate to the Review and Appeals Learner Component Grade status page using the URL
When I click the Raise a request link
And I click Continue on the Exeptions Start Page
Then I am shown the Exceptions Confirm Appeal page
When I click Submit without selecting a radio button on the Exceptions Confirm Appeal page
Then the following error message is displayed on the Exceptions Confirm Appeal page "Please select whether you want to appeal the record"
And the registration for this test is deleted
And the End date for the Summer Assessment Series is reset to the date in the future
