Feature: 6545_WhichIpModelsWereUsed

As a provider, I need to provide details whether learner used any other industry placement models, so that I can update ESFA with the relevant details.

Background: 
Given I have logged in as a "ProviderBarnsleyPA" user

@Ignore @RegressionTest @Provider
Scenario: 6545_Which Ip models used by page_EducationAndChildCare
And I have registration for Education and Childcare without maths English and Ip
And I am on learner details page
And I click 'Add Ip' link on learner details page
And I select 'Yes, Completed' radio in has learner completed Ip page
And I select 'Yes, Ip model used' radio in was Ip model used page
When I select 'No, Multiple employer used' in multiple employer model page
Then the following radio options seen on which Ip models used by page
| Options                                                            |
| Relevant part-time work                                            |
| On-site facilities for SEND students                               |
| On-site facilities for young people in young offender institutions |