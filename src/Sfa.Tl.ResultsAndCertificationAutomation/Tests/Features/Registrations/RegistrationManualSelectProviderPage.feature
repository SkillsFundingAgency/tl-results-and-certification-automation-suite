Feature: RegistrationManualSelectProviderPage
	As a Registrations Editor
	I need to be able to add single registration data for a student
	So that I can have the option to upload in bulk or not

Background:
Given I have logged in as a "RegistrationEditor" user

@RegressionTest @ManaulRegistration
Scenario: Verify Registration Select Provider Page
When I click on Add a new registration link
And I enter <Uln> and click Continue button
And I enter <First Name> <Last Name> in learners page and click Contiune
And I enter Date of Birth in DOB page and click continue
Then I should see select Provider page
Examples: 
| Uln        | First Name | Last Name |
| 9700000001 | FirstName1 | LastName1 |

@RegressionTest @ManaulRegistration
Scenario: Verify Registration Select Provider Error Page
When I click on Add a new registration link
And I enter <Uln> and click Continue button
And I enter <First Name> <Last Name> in learners page and click Contiune
And I enter Date of Birth in DOB page and click continue
And I click Continue 
Then I should see errors in Select Provider page
Examples: 
| Uln        | First Name | Last Name |
| 9700000001 | FirstName1 | LastName1 |