Feature: 2309 Create ULN cannot be found page (results)
As a Results Editor
I need to be able to understand why my search failed
So that I can rectify my search


@RegressionTest @Results
Scenario: 2309_Validate back link on the Results Search for a Learner page 
Given I have logged in as a "ResultsEditor" user
When I click on "Results" link
Then I should be navigated to Results dashboard page
When I click on "Search for a learner" link
Then I will be navigated to the Results Search for a Learner page
And I search for a <ULN> which is not registered
Then I will be navigated to the Results ULN Cannot be found page for <ULN>
When I click the Back link on the Results ULN cannot be found page
Then I will be navigated to the Results Search for a Learner page
And the search box will be populated with the <ULN> entered originally
Examples: 
| ULN         |
| 9900000040  |


@RegressionTest @Results
Scenario: 2309_validate Back to Search button on the Results Search for a Learner page 
Given I have logged in as a "ResultsEditor" user
When I click on "Results" link
Then I should be navigated to Results dashboard page
When I click on "Search for a learner" link
Then I will be navigated to the Results Search for a Learner page
And I search for a <ULN> which is not registered
Then I will be navigated to the Results ULN Cannot be found page for <ULN>
When I click the Back to Search button on the Results ULN cannot be found page
Then I will be navigated to the Results Search for a Learner page
And the search box will be populated with the <ULN> entered originally
Examples: 
| ULN         |
| 9900000040  |


@RegressionTest @Results
Scenario: 2309_Searching for a ULN registered to another AO will display the Results ULN Cannot be found page 
Given I have logged in as a "PearsonSiteAdmin" user
And I click on Add a new registration link
And I create a manual registration for Pearson
When I click on Signout from Menu
Then I should be redirectted to Tlevel Start page
Given I have logged in as a "ResultsEditor" user
When I click on "Results" link
Then I should be navigated to Results dashboard page
When I click on "Search for a learner" link
Then I will be navigated to the Results Search for a Learner page
And I enter the <ULN> which has been registered with another AO
Then I will be navigated to the Results ULN Cannot be found page for <ULN>
Examples: 
| ULN         |
| 9900000001  |