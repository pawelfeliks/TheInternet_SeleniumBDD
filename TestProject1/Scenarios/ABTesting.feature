Feature: ABTesting
	This feature file stores requirements for A/B Testing page

Scenario: Open page ABTesting
	Given I have opened main page
	When I click A/B Testing link
	Then The ABTesting page is opened

Scenario: Title of a page ABTesting
	Given I have opened a page A/B Testing
	Then the title of a page is 'The Internet'

Scenario: Footer of a page ABTesting
	Given I have opened a page A/B Testing
	And I have clicked on the footer on the page ABTesting
	Then The footer of the page ABTesting directs us to page 'http://elementalselenium.com/'

Scenario: Image in the right top
	Given I have opened a page A/B Testing
	And I have clicked on the image in the right top on the page ABTesting
	Then The image on the right top page ABTesting directs us to page 'https://github.com/saucelabs/the-internet'

Scenario: The key word in the text
	Given I have opened a page A/B Testing
	Then The sentence 'split testing' is in the text
