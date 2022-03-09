Feature: 5744_PostResultsUlnNotFound

As an AO, I need to be informed when I enter a ULN and the record cannot be found, so that I can check the entered ULN and make the required decision


Background: 
Given I have logged in as a "CityAndGuildsAdmin" user
And I am on post results search learner page

@RegressionTest @PostResults
Scenario: 5744 verify uln not found page
	When I enter the uln which is not existed and click search button
	Then post result Uln not found page is shown
	And click on back link takes to search uln page witn Uln populated
	And search again takes to search uln page with no uln populated

	@RegressionTest @PostResults
Scenario: 5744 Back to home navigation
When I enter the uln which is not existed and click search button
	Then post result Uln not found page is shown
