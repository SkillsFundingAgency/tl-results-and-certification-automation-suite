Feature: 2535_EnterUlnPageValidations
	As a Provider
	I need to be able to add English/Maths and Industry Placement data for learners
	So that learner details can be kept up to date

Background: 
Given I have logged in as a "SiteAdmin" user
And I click on "Manage learner records" link
And I click on "Add a new learner record" link

@RegressionTest @Provider
Scenario: 2535 Verify mandatory field validation
When I click on "Continue" button
Then I should see the following error message for the Uln
| Error Messages |
| Enter a ULN    |
And I should see the following error summary messages
| Error Messages |
| Enter a ULN    |

@RegressionTest @Provider
Scenario: 2535 Verify Uln field validation
When I enter following data
| Field name | Value   |
| EnterUln   | Abc123! |
And I click on "Continue" button
Then I should see the following error message for the Uln
| Error Message     |
| Enter a valid ULN |
And I should see the following error summary messages
| Error Messages    |
| Enter a valid ULN |