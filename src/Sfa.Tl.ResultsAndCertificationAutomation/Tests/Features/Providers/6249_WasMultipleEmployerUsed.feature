Feature: 6249_WasMultipleEmployerUsed

As a provider, I need to provide details whether multiple employer model was used for the learner, so that I can update ESFA with the relevant details.

Background: 
Given I have logged in as a "ProviderBarnsleyPA" user
And I have registration without maths English and Ip
And I am on learner details page
And I click 'Add Ip' link on learner details page
And I select 'Yes, Completed' radio in has learner completed Ip page


@RegressionTest @Provider
Scenario: 6249_Verify was multiple employer used page
When I select 'Yes, Ip model used' radio in was Ip model used page
Then Multiple employer model used page is shown
And Back link takes me back to was Ip model used page

@RegressionTest @Provider
Scenario: 6249_Validate was multiple employer used page
When I select 'Yes, Ip model used' radio in was Ip model used page
And I click continue without selecting multiple employer option
Then the following error message shown on was multiple employer used page
| Error message                                          |
| Select yes if learner used the multiple employer model |
And the follwing error summary shown on was multiple employer used page
| Error summary                                          |
| Select yes if learner used the multiple employer model |