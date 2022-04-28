Feature: 2839_QueryEnglishAndMathsPage
	As a Provider
	I need to be able to query a learners English & Maths qualifications
	So that I can ensure they are accurate

Background: 
Given I have logged in as a "ProviderBarnsleyPA" user
And I have a registraion from LRS with EM and IP
And I am on Learner record page

@Ignore @RegressionTest @Provider
Scenario: 2839_ Verify Query English and Maths status page
When I click on "Query" link in Learner record page
Then I should see Query English and Maths status page
And clicking on back to learner record button navigates to learner record page
And clicking on back link navigates to learner record page
And I have deleted LRS records from the database
