Feature: RegistrationManualSelectSpecialismPage
	As a Registrations Editor
	I need to be able to add single registration data for a student
	So that I can have the option to upload in bulk or not

Background:
Given I have logged in as a "RegistrationEditor" user

@RegressionTest @ManaulRegistration
Scenario: Verify Registration Select Specialism Page
When I click on Add a new registration link
And I enter <Uln> and click Continue button
And I enter <First Name> <Last Name> in learners page and click Contiune
And I enter Date of Birth in DOB page and click continue
And I select Provider and click Contiune button
And I select Core and click Continue button
And I select Decided Yes option and click Continue button
Then I should see Select Specialism Page
Examples: 
| Uln        | First Name | Last Name |
| 9900000001 | FirstName1 | LastName1 |

@RegressionTest @ManaulRegistration
Scenario: Verify Registration Select Specialism Error Page
When I click on Add a new registration link
And I enter <Uln> and click Continue button
And I enter <First Name> <Last Name> in learners page and click Contiune
And I enter Date of Birth in DOB page and click continue
And I select Provider and click Contiune button
And I select Core and click Continue button
And I select Decided Yes option and click Continue button
And I click Continue without selecting Specialism
Then I should see Error in the page
Examples: 
| Uln        | First Name | Last Name |
| 9900000001 | FirstName1 | LastName1 |