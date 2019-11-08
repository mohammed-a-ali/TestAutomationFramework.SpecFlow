Feature: Registration
	
Scenario: User Registration
	Given I am on the Home Page
	When I click "Register"
	And I go to "Register" page
	And I click "Male"
	And I enter "FirstName" into "FirstName" textbox
	And I enter "LastName" into "LastName" textbox
	And I enter "Email" into "Email" textbox
	And I enter "Password" into "Password" textbox
	And I enter "ConfirmPassword" into "Password" textbox
	And I invoke "Register" button
	Then "result" should be "Your registration completed"
	When I invoke "Continue" button
	And I click "Log out"