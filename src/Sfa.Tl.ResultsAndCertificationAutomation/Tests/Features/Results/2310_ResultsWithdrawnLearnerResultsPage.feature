Feature: 2310 Create Learner's Results page (withdrawn learner)
As a Results Editor
I need to be able to understand that I cannot see results for a withdrawn learner
So that I can search for a different ULN if I need to


Background: 
Given I have logged in as a "SiteAdmin" user
And I click on Add a new registration link
And I create a manual registration

@RegressionTest @Results
Scenario: 2310-Searching for a withdrawn ULN displays Learners Results Page (Withdrawn)
When I withdraw my application and navigate to the Results Search for a Learner Page
And I search for the <ULN> which is withdrawn
Then the Learners Results for Withdrawn Learner page will be displayed for the <ULN>

Examples: 
| ULN         |
| 9900000001  |


@RegressionTest @Results
Scenario: 2310_Clicking Search again on the Learners Results Page (Withdrawn) displays the Results ULN Search page
When I withdraw my application and navigate to the Results Search for a Learner Page
And I search for the <ULN> which is withdrawn
Then the Learners Results for Withdrawn Learner page will be displayed for the <ULN>
When I click the Search again link on the Learners Results page
Then I will be navigated to the Results Search for a Learner page
And the ULN Search field will be empty

Examples: 
| ULN         |
| 9900000001  |



@RegressionTest @Results
Scenario: 2310_Verify breadcrumbs on the Learners Results Page (Withdrawn) page
When I withdraw my application and navigate to the Results Search for a Learner Page
And I search for the <ULN> which is withdrawn
Then the Learners Results for Withdrawn Learner page will be displayed for the <ULN>
When I click the Search for a learner breadcrumb link
Then I will be navigated to the Results Search for a Learner page
When I navigate back to the Learners Results Page (Withdrawn) page using <ULN> from the Results Search for a Learner page
And I press the Results breadcrumb link
Then I should be navigated to Results dashboard page
When I navigate back to the Learners Results Page (Withdrawn) page for <ULN> from the Results dashboard page
And I click the Home breadcrumb link
Then I am taken to the home page


Examples: 
| ULN         |
| 9900000001  |