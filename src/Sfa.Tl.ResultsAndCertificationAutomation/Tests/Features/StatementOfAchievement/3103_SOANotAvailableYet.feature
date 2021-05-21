Feature: 3103_Statement of Achievement - 'Statements of achievement are not yet available'
	As a provider
	if I click on ‘Request a statement of achievement’ on my dashboard, 
	if the date is before 10 August 2021 then display the following page:
    'statements-of-achievement-not-available'
	 so that I know I have to come back and request this when the printing is available from 10 August 2021

Background: 
Given I have logged in as a "ProviderBarnsleyPA" user

@RegressionTest @SOA @Ignore
Scenario: 3103_Verify SOA not available yet page and Back link
And I click on "Request statement of achievement" link
Then I am navigated to the SOA not yet available page if the date is less than 10th August 2021
When I click the back link on the SOA not yet available page then I am taken back to the dashboard
Then I will be navigated to the T Levels Dashboard page

@RegressionTest @SOA @Ignore
Scenario: 3103_Verify Back to home button on SOA not yet available page
And I click on "Request statement of achievement" link
Then I am navigated to the SOA not yet available page if the date is less than 10th August 2021
When I click the Back to home button on the SOA not yet available page then I am taken back to the dashboard
Then I will be navigated to the T Levels Dashboard page