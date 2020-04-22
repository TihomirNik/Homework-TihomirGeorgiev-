Feature: Test
	As a unregisterd user i should be abble to create account

@positive
Scenario: Create successfully account with correct information
	Given I naovigate to Automationpractice website
	When I click on Sign in button
	And I enter new valid email for every registration
	And Click on Create account button
	And I enter my First Name Tihomir
	And I enter my Last Name Georgiev
	And I enter my password asd123321
	And I enter my address homehere
	And I enter City plovdiev
	And I choose state from dropdown
	And I enter postal code 00000
	And I enter my Mobile phone 123456789
	And I enter the Assign an address alias for future reference somewhere else
	And I click on registerButton
	Then Welcome message should be displayed in user profile page
	

	@negative 
Scenario: Error appears when the postal code is field incorrectly
	Given I naovigate to Automationpractice website
	When I click on Sign in button
	And Enter unregisterd email for every registration <email>
	And Click on Create account button
	And I enter my First Name <firstName>
	And I enter my Last Name <lastName>
	And I enter my password <password>
	And I enter my address <address>
	When I enter City <city>
	And I choose state from dropdown
	And I enter postal code <postalCode>
	And I enter my Mobile phone <mobilephone>
	And I enter the Assign an address alias for future reference <aliasAddress>
	And I click on registerButton
	Then A error message should be displayed on top of the page about invalid input of the postal code
	Examples:
	| firstName | lastName | email     | password | address | city     | postalCode | mobilephone | aliasAddress |
	| Tihomir   | Georgiev | GT@abv.bg | asd1234  | asdq    | Florida  | 123        | 123456789   | dsarqwewq    |