Feature: 5771_RequestChangeCancel

As an AO, I want the service to validate if I wish to cancel the change request, so that I do not accidentally cancel the request.

Background: 
Given I have logged in as a "CityAndGuildsAdmin" user
And I have registration with results in final state
And I am on post results learner details page

@RegressionTest @PostResults
Scenario: 5771 Verify change request cancel page
	When I click "Core request change" button in post result learner details page
	And I click on "Cancel" link
	Then request change cancel page shown
	And selecting no radio option takes me to request to change Final grade page

@RegressionTest @PostResults
Scenario: 5771 Error validation on change request cancel page
When I click "Core request change" button in post result learner details page
And I click on "Cancel" link
And click on continue button without selecting any options
Then error message shown on request change cancel page
| Error message                                                            |
| Please select whether you want to cancel the request to change the grade |
And error summary shown on request change cancel page
| Error summary                                                            |
| Please select whether you want to cancel the request to change the grade |