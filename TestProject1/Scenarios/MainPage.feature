Feature: MainPage
	This feature file stores business requirements for home page

	#Gherkin
Scenario: Title of a home page
	Given I have opened main page
	Then The title of main page is 'The Internet'

Scenario:  Header of a home page
	Given I have opened main page
	Then The header of main page is 'Welcome to the-internet'

Scenario: Footer of a home page
	Given I have opened main page 
	And I have scrolled to the down
	Then The footer of the main page is 'Powered by Elemental Selenium'

Scenario: Image in the right top 
	Given I have opened a home page
	And I have clicked on the image in the right top
	Then The image directs us to page 'https://github.com/saucelabs/the-internet'

Scenario: Link in the footer of a home page
	Given I have opened a home page
	And I have scrolled to the down
	And I have clicked on the footer
	Then The footer directs us to page 'http://elementalselenium.com/'
	
