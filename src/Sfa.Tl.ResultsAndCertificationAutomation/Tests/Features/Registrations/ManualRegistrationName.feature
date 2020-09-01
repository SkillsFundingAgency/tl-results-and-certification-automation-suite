Feature: ManualRegistrationName
	As a Registrations Editor
	I want to add firstname and lastname
	So that I can continue with manual registration

Background: 
	Given I have logged in as a "RegistrationEditor" user
	And I have entered all valid data to navigate to "add-registration-learners-name"

@ManualRegistration
Scenario: Verify firstname and lastname field are available
	And I see following fields are available
	| Field name |
	| First name |
	| Last name  |

@ManualRegistration
Scenario: Verify mandatory field validation
	When click on "Continue" button
	Then I should see the following error messages
	| Field      | Error messages   |
	| First name | Enter first name |
	| Last name  | Enter last name  |
	And I should see the following error summary messages
	| Error messages   |
	| Enter first name |
	| Enter last name  |

@ManualRegistration
Scenario: Verify maximum length validation 
	And I have entered a string with length "101" in "First name" field
	And I have entered a string with length "101" in "Last name" field
	When click on "Continue" button
	Then I should see the following error messages
	| Field name | Error messages                             |
	| First name | First name must be 100 characters or fewer |
	| Last name  | Last name must be 100 characters or fewer  |
	And I should see the following error summary messages
	| Error messages                             |
	| First name must be 100 characters or fewer |
	| Last name must be 100 characters or fewer  |

@ManualRegistration
Scenario: Verify navigated to Dateofbirth page on submit
	And I filled form with following information 
	| Field name | Value |
	| First name | John  |
	| Last name  | Smith |
	When click on "Continue" button
	Then I should be navigated to the Dateofbirth page. 

@ManualRegistration
Scenario: Verify Back link navigated to the Uln page
	When I click on Back link on page
	Then I should be navigated to the Uln page.
	And I see Uln value is populated
