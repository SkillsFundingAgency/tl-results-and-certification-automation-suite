Feature: Create Select Core Page (Re-Register) - Story 1539
	As a Registrations Editor
	I need to be informed that I cannot select the same core for a withdrawn record
	So that I understand what I need to do



Background: 
Given I have logged in as a "RegistrationEditor" user
##Given I navigate to the dashboard
And I create a new registration which I subsequently withdraw


@RegressionTest @WithdrawRegistration
Scenario: 1539-Navigate to the Reactivate Registration Core Denial page and click Back link
When I click the Change Status link on the Withdrawn options page
And I Register the learner on a new course using the same provider
Then I am navigated to the Select the Core Page for reactivate registration
When I select a core which is identical to the current one 
Then I am shown the Core Denial page
When I click the back link on the Core Denial page
Then I am taken back to the Select the Core Page for reactivate registration
And I cleared the data in DB


@RegressionTest @WithdrawRegistration
Scenario: 1539-Verify the page cannot be accessed using bookmarks if the registration is no longer withdrawn
When I click the Change Status link on the Withdrawn options page
And I Register the learner on a new course using the same provider
Then I am navigated to the Select the Core Page for reactivate registration
When I select a core which is identical to the current one 
Then I am shown the Core Denial page
When I navigate away from the Core Denial page and attempt to navigate back using the URL
Then I am shown the Core Denial page
When I reactivate my registration and attempt to navigate back to the Core Denial page using the URL
Then I am shown the Page Not Found page
And I cleared the data in DB


@RegressionTest @WithdrawRegistration
Scenario: 1539-Verify back link on the Are you sure you want to reactivate page navigates to Core Denial page
When I click the Change Status link on the Withdrawn options page
And I Register the learner on a new course using the same provider
Then I am navigated to the Select the Core Page for reactivate registration
When I select a core which is identical to the current one 
Then I am shown the Core Denial page
When I click the Reactivate the registration button
Then I am shown the Are you sure you want to reactivate page
When I click the back link on the Are you sure you want to reactivate page
Then I am shown the Core Denial page
And I cleared the data in DB