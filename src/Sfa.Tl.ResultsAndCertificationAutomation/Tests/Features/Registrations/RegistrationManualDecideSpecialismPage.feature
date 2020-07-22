Feature: RegistrationManualDecideSpecialismPage
	InAs a Registrations Editor
	I need to be able to add single registration data for a student
	So that I can have the option to upload in bulk or not

Background:
Given I have logged in as a "RegistrationEditor" user

@RegressionTest @ManaulRegistration
Scenario: Verify Registration Decide Specialism Page
When I click on Add a new registration link
And I enter <Uln> and click Continue button
And I enter <First Name> <Last Name> in learners page and click Contiune
And I enter Date of Birth in DOB page and click continue
And I select Provider and click Contiune button
And I select Core and click Continue button
Then I should see Devide Specialism Page
Examples: 
| Uln        | First Name | Last Name |
| 9700000001 | FirstName1 | LastName1 |

@RegressionTest @ManaulRegistration
Scenario: Verify Registration Decide Specialism Error Page
When I click on Add a new registration link
And I enter <Uln> and click Continue button
And I enter <First Name> <Last Name> in learners page and click Contiune
And I enter Date of Birth in DOB page and click continue
And I select Provider and click Contiune button
And I select Core and click Continue button
And click Continue without selecting any option
Then I should see error in the Decide Specialism page
Examples: 
| Uln        | First Name | Last Name |
| 9700000001 | FirstName1 | LastName1 |