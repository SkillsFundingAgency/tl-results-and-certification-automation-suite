Feature: 2800_LearnerCancelPage
	As a Provider
	I need to be able to cancel adding a learner’s qualification details
	So that I do not enter inaccurate qualification details

Background: 
Given I have logged in as a "ProviderBarnsleyPA" user
And I have a created a registration with LRS qualifications (Maths achieved and English not Achieved)
And I navigate to the Has the learner completed the IP page
And I select "Yes, completed" radio button and press Continue

@Ignore @RegressionTest @Provider
Scenario: 2800_Verify cancel page
When I click on "Cancel" link
Then I should see Learner cancel page
And Yes, cancel radio button should be pre seleceted
And I should see Provider dashboard page when I click Continue button
And I have deleted LRS records from the database

@Ignore @RegressionTest @Provider
Scenario: 2800_ click back link
When I click on "Cancel" link
And I click on "Back" link
Then I am shown the Check and submit page for the Add a new learner journey
And I have deleted LRS records from the database

@Ignore @RegressionTest @Provider
Scenario: 2800_ select Do not cancel
When I click on "Cancel" link
And I select do not cancel option and click continue
Then I am shown the Check and submit page for the Add a new learner journey
And I have deleted LRS records from the database