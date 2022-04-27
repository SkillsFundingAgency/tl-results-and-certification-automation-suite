Feature: 2846_EnglishAndMathsStatusUpdatedConfirmationPage
	As a Provider
	I need to see that I have successfully updated English & Maths status for a learner
	So that the English & Maths data is kept up to date

Background: 
Given I have logged in as a "ProviderBarnsleyPA" user
And I have a registraion with EM and IP from non LRS
And I am on Learner record page

@Ignore @RegressionTest @Provider
Scenario: 2846_Verify EM status updated sucessfully 
When I click on "Query" link in Learner record page
And I change the radio option to "Achieved the minimum standard for learners with SEND" in update English and Maths page
Then I should see update English and Maths acheivement success page
And Learner record page should display "Achieved minimum standard for learners with SEND" when I click on Back to learner record button
And I have deleted LRS records from the database

@Ignore @RegressionTest @Provider
Scenario: 2846_Navigate to Manage learner page from update success page
When I click on "Query" link in Learner record page
And I change the radio option to "Not achieved the minimum standard" in update English and Maths page
Then I should see update English and Maths acheivement success page
And clicking on Back to manage learner link should take me to dashboard page
And I have deleted LRS records from the database