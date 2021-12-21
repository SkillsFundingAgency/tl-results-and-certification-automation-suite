Feature: 4889 - Remove ability to change withdrawn status for learners that have an active registration with a different AO

BUSINESS NEED: If the ULN has an active registration with another AO then the “change status” link is not available? 
BUT will be available for all AOs if the ULN is not active within any AO.
SUMMARY/CONTEXT: Issue raised by NCFE user that when they tried to register a learner they got an error to say that 
it was a withdrawn registration but when they searched the ULN they could not find the details. 
It turns out that the withdrawn registration is a learner that was originally registered by Pearsons.

Background:
Given I have logged in as a "RegistrationEditor" user
And I have a registration with result
And I have moved registration in to withdrawn state

@RegressionTest @WithdrawRegistration
Scenario: 4889 Search for a withdrawn registration which is registered and active another AO
Given I register the registration with another AO
And I navigate to the Registration details page for my registration which is withdrawn and active with another AO
Then the Registration Details page is displayed
And the Change Status link is not displayed
And the sub heading will state the registration is withdrawn and registered with another AO
When I click on Sign Out link
Then I should be redirectted to Tlevel Start page
Given I have logged in as a "PearsonSiteAdmin" user
And I navigate to the Registration details page for my registration which is withdrawn and active with another AO
Then the Registration Details page is displayed
And the Change Status link is displayed
And I cleared the data in DB

@RegressionTest @WithdrawRegistration
Scenario: 4889 Search for a withdrawn registration which is not registered and active another AO
Given I navigate to the Registration details page for my registration which is withdrawn and active with another AO
Then the Registration Details page is displayed
And the Change Status link is displayed
And I cleared the data in DB

