Feature: SpecFlowFeature1
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

Background: 
Given I have logged in as a "SiteAdmin" user
And I have a created a registration with LRS qualifications
And I click on "Manage learner records" link
And I click on "Add a new learner record" link

@RegressionTest @Provider
Scenario:  TEST Manage Learner Records Page
When I enter the ULN 
And I click on "Continue" button
Then I expect to see the learner completed Industry Placement page
And the registration for this test is deleted