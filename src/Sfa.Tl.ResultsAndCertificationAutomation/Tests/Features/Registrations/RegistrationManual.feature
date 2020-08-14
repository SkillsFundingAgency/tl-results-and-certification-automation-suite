Feature: Registration Manual Upload
	As a Registrations Editor
	I need to be able to add single registration data for a student
	So that I can have the option to upload in bulk or not

@RegressionTest @ManaulRegistration
Scenario: Add Registration Manual With Specialism
Given I have logged in as a "RegistrationEditor" user
When I click on Add a new registration link
And I enter <Uln> and click Continue button
And I enter <First Name> <Last Name> in learners page and click Contiune
And I enter <Day> <Month> <Year> in DOB page and click Continue
And I select Provider from the list and click Continue
And I select Core from the list and click Continue
And I select Yes from has decided specialism and click Continue
And I select Specialism and click Continue
And I click Continue in Academic Year page
And I click Submit button
Then I should see ULN Added successfully message
Examples: 
| Uln        | First Name | Last Name | Day | Month | Year |
| 9900000050 | FirstName1 | LastName1 | 01  | 01    | 2010 |

@RegressionTest @ManaulRegistration
Scenario: Add Registration Manual Without Specialism
Given I have logged in as a "RegistrationEditor" user
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
Examples: 
| Uln        | First Name | Last Name  | Day | Month | Year |
| 9900000051 | FirstName1 | LaastName1 | 01  | 01    | 2010 |

@RegressionTest @ManaulRegistration
Scenario: ULN already registered with AO
Given I have logged in as a "RegistrationEditor" user
When I click on Add a new registration link
And I enter <Uln> and click Continue button
And I enter <First Name> <Last Name> in learners page and click Contiune
And I enter <Day> <Month> <Year> in DOB page and click Continue
And I select Provider from the list and click Continue
And I select Core from the list and click Continue
And I select No from has decided specialism and click Continue
And I click Continue in Academic Year page
And I click Submit button
And I click on back to registration link
And I enter <Uln> and click Continue button
Then I should see ULN already registered page
Examples:
| Uln        | First Name | Last Name  | Day | Month | Year |
| 9900000052 | FirstName1 | LaastName1 | 01  | 01    | 2010 |

@RegressionTest @ManaulRegistration
Scenario: ULN already registered with another AO
Given I have logged in as a "PearsonSiteAdmin" user
When I click on Add a new registration link
And I enter <Uln> and click Continue button
And I enter <First Name> <Last Name> in learners page and click Contiune
And I enter <Day> <Month> <Year> in DOB page and click Continue
And I select Provider and Core and click continue
And I select No from has decided specialism and click Continue
And I click Continue in Academic Year page
And I click Submit button
And I click on Sign Out link
And I logged in with RegistrationEditor user
And I enter <Uln> and click Continue button
Then I should see ULN already registered with another AO error
Examples:
| Uln        | First Name | Last Name  | Day | Month | Year |
| 9900000053 | FirstName1 | LaastName1 | 01  | 01    | 2010 |

@RegressionTest @RegistrationSearch
Scenario: Search another AO registration
Given I have logged in as a "PearsonSiteAdmin" user
And I click on Add a new registration link
And I created registration for the AO
And I click submit the registration
And I click Sigh Out link
And I have logged in as a "RegistrationEditor" user
And I navigated to serach registration page
And I entered the <Uln> and click serach
Then I should see an error with <Uln>
Examples: 
| Uln        |
| 9900000054 |

