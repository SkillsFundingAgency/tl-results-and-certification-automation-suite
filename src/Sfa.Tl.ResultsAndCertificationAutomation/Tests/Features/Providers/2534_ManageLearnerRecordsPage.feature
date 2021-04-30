Feature: 2534_ManageLearnerRecordsPage
	As a Provider
	I need to be able to add English/Maths and Industry Placement data for learners
	So that learner details can be kept up to date

Background: 
Given I have logged in as a "ProviderBarnsleyPA" user

@RegressionTest @Provider
Scenario: 2534 Manage Learner Records Page
When I click on "Manage learner T Level records" link
Then I should see Manage learner records page
And I should see "Add a new learner T Level record" and "Update a learner T Level record" links
And I should be back to dashboard page when i click on home breadcrumb

