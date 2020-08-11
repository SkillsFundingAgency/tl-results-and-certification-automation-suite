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

@RegressionTest @RegistrationSearch
Scenario: Cancel Registration
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
And I enter <Uln> and click on Search
And I click on Cancel Register button
Then I should see cancel registration success page
Examples: 
| Uln        | FirstName | LastName  | Day | Month | Year | Provider                    | Core                                     |
| 9900000055 | FirstName1 | LaastName1 | 01  | 01    | 2010 | Automation Test2 (99999902) | Legal, Finance and Accounting (55555555) |

@RegressionTest @RegistrationSearch
Scenario: Search Cancelled Registration
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
And I enter <Uln> and click on Search
And I click on Cancel Register button
And I click on Search another registration button
And I enter <Uln> and click on Search
Then I should see <Uln> can not be found page
Examples: 
| Uln        | FirstName | LastName  | Day | Month | Year | Provider                    | Core                                     |
| 9900000055 | FirstName1 | LaastName1 | 01  | 01    | 2010 | Automation Test2 (99999902) | Legal, Finance and Accounting (55555555) |

@RegressionTest @RegistrationSearch
Scenario: Search Registration from Bulk upload
And I click on Back link
And I click on Upload registration file link
And I select registration file and click submit
And I click on back to registration link
And I click on Search for registrations link
And I entered the <Uln> and click on Search
Then I should see Registartion data matched with uploaded data
Examples: 
| Uln        |
| 9900000001 |