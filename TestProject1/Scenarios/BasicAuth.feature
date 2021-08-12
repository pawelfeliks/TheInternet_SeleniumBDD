Feature: BasicAuth
	Simple calculator for adding two numbers

Background: 
	Given I have opened main page

Scenario: User authentication by logging in
		Given I have opened a page BasicAuth using login and password
		Then The communicate is 'User has been authenticated' ?

Scenario: Image in the right top
		Given I have opened a page BasicAuth
		And I have clicked on the image in the right top on the page BasicAuth
		Then The image on the right top page BasicAuth directs us to page 'https://github.com/saucelabs/the-internet'


Scenario: The key word in the text
		Given I have opened a page BasicAuth
		Then The sentence 'Congratulations!' is in the text

