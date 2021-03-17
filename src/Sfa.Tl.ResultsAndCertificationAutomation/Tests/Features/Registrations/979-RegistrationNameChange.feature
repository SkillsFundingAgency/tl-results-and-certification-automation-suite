Feature: Create Change Registration Page - Name - Story 979
	As a Registrations Editor
    I need to be able to change the name of a learner after having searched for them
    So that it can be kept up to date
    
Background: 
Given I have logged in as a "RegistrationEditor" user
And I click on Add a new registration link
And I create a manual registration

@RegressionTest @ChangeRegistration
Scenario: 979-Pressing the Change link on the Registration Details page takes the user to the Change Registration Name page
And I search for my registration
Then I should see results in the page
When I click the Change link next to Name
Then I am shown the Change Details Name page defaulted with the name registered to the ULN 
When I click the Back link
Then I will be directed to the Registration Details page
When I click the Change link next to Name
And press the change link without making amendments to the name
Then I will be directed to the Registration Details page
And I cleared the data in DB
##Test covers Back Link, page heading, page title, URL and button text and confirms pressing change without changing name goes back to Reg Details page


@RegressionTest @ChangeRegistration
Scenario: 979-Error messages are displayed if First and Last name are not present or greater than 100 characters
And I search for my registration
Then I should see results in the page
When I click the Change link next to Name
Then I am shown the Change Details Name page defaulted with the name registered to the ULN 
When I clear the name fields and press Change
Then I am shown an error for null name fields stating "Enter first name" and "Enter last name"
When I enter only the first name and press Change
Then I am shown an error for missing last name stating "Enter last name"
When I enter only the last name and press Change
Then I am shown an error formissing first name stating "Enter first name"
When I enter a last name and first name greater than 100 characters and press Change
Then I am shown an error stating "First name must be 100 characters or fewer" and "Last name must be 100 characters or fewer"
And I cleared the data in DB

##Test covers all error messages and page title which includes "error"


@RegressionTest @ChangeRegistration
Scenario: 979-Accessing the Registration Change Name page through bookmarks for inactive ULN will direct to an error page
And I search for my registration
Then I should see results in the page
When I click the Change link next to Name
Then I am shown the Change Details Name page defaulted with the name registered to the ULN 
When I capture the Change Name URL
And I cancel the registration after navigating to the registration details from the Change Name page  
And I attempt to access the Change Name page using the captured URL
Then I am shown the Page Not Found page
And I cleared the data in DB


@RegressionTest @ChangeRegistration
Scenario: 985-Registration Change Name Page - successfully changing the name will display the confirmation page
And I search for my registration
Then I should see results in the page
When I click the Change link next to Name
Then I am shown the Change Details Name page defaulted with the name registered to the ULN 
When I change the first and last name to <FirstName> <LastName> and press Change
Then I am shown the Registration Change Success Page
When I click the Back to Registration button
Then I can see the amended name <FirstName> <LastName> on the Registration Details page 
And I cleared the data in DB

Examples: 
| FirstName        | LastName       |
| TestChange1      | TestChange2    |



