Feature: 2845_UpdateEnglishAndMathsPage
	As a Provider
	I need to be able to update a learners English & Maths qualification status
	So that qualification data can be kept up to date

Background: 
Given I have logged in as a "ProviderBarnsleyPA" user
And I have a registraion with EM and IP from non LRS
And I click on "Manage learner records" link
And I click on "Update a learner record" link

@RegressionTest @Provider
Scenario: 2845_Verify update English and Maths page
When I enter uln and click search
When I click on "Query" link in Learner record page
Then I should see Update English and Maths page
And "Achieved the minimum standard" radio option is pre selected in English and Maths page
And clicking on back link navigate back to learner record page
And clicking on update button without changing radio option navigates to learner record page
And I have deleted LRS records from the database