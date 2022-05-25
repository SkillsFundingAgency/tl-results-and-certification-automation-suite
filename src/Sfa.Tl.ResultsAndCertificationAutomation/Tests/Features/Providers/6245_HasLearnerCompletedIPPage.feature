Feature: 6245_HasLearnerCompletedIPPage

As a Provider, I need the ability to update the service with the learners industry placement details, so that I can continue to provide further details.

Background: 
Given I have logged in as a "ProviderBarnsleyPA" user
And I have registration without maths English and Ip
And I am on learner details page

@RegressionTest @Provider
Scenario: 6245_Verify has learner completed Ip page
When I click 'Add Ip' link on learner details page
Then Has learner completed Ip page is shown
And Bank link takes me back to learner details page
And click on 'Add Ip link' takes me to Has learner completed Ip page

@RegressionTest @Provider
Scenario: 6245_Validate errors on has learner completed Ip page
When I click 'Add Ip' link on learner details page
And I click continue without selecting completed Ip option
Then the following error message shown on has learner completed Ip page
| Error message                                                       |
| Tell us whether this learner has completed their industry placement |
And the flowwing error summary shown on has learner completed Ip page
| Error summary                                                       |
| Tell us whether this learner has completed their industry placement |
