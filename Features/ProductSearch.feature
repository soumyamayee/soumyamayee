Feature: Amazon Product search


@TestCase1
  Scenario: List all Samsung phones with Camera Resolution 20 MP and above, Model Year 2023, Price Range £50 - £100
    Given user on the Amazon UK homepage
    When user navigate to the "Electronics and Computers" category
    And user select "Phones and Accessories"
    And user search for "Samsung phones"   
    And user select "Electronics & Photo"
    And user apply the filter "Camera Resolution 20 MP and above"
    And user apply the filter "Model Year 2023"
    And user apply the price range filter "£50 - £150"
    Then user should apply the brand filter "Samsung" 
    Then user should see a list of Samsung phones that match the specifications    