Feature: 2843_IPStatusUpdatedConfirmationPage
	As a Provider
	I need to see that I have successfully updated the IP status of a learner
	So that I can be assured that learner data is up to date

Background: 
Given I have logged in as a "ProviderBarnsleyPA" user
And I have a registraion from LRS with EM and IP
And I am on Learner record page

@Ignore @RegressionTest @Provider
Scenario: 2843_Verify Ip status updated sucessfully 
When I click on "Update" link in Learner record page
And I change the radio option to "Yes, completed with special consideration"
Then I should see update success page
And Learner record page should display "Placement completed with special consideration" when I click on Back to learner record button
And The Ip table is updated with "Yes, completed with special consideration"
And I have deleted LRS records from the database

@Ignore @RegressionTest @Provider
Scenario: 2843_Navigate to Manage learner page from update success page 
When I click on "Update" link in Learner record page
And I change the radio option to "No, still to be completed"
Then I should see update success page
And The Ip table is updated with "No, still to be completed"
And clicking on Back to manage learner link should take me to dashboard page
And I have deleted LRS records from the database