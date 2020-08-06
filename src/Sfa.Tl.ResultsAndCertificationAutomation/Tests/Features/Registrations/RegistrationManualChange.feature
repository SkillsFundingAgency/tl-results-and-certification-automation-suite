Feature: RegistrationManualChange
	As a Registrations Editor
	I need to be able to change details on a single upload
	So that I can ensure the accurate data has been uploaded

Background:
Given I have logged in as a "RegistrationEditor" user
And I click on Add a new registration link

@RegressionTest @ManaulRegistration
Scenario: Change ULN
And I enter <Uln> and click Continue button
And I enter <FirstName> <LastName> in learners page and click Contiune
And I enter <Day> <Month> <Year> in DOB page and click Continue
And I select <Provider> from the Provider list and click Continue
And I select <Core> from the Core list and click Continue
And I select No from has decided specialism and click Continue
And I click Continue in Academic Year page
When I click on Uln change link
And I changed the uln number and click on change button
Then I should see changed uln in confirm and submit page
Examples: 
| Uln        | FirstName | LastName  | Day | Month | Year | Provider                    | Core                                     |
| 9900000060 | FirstName1 | LastName1 | 01  | 01    | 2010 | Automation Test2 (99999902) | Legal, Finance and Accounting (55555555) |

@RegressionTest @ManaulRegistration
Scenario: Change Learner
And I enter <Uln> and click Continue button
And I enter <FirstName> <LastName> in learners page and click Contiune
And I enter <Day> <Month> <Year> in DOB page and click Continue
And I select <Provider> from the Provider list and click Continue
And I select <Core> from the Core list and click Continue
And I select No from has decided specialism and click Continue
And I click Continue in Academic Year page
When I click on Learner change link
And I changed lerner fisrt and last nanme and click change button
Then i shoud see change lerner names in confirm and submit page
Examples: 
| Uln        | FirstName | LastName  | Day | Month | Year | Provider                    | Core                                     |
| 9900000060 | FirstName1 | LastName1 | 01  | 01    | 2010 | Automation Test2 (99999902) | Legal, Finance and Accounting (55555555) |

@RegressionTest @ManaulRegistration
Scenario: Change Date Of Birth
And I enter <Uln> and click Continue button
And I enter <FirstName> <LastName> in learners page and click Contiune
And I enter <Day> <Month> <Year> in DOB page and click Continue
And I select <Provider> from the Provider list and click Continue
And I select <Core> from the Core list and click Continue
And I select No from has decided specialism and click Continue
And I click Continue in Academic Year page
When I click on DateOfBirth change link
And I changed  Date of Birth and click on Change button
Then I should see changed Date of Birth in Check and Submit page
Examples: 
| Uln        | FirstName | LastName  | Day | Month | Year | Provider                    | Core                                     |
| 9900000060 | FirstName1 | LastName1 | 01  | 01    | 2010 | Automation Test2 (99999902) | Legal, Finance and Accounting (55555555) |

@RegressionTest @ManaulRegistration
Scenario: Change Provider
And I enter <Uln> and click Continue button
And I enter <FirstName> <LastName> in learners page and click Contiune
And I enter <Day> <Month> <Year> in DOB page and click Continue
And I select <Provider> from the Provider list and click Continue
And I select <Core> from the Core list and click Continue
And I select No from has decided specialism and click Continue
And I click Continue in Academic Year page
When I click on Provider change link
And I changed the Provider and click continue
And I change Core and Specialisms and click continue
Then I should changed Provider details in Check and Submit page
Examples: 
| Uln        | FirstName | LastName  | Day | Month | Year | Provider                    | Core                                     |
| 9900000060 | FirstName1 | LastName1 | 01  | 01    | 2010 | Automation Test2 (99999902) | Legal, Finance and Accounting (55555555) |
