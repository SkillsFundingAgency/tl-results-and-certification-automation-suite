Feature: RegistrationManualSelectCorePage
	As a Registrations Editor
	I need to be able to add single registration data for a student
	So that I can have the option to upload in bulk or not

Background:
Given I have logged in as a "RegistrationEditor" user

@RegressionTest @ManaulRegistration
Scenario: Verify Registration Select Core Page
When I click on Add a new registration link
And I enter <Uln> and click Continue button
And I enter <First Name> <Last Name> in learners page and click Contiune
And I enter Date of Birth in DOB page and click continue
And I select Provider and click Contiune button
Then I should see Select Core Page
Examples: 
| Uln        | First Name | Last Name |
| 9700000001 | FirstName1 | LastName1 |

@RegressionTest @ManaulRegistration
Scenario: Verify Registration Select Core Error Page
When I click on Add a new registration link
And I enter <Uln> and click Continue button
And I enter <First Name> <Last Name> in learners page and click Contiune
And I enter Date of Birth in DOB page and click continue
And I select Provider and click Contiune button
And I click on Continue witout selecting Core
Then I should see error in Select Core page
Examples: 
| Uln        | First Name | Last Name |
| 9700000001 | FirstName1 | LastName1 |