Feature: Create Change Registration - DOB Page - Story 980
	As a Registrations Editor
    I need to be able to change the dob of a learner after having searched for them
    So that it can be kept up to date
    
Background: 
Given I have logged in as a "RegistrationEditor" user
And I click on Add a new registration link
And I create a manual registration


@RegressionTest @RegistrationSearch
Scenario: 980-Pressing the Change link next to DOB on the Registration Details page takes the user to the Change Registration DOB page
And I search for my registration
Then I should see results in the page
When I click the Change link next to DOB
Then I am shown the Change Details DOB page
When I click the Back link on the Change Details DOB page
Then I will be directed to the Registration Details page
When I click the Change link next to DOB
And then press Change after making no amendments to the DOB
Then I will be directed to the Registration Details page
##Checks back link, No changes made to DOB directs to reg details page, Change DOB page validation (heading, URL and page title)


@RegressionTest @RegistrationSearch
Scenario: 980-Error messages are displayed if DOB fields are NULL or invalid
And I search for my registration
Then I should see results in the page
When I click the Change link next to DOB
Then I am shown the Change Details DOB page
When I clear the DOB fields and press Change
Then I am shown an error message stating "Enter your date of birth"
When I enter the day only and press Change
Then I am shown an error message stating "Date of birth must include a month and year"
When I enter the Month only and press Change
Then I am shown an error message stating "Date of birth must include a day and year"
When I enter the Year only and press Change
Then I am shown an error message stating "Date of birth must include a day and month"
When I enter the day and month only and press Change
Then I am shown an error message stating "Date of birth must include a year"
When I enter the day and year only and press Change
Then I am shown an error message stating "Date of birth must include a month"
When I enter the month and year only and press Change
Then I am shown an error message stating "Date of birth must include a day"
When I enter an invalid date and press Change
Then I am shown an error message stating "Date of birth must be a real date"
When I enter a DOB in the future and press Change
Then I am shown an error message stating "Date of birth must be in the past"
##checks all error messages on the page and checks page title includes "Error"

@RegressionTest @RegistrationSearch
Scenario: 980-Accessing the Registration Change DOB page through bookmarks for inactive ULN will direct to an error page
And I search for my registration
Then I should see results in the page
When I click the Change link next to DOB
Then I am shown the Change Details DOB page
When I capture the Change DOB URL
And I cancel the registration
And I attempt to access the Change DOB page using the captured URL
Then I am shown the Page Not Found page
##checks the Page Not Found page is displayed if accessing this page when the ULN is withdrawn

@RegressionTest @RegistrationSearch
Scenario: 985-Registration Change DOB Page - successfully changing the DOB will display the confirmation page
And I search for my registration
Then I should see results in the page
When I click the Change link next to DOB
Then I am shown the Change Details DOB page prepopulated with the DOB registered to the ULN 
When I change the date of birth to <Day> <Month> <Year> and press Change
Then I am shown the Registration Change Success Page
When I click the Back to Registration button
Then I can see the amended date of birth <Day> <Month> <Year> on the Registration Details page 

Examples: 
| Day  | Month | Year |
| 02   | 12    | 2000 |

##Verifies the Registration Details page is displayed if Change is pressed on Change DOB without making any amendments