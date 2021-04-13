Feature: AddRemove
	This feature file stores requirements page Add Remove Elements


Scenario: The title of a page AddRemove
	Given I have opened a page AddRemove
	Then The title of a page is 'Add/Remove Elements'

Scenario: The Add Element button
	Given I have opened a page AddRemove
	And I have clicked on the button Add Element
	Then The button 'Delete' appears
	When I have clicked on the button 'Delete'
	Then The buttton 'Delete' disappears

Scenario: Click on the Add Element button and Delete button
	Given I have opened a page AddRemove
	And I have clicked on the button Add Element three times
	When The three buttons Delete appear
	Then I have clicked on the button Delete
	Then There are two buttons Delete

Scenario Outline: Multiple clicking on the buttons Add Element and Delete
	Given I have opened a page AddRemove
	And I have clicked on the button Add Element <start> times
	When I click button Delete <click> times
	Then There should be <left> buttons Delete

	Examples: 
		| start | click | left |
		| 12    | 5     | 7    |
		| 20    | 5     | 15   |