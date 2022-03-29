Feature: 6211_RequestChangeCancelOs

As an AO, I want the service to validate if I wish to cancel the change request, so that I do not accidentally cancel the request.

Background: 
Given I have logged in as a "CityAndGuildsAdmin" user
And I have registration with results in final state
And I am on post results learner details page

@RegressionTest @PostResults
Scenario: 6211 Verify specialism change request cancel page
	When I click "Specialism1 request change" button in post result learner details page
	And I click on "Cancel" link
	Then request change cancel page shown
	And selecting no radio option takes me to request to change Final grade page

@RegressionTest @PostResults
Scenario: 6211 Verify cancel specialism change request cancel option
	When I click "Specialism1 request change" button in post result learner details page
	And I click on "Cancel" link
	Then request change cancel page shown
	And selecting yes radio option takes me to request to learner details page