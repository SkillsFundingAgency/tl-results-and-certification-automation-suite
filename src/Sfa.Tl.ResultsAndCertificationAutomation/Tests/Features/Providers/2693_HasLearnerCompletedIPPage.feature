Feature: 2693 Learner completed IP Page
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

Background: 
Given I have logged in as a "SiteAdmin" user
And I have a created a registration with LRS qualifications
And I click on "Manage learner records" link
And I click on "Add a new learner record" link

@RegressionTest @Provider
Scenario:  2693 Learner completed IP Page
When I enter the ULN 
And I click on "Continue" button
Then I expect to see the learner completed Industry Placement page
And I have deleted LRS records from the database