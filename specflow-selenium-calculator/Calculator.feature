Feature: Calculator
    Test a four function calculator

Background:
    Given I have opened the calculator

Scenario: Add two numbers
    When I press "123+456="
    Then the result should be "579"

Scenario: Divide two numbers, result is a fraction
    When I press "3/2="
    Then the result should be "1.5"

Scenario: Divide by zero
    When I press "5/0="
    Then the result should be "Infinity"

Scenario: Test order of operations
    When I press "2+3x4="
    Then the result should be "14"