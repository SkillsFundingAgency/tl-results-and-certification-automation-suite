Feature: Create 'Contact us' page
	As A user
	I WANT to be able to contact ESFA
	SO THAT if I'm stuck I can get help


@SmokeTest
Scenario: TLRC2458_Verify Contact link on Tlevel start page (not logged in)
	Given I have navigated to Tlevel Start page
	And I click the Contact link on the start page when I am not logged in
	Then Contact us page should open with a heading of "Contact the Manage T Level results team" 
	And there will be no breadcrumbs present
	And the support link will navigate to the Discussion forum

@SmokeTest
Scenario: TLRC2458_Verify Contact link on the Dashboard page (logged in)
	Given I have logged in as a "Provider" user
	And I click the Contact link on the Dashboard page (when I am logged in)
	Then Contact us page should open with a heading of "Contact us" 
	And there will be breadcrumbs present
	And the support link will navigate to the Discussion forum
	And the Home breadcrumb will navigate to the Dasboard page