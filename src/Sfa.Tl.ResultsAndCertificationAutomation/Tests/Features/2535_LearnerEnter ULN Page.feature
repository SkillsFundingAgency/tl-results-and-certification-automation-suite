Feature: Enter ULN Page
As a Provider
I need to be able to add English/Maths and Industry Placement data for learners
So that learner details can be kept up to date


@RegressionTest @Learner
Scenario: 2535_search for an invalid ULN on the Search for a learner page
Given I have logged in as a "SiteAdmin" user
And I navigate to the Enter ULN page for Add a new learner
Then the page headings, page text URL and title will match the expected values
And I enter a ULN on the Enter ULN page of <ULN> 
Then I am shown an error message on the Enter ULN page stating "Enter a valid ULN"
Examples: 
| ULN        |
| 990000005  |
| 9900000ABC |


@RegressionTest @Learner
Scenario: 2535_Press Submit without entering a ULN on the Enter ULN page and test the back link
Given I have logged in as a "SiteAdmin" user
And I navigate to the Enter ULN page for Add a new learner
And I press Continue without entering a ULN
Then I am shown an error message on the Enter ULN page stating "Enter a ULN"
Given I click the back link on the Enter ULN page for Add a new learner
Then I am shown the Manage Learner Records page



