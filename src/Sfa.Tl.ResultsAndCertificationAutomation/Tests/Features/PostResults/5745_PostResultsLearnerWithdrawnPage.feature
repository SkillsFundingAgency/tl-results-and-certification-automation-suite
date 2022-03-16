Feature: 5745_PostResultsLearnerWithdrawnPage

As an AO, I need to be informed when I enter a ULN and the learner has been withdrawn, so that I am prevented from doing any post result actions for this ULN.

Background: 
Given I have logged in as a "ResultsEditor" user
And I have a registration with result
And I have moved registration in to withdrawn state
And I am on post results search learner page

@RegressionTest @PostResults
Scenario: 5745 Verify post result learner withdrawn page
	When I enter uln and click search
	Then learner withdrawn page is shown
	And back link takes me to search learner page with uln populated
