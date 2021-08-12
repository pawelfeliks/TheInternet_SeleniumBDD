Feature: AddRemove
	This feature file stores requirements page Add Remove Elements

Background: 
	Given I have opened a Main Page

Scenario: The title of a page AddRemove
	Given I have opened a page AddRemove
	Then The title of a page is 'Add/Remove Elements'

Scenario: The Add Element button
	Given I have opened a page AddRemove
	And I have clicked on the button Add Element
	Then The button Delete appears

Scenario Outline: Multiple clicking on the buttons Add Element and Delete
	Given I have opened a page AddRemove
	And I have clicked on the button Add Element <start> times
	When I click button Delete <click> times
	Then There should be <left> buttons Delete

	Examples: 
		| start | click | left |
		| 12    | 5     | 7    |
		| 20    | 5     | 15   |