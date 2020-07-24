Feature: Registration Manual Upload
	As a Registrations Editor
	I need to be able to add single registration data for a student
	So that I can have the option to upload in bulk or not

Background:
Given I have logged in as a "RegistrationEditor" user

@RegressionTest @ManaulRegistration
Scenario: Add Registration Manual With Specialism
When I click on Add a new registration link
And I enter <Uln> and click Continue button
And I enter <First Name> <Last Name> in learners page and click Contiune
And I enter <Day> <Month> <Year> in DOB page and click Continue
And I select Provider from the list and click Continue
And I select Core from the list and click Continue
And I select Yes from has decided specialism and click Continue
And I select Specialism and click Continue
And I click Continue in Academic Year page
And I click Submit button
Then I should see ULN Added successfully message
Examples: 
| Uln        | First Name | Last Name | Day | Month | Year |
| 9900000050 | FirstName1 | LastName1 | 01  | 01    | 2010 |

@RegressionTest @ManaulRegistration
Scenario: Add Registration Manual Without Specialism
When I click on Add a new registration link
And I enter <Uln> and click Continue button
And I enter <First Name> <Last Name> in learners page and click Contiune
And I enter <Day> <Month> <Year> in DOB page and click Continue
And I select Provider from the list and click Continue
And I select Core from the list and click Continue
And I select No from has decided specialism and click Continue
And I click Continue in Academic Year page
And I click Submit button
Then I should see ULN Added successfully message
Examples: 
| Uln        | First Name | Last Name  | Day | Month | Year |
| 9900000051 | FirstName1 | LaastName1 | 01  | 01    | 2010 |