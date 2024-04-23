Feature: Amazon Shopping
    As an unregistered user
    I want to search for a product, add it to the cart, and validate the cart details

Scenario: Add product to cart and validate cart details
    Given I navigate to https://www.amazon.com/ as an unregistered user
    When I search for "TP-Link N450 WiFi Router - Wireless Internet Router for Home (TL-WR940N)"
    And I add the corresponding item to the cart
    Then I navigate to cart and validate the correct item and amount is displayed
