Feature: RegistrationManualDOBPage
	As a Registrations Editor
	I need to be able to add single registration data for a student
	So that I can have the option to upload in bulk or not

Background:
Given I have logged in as a "RegistrationEditor" user

@RegressionTest @ManaulRegistration
Scenario: Verify Registration DOB Page
When I click on Add a new registration link
And I enter <Uln> and click Continue button
And I enter <First Name> <Last Name> in learners page and click Contiune
Then I should see Date of Birth Page
Examples: 
| Uln        | First Name  | Last Name  |
| 9700000001 | FirstName1 | LastName1 |

@RegressionTest @ManaulRegistration
Scenario: Verify Registration DOB Error Page
When I click on Add a new registration link
And I enter <Uln> and click Continue button
And I enter <First Name> <Last Name> in learners page and click Contiune
And I click continue without entering data
Then I should see error in the page
Examples: 
| Uln        | First Name  | Last Name  |
| 9700000001 | FirstName1 | LastName1 |