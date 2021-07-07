Feature: BasicAuth
	Simple calculator for adding two numbers

Scenario: User authentication by logging in
		Given I have opened a page BasicAuth
		When I have entered "admin" in the "user name" field
		And I have entered "admin" in the "password" field
		And I press the "login" button
		Then The header of the page is 'Basic Auth'

Scenario: Image in the right top
		Given I have opened a page BasicAuth
		And I have clicked on the image in the right top on the page ABTesting
		Then The image on the right top page ABTesting directs us to page 'https://github.com/saucelabs/the-internet'


Scenario: The key word in the text
		Given I have opened a page BasicAuth
		Then The sentence 'credentials' is in the text

