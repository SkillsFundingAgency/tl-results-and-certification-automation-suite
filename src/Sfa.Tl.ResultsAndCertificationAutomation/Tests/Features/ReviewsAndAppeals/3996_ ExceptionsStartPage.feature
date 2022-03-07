Feature: 3996 Post Results Services - Exceptions - Start page
	As an AO with a results editor user role 
	I need to know what the exception process means 
	so that I know when the change will be made

Background: 
Given I have logged in as a "ResultsEditor" user
And I have a registration with result
And I set the End date for the Autumn Assessment Series to a date in the past
When I click on "Appeals" link


@Ignore @RegressionTest @ReviewsAndAppeals
Scenario: 3996_Verify the Exceptions start page and back link
Given I navigate to the Review and Appeals Learner Component Grade status page using the URL
Then I am shown the component grade status page
And I click the Raise a request link
Then the Exceptions start page is displayed
And when I click the back link on the Exceptions start page
Then I am shown the component grade status page
And the orignal grade and a status of ‘Final’ will now be shown on the ‘grade’ row of the core details table 
And the user will be shown text to state the result is final as the date for appeal has passed
And the registration for this test is deleted
And the End date for the Summer Assessment Series is reset to the date in the future
