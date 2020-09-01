Feature: VerifyPrivacy
As ESFA
I need to update the privacy policy
So that the policy reflects data collection 

@RegressionTest
Scenario: Privacy link on Tlevel start page
Given I have navigated to Tlevel Start page
When I click on Privacy link
Then I should see Privacy page

@RegressionTest
Scenario: Privacy Link on Tlevel Dashboard
Given I have logged in as a "AllUser" user
When I click on Privacy link
Then I should see Privacy page