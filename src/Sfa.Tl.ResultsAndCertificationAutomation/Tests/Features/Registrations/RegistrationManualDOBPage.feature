Feature: RegistrationManualDOBPage
	As a Registrations Editor
	I need to be able to add single registration data for a student
	So that I can have the option to upload in bulk or not

Background:
Given I have logged in as a "RegistrationEditor" user

@RegressionTest @ManaulRegistration
Scenario: Verify Registration DOB Page
When I click on Add a new registration link
And I enter <Uln> and click Continue button
And I enter <First Name> <Last Name> in learners page and click Contiune
Then I should see Date of Birth Page
Examples: 
| Uln        | First Name  | Last Name  |
| 9900000001 | FirstName1 | LastName1 |

@RegressionTest @ManaulRegistration
Scenario: Verify Registration DOB Error Page
When I click on Add a new registration link
And I enter <Uln> and click Continue button
And I enter <First Name> <Last Name> in learners page and click Contiune
And I click continue without entering data
Then I should see error in the page
Examples: 
| Uln        | First Name  | Last Name  |
| 9900000001 | FirstName1 | LastName1 |

@RegressionTest @ManaulRegistration
Scenario: Verify DOB Validation Errors
And I click on Add a new registration link
And I enter <Uln> and click Continue button
And I enter <FirstName> <LastName> in learners page and click Contiune
And I enter invlid <Day> <Month> <Year> in DOB fields
When I click on Continue button in DOB page
Then I should see DOB validation <Errors>
Examples: 
| Uln        | FirstName  | LastName  | Day | Month | Year  | Errors                             |
| 9900000070 | FirstName1 | LastName1 | DD  | MM    | YYYY  | Date of birth must be a real date |
| 9900000070 | FirstName1 | LastName1 | 35  | 13    | 2010  | Date of birth must be a real date |
| 9900000070 | FirstName1 | LastName1 | 01  | 01    | 2030  | Date of birth must be in the past |
| 9900000070 | FirstName1 | LastName1 | 123 | 123   | 12345 | Date of birth must be a real date |


