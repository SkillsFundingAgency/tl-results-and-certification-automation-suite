Feature: Manage learner records page
As a Provider
I need to be able to add English/Maths and Industry Placement data for learners
So that learner details can be kept up to date

Background: 
Given I have logged in as a "SiteAdmin" user

@RegressionTest @Learner
Scenario: 2534_Navigate to the Manage Learner Record page and press the Home link
And I navigate to the Manage Learner Records page
Then the page headings, page text URL and title will match the expected values for the Manage Learner Records page
And there will be two box options 'Add a new learner record' and 'Update a learner record'
Given I press the home breadcrumb on the Manage Learner Record page
Then I am taken to the home page