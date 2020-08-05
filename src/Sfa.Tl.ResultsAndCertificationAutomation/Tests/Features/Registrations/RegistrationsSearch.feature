Feature: RegistrationsSearch
As a Registrations Editor
I need to be able to search for registered students
So that I can soo which students have already been registered

Background: 
Given I have logged in as a "RegistrationEditor" user
And I click on Add a new registration link

@RegressionTest @RegistrationSearch
Scenario: Search Registrations With Valid Uln
And I enter <Uln> and click Continue button
And I enter <FirstName> <LastName> in learners page and click Contiune
And I enter <Day> <Month> <Year> in DOB page and click Continue
And I select <Provider> from the Provider list and click Continue
And I select <Core> from the Core list and click Continue
And I select No from has decided specialism and click Continue
And I click Continue in Academic Year page
And I click Submit button
And I click on back to registration link
And I click on Search for registrations link
When I enter <Uln> and click on Search
Then I should see results in the page
Examples: 
| Uln        | FirstName | LastName  | Day | Month | Year | Provider                    | Core                                     |
| 9900000055 | FirstName1 | LaastName1 | 01  | 01    | 2010 | Automation Test2 (99999902) | Legal, Finance and Accounting (55555555) |
