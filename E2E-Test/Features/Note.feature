Feature: Note

@mytag
Scenario: Update button is visible
	Given I navigate to "https://localhost:44384/notes"
	When I click the link "Details"
	Then the button "Update" is visible