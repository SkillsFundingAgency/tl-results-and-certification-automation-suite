Feature: 5746_LearnerDoesnotHaveResultsPage

As an AO, I need to be informed when I enter a ULN and the learner does not have a result entered, so that I am prevented from doing any post result actions for this ULN until a result has been entered.

Background: 
Given I have logged in as a "CityAndGuildsAdmin" user
And I have a registration with no Core and Specialism assessments
And I am on post results search learner page

@RegressionTest @PostResults
Scenario: 5746 Verify learner has no results page
	When I enter uln and click search
	Then learner has no results page is shown
	And back link takes me to search learner page with uln populated

@RegressionTest @PostResults
Scenario: 5746 Verify add result link
When I enter uln and click search
And I click on "add a result" link
Then learner result page is shown


