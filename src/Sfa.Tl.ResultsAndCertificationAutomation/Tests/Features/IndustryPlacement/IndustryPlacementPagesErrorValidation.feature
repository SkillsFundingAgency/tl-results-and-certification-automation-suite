Feature: IndustryPlacementPagesErrorValidation
	End to end journeys - Page error validation for each of the pages in the Industry Placement journey. 
	The three different tests cover the error validation in each of the pages in the IP journey 

Background: 
Given I have logged in as a "ProviderBarnsleyPA" user

@RegressionTest @IndustryPlacement
Scenario: 1-IP Error Validation - 2021 Education and Childcare T Level
Given I have an active registration with an Education and Childcare T Level
And I update the registration to be 2021
And I click on "Manage learner records" link
When I enter the ULN on the search page
And I click the following link "Add Ip"
And I click Continue on the Has learner completed their industry placement? page
Then the user is shown an error message which says Tell us whether this learner has completed their industry placement
When I click Continue on the How many industry placement hours did learner complete? page
Then the user is shown an error message which says Enter number of hours the learner spent on placement
When I enter invalid value of "30A" hours on the How many industry placement hours did learner complete?
Then the user is shown an error message which says The placement duration must be a whole number between 1 and 999 hours
When I click Continue on the Why was learner granted special consideration for their industry placement? page 
Then the user is shown an error message which says Select one or more reasons for granting special consideration
When I click Continue on the Was an industry placement model used for learner? page
Then the user is shown an error message which says Select yes if learner used an industry placement model
When I click Continue on the Was a multiple employer model used for learner page
Then the user is shown an error message which says Select yes if learner used the multiple employer model
When I click "Relevant part-time work" on the Did learner use any other industry placement models? page
And I click Continue on the Was learner granted a temporary flexibility? page
Then the user is shown an error message which says Select whether the learner was granted a temporary flexibility
When I click Continue on the Which temporary flexibilities were granted to learner page
Then the user is shown an error message which says Select one or more temporary flexibilities
Then I am shown the IP Check your answer page
And I click Submit on the Check your answers page
Then the learner details page is displayed with a success banner
And I cleared the data in DB


@RegressionTest @IndustryPlacement 
Scenario: 2-IP Error Validation - 2021 Digital Business Services T Level
Given I have an active registration with a Digital Business Services T Level
And I update the registration to be 2021
And I click on "Manage learner records" link
When I enter the ULN on the search page
And I click the following link "Add Ip"
And I click 'Yes, completed with special consideration' on the Has learner completed their industry placement? page
And I click "300" hours on the How many industry placement hours did learner complete?
And I click "Placement withdrawn" on Why was learner granted special consideration for their industry placement? page
And I click "Yes" on the Was an industry placement model used for learner? page
And I click "No" on the Was a multiple employer model used for learner page
And I click Continue on the Which industry placement models were used by learner? page
Then the user is shown an error message which says Select one or more industry placement models
When I click Continue on the blended placement temporary flexibility? page
Then the user is shown an error message which says Select whether the learner has used the blended placement temporary flexibility
And I am shown the IP Check your answer page
And I click Submit on the Check your answers page
Then the learner details page is displayed with a success banner
And I cleared the data in DB

@RegressionTest @IndustryPlacement
Scenario: 3-IP Error Validation - 2020 Digital production, design and development 
Given I have an active registration with Digital production, design and development T Level
And I click on "Manage learner records" link
When I enter the ULN on the search page
And I click the following link "Add Ip"
And I click 'Yes, completed' on the Has learner completed their industry placement? page
And I click "Yes" on the Was an industry placement model used for learner? page
And I click "No" on the Was a multiple employer model used for learner page
And I click "Relevant part-time work" on the Which industry placement models were used by learner? page
And I click "Yes" on the Was learner granted a temporary flexibility? page
And I click "Yes" on the Did learner use the blended placement temporary flexibility? page
When I click Continue on the employer-led activities/projects temporary flexibility? page
Then the user is shown an error message which says Select whether the learner used the employer-led activities/projects temporary flexibility
And I am shown the IP Check your answer page
And I click Submit on the Check your answers page
Then the learner details page is displayed with a success banner
And I cleared the data in DB

