Feature: Create Select Core Page (Re-Register) - Story 1489
	As a Registrations Editor
	 need to enter new Core of student re-registering
	So that the record can be up to date



Background: 
Given I have logged in as a "RegistrationEditor" user
Given I navigate to the dashboard
And I create a new registration which I subsequently withdraw


@RegressionTest @WithdrawRegistration
Scenario: 1489-Navigate to the Reactivate Registration Change Core page and click Back link
When I click the Change Status link on the Withdrawn options page
And I Register the learner on a new course using the same provider
Then I am navigated to the Select the Core Page for reactivate registration
When I click the back link on the Reactivate Registration Change Core Page
Then I am navigated to the Reactivate Registration Change Provider page

@RegressionTest @WithdrawRegistration
Scenario: 1489-Error message is displayed if a dropdown value is not selected
When I click the Change Status link on the Withdrawn options page
And I Register the learner on a new course using the same provider
Then I am navigated to the Select the Core Page for reactivate registration
When I click continue without selecting a dropdown value 
Then I am shown an error message on the  Select the Core Page for reactivate registration page stating "Select a core"
##checks all error messages on the page and checks page title includes "Error"

@Ignore @RegressionTest @WithdrawRegistration
Scenario: 1489-Verify the page cannot be accessed using bookmarks if the registration is no longer withdrawn
When I click the Change Status link on the Withdrawn options page
And I Register the learner on a new course using the same provider
Then I am navigated to the Select the Core Page for reactivate registration
When I navigate away and attempt to navigate back using the URL
Then I am navigated to the Select the Core Page for reactivate registration
When I reactivate my registration and attempt to navigate back to the Change Core page using the URL
Then I am shown the Page Not Found page

