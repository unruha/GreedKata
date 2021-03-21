# GreedKata

## Description
```
An ASP.NET Core service that provides score calculation functionality. One API gets a roll with 5 random
values and calculates the score. the second API takes in 5 roll values and returns the calculated score
to the user.
```

## Alaska Airlines Coding Exercise Prompt
```
Questions you came up with:
    - how should the user be able to interact with the dice roll values?
    - should the user be able to set the roll values then calculate the score?
    - should the user be able to ask for a random roll and its score?
    - how will the user enter the dice roll values?

Assumptions you made:
    - the user should be able to set roll values to verify that the score calculation is accurate.
    - there should be random roll functionality to simulate a real random dice roll.
    - the user should enter the dice roll values in a frontend UI using input fields

The different paths or solutions you contemplated:
    - project structure and interface:
        - I considered various approaches such as a Java or C# console application, a frontend only application, 
          or a backend service that provides the game logic and API's with a frontend app that uses the API's to
          provide the game functionality to the user.
    - score calculation:
        - I decided to loop through each of the roll values then add them to a hashmap with a count of how many
          times that number has appeared in the list. Then I iterated through the hashmap and used integer
          division to determine whether the frequency of a number was multiple of 3, then added the correct score to
          the total. I then used the modulus operator to add the correct score of 1's and 5's to the total.
        - I was originally going to add the numbers to an array containing like numbers, but I realized I could use
          a hashmap to calculate the score in O(n) time instead of O(n^2) time.
```
