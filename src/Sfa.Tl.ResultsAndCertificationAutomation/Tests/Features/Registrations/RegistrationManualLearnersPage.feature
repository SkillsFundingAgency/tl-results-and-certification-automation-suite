Feature: RegistrationManualLearnersPage
	As a Registrations Editor
	I need to be able to add single registration data for a student
	So that I can have the option to upload in bulk or not

Background:
Given I have logged in as a "RegistrationEditor" user

@RegressionTest @ManaulRegistration
Scenario: Verify Registration Learners Page
When I click on Add a new registration link
And I enter <Uln> and click Continue button
Then I should see Learners Page
Examples: 
| Uln        |
| 9900000001 |

@RegressionTest @ManaulRegistration
Scenario: Verify Registration Learners Error Page
When I click on Add a new registration link
And I enter <Uln> and click Continue button
And I click on Coninue button in Learners Page
Then should see error in Learners page
Examples: 
| Uln        |
| 9900000001 |

@RegressionTest @ManaulRegistration
Scenario: Learner Data validations
When I click on Add a new registration link
And I enter <Uln> and click Continue button
And I enter invalid <FirstName> <LastName> for Learner
When I click on Coninue button in Learners Page
Then I should see errors
Examples: 
| Uln        | FirstName                                                                                             | LastName                                                                                              |
| 9900000001 | abcdfghijklmnopqrstuvwxyzabcdfghijklmnopqrstuvwxyzabcdfghijklmnopqrstuvwxyzabcdfghijklmnopqrstuvwxyza | abcdfghijklmnopqrstuvwxyzabcdfghijklmnopqrstuvwxyzabcdfghijklmnopqrstuvwxyzabcdfghijklmnopqrstuvwxyza |