Feature: 5861_AddRommOS

As an AO, I need the ability to inform ESFA that the learner has requested a ROMM of a grade, so that overall grade is not calculated until result has been through a ROMM.

Background: 
Given I have logged in as a "CityAndGuildsAdmin" user
And I have a registration with core and specialism assessments results
And I am on post results learner details page

@RegressionTest @PostResults
Scenario: 5861 Verify add ROMM page for specialism
	When I click "Add specialism1 ROMM" button in post result learner details page
	Then Add a ROMM page is shown
	And specialism1 details shown in the summary
	And back link takes me to post result learner details page

@RegressionTest @PostResults
Scenario: 5861 Verify add ROMM page for second specialism
	When I click "Add specialism2 ROMM" button in post result learner details page
	Then Add a ROMM page is shown
	And specialism2 details are shown in the summary
	And back link takes me to post result learner details page

