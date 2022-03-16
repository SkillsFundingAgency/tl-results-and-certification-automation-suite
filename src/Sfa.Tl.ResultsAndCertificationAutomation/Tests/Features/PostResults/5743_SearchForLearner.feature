Feature: 5743_SearchForLearner

As an AO, I want to be able to search for a learner, so that I can perform any post-result actions

Background: 
Given I have logged in as a "CityAndGuildsAdmin" user
And I click on "Post-results" link

@RegressionTest @PostResults
Scenario: 5743 verify search learner page
When I click "Continue" button
Then Post result search for a learner page is shown
And clicking on Post-results breadcrumb takes to Post result home page
And clicking Home breadcrumb takes me to home page

@RegressionTest @PostResults
Scenario: 5743 verify mandatory field validation
When I click "Continue" button
And I click "Search" button on search learner page
Then I see following error message on search learner page
| Error message              |
| Enter a ULN with 10 digits |
And I see following error summary on search learner page
| Error summary              |
| Enter a ULN with 10 digits |

@RegressionTest @PostResults
Scenario: 5743 verify data validation
When I click "Continue" button
And I enter "ABC12345" and click search button
Then I see following error message on search learner page
| Error message              |
| Enter a valid 10-digit ULN |
And I see following error summary on search learner page
| Error summary              |
| Enter a valid 10-digit ULN |
