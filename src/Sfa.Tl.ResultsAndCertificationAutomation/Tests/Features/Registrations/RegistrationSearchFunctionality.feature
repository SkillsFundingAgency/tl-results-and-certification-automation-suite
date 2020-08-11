﻿Feature: Registration Search Functionality (Story 772)
As a Registrations Editor
I need to be able to search for registered students
So that I can soo which students have already been registered

Background:
Given I have logged in as a "RegistrationEditor" user

@ignore @RegressionTest @RegistrationSearch 
Scenario: Search for a valid ULN which is registered
When I click on Add a new registration link
And I enter <Uln> and click Continue button
And I enter <First Name> <Last Name> in learners page and click Contiune
And I enter <Day> <Month> <Year> in DOB page and click Continue
And I select Provider from the list and click Continue
And I select Core from the list and click Continue
And I select No from has decided specialism and click Continue
And I click Continue in Academic Year page
And I click Submit button
Then I should see ULN Added successfully message
When I click on BackToRegistration button
And I click Search For A registration link
Then the Search for a registration page is displayed
And I enter <ULN> into the ULN field and press Submit
Then the Registration Details page is displayed
Examples: 
| ULN        | First Name | Last Name  | Day | Month | Year |
| 9900000051 | FirstName1 | LastName10 | 01  | 01    | 2010 |


@ignore @RegressionTest @RegistrationSearch 
Scenario: Search for a valid ULN which is not registered
When I click on Search For A registration link
Then the Search for a registration page is displayed
And I enter <ULN> as a valid ULN which is not registered and press enter
Then I am shown the ULN cannot be found page
And when I click the back link
Then the Registration Search page is displayed with the ULN field still populated with <ULN>
Examples: 
| ULN        | First Name | Last Name  | Day | Month | Year |
| 9900000052 | FirstName1 | LastName10 | 01  | 01    | 2010 |

@ignore @RegressionTest @RegistrationSearch 
Scenario: Verify Search Page Invalid ULN error
When I click on Search For A registration link
Then the Search for a registration page is displayed
And I enter <ULN> as an invalid ULN which is not registered and press enter
Then I will be presented with an error stating ULN is invalid
Examples: 
| ULN        |
| 990000     | 
| ABCDEFGHIJ | 


@ignore @RegressionTest @ManaulRegistration
Scenario: Verify Search Page Blank ULN error
When I click on Search For A registration link
Then the Search for a registration page is displayed
And I press enter on Search for a registration page
Then I will be presented with an error stating Enter a ULN


@RegressionTest @RegistrationSearch 
Scenario: Click Registrations link in breadcrumbs on the Search Registration page
When I click on Search For A registration link
When I click the Registrations link in the breadcrumbs
Then I will be shown the Registrations dashboard page


@ignore @RegressionTest @RegistrationSearch 
Scenario: Click Home link in breadcrumbs on the Search Registration page
When I click on Search For A registration link
When I click the Home link in the breadcrumbs
Then I will be shown the Tlevel dashboard page