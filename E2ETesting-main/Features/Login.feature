Feature: Login test

Scenario: I login as a user 
    Given I am on the login page
    When I enter "admin@shop.com" as the username
    # And I enter "Password123!" as the password
    Then I click on the login button