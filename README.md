# Excepts-Game
This file is for the Excepti's Game challenge in the C# PlayersGuide page 290
The game will pick a random number between 0 and 9 (incluse) to represent the oatmeal raisin cookie.
The game will allow players to take turns picking numbers between 0 and 9.
If a player repeats a number that has been already used, the program should make them select another.
Hint : if you use List<int> to store previously chosen numbers you can use its Contains method to see if a number has been used before.
If the number matches the one the game picked initially, an exception should be thrown, terminating the program. Run the program at least once like this to see it crash.
Put in a try/catch block to handles the exceptions and display the results.
Answer this queston: Did you make a custom exception type or use an existing one, and why did you choose what you did?
Anwser this question: You could write this program without exceptions, but the requirements demanded an exception for learning purposes. 
If you didn't have that requirement, would you have used an exception? Why or why not?