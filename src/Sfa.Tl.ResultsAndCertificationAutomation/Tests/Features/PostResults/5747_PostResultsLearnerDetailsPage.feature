Feature: 5747_PostResultsLearnerDetailsPage

As an AO, I need the ability to Add ROMM (core) post results actions, so that I am able to update the learner record that a ROMM has been requested

Background: 
Given I have logged in as a "CityAndGuildsAdmin" user
And I have a registration with core and specialism assessments results
And I am on post results search learner page

@RegressionTest @PostResults
Scenario: 5747 Verify learner details page
When I enter uln and click search
Then learner details page is shown
And add ROMM button is enabled for current assessment series	

@RegressionTest @PostResults
Scenario: 5747 Verify search again button
When I enter uln and click search
Then learner details page is shown
And clicking on search again button takes me to Search post result learner page