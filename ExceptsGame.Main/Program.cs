using ExceptsGame;

string Description = @"
Welcome to the Excepti's game in this game there are unkown cookies numbered 0 - 9.
You each will take turns choosing a cookie one of the cookies is the oatmeal raisin cookie.
The rest of the cookies are choclate chip cookies. If you get the oatmeal raisin cookie you lose.
";

Random random = new Random();
int OatmealCookie = random.Next(0, 10);
List<int> chosenCookies = new List<int>();
int currentPlayer = 1;
int chosenCookie = -1;
Console.WriteLine(Description);
while(chosenCookie == -1)
{
    try
    {
        Console.WriteLine($"It is Player {currentPlayer}'s turn");
        string? input = Console.ReadLine();
        if(int.TryParse(input, out chosenCookie))
        {
            //for if someone is dumb and coses a cookie that is not one of the numbered cookies
            if(chosenCookie > 9 || chosenCookie < 0)
            {
                Console.WriteLine("That is not one of the numbered cookies");
                continue;
            }
            // Add one of the numbers chosen to the chosen list
            if(chosenCookies.Contains(chosenCookie))
            {
                throw new AlreadyChosenException();
            }
            // If the current player picks the oatmeal raisin cookie
            if(chosenCookie == OatmealCookie)
            {
                throw new RaisinCookieException();
            }
            chosenCookies.Add(chosenCookie);

            if(currentPlayer == 1) // change between player one and player two
            {
                currentPlayer ++;
            }else
            {
                currentPlayer --;
            }
        }else
        {
            Console.WriteLine("That was not a number try again.");
            chosenCookie = -1;
        }
    }catch(AlreadyChosenException e)
    {
        Console.WriteLine(e.Message);
    }catch(RaisinCookieException e)
    {
        Console.WriteLine(e.Message);
        if(currentPlayer == 1) // change between player one and player two
        {
            currentPlayer ++;
        }else
        {
            currentPlayer --;
        }
        Console.WriteLine($"Player {currentPlayer} won because the other player ate the oatmeal raisin cookie.");
        break;
    }finally
    {
        chosenCookie = -1;
    }
}

// My awnsers to the two questions at the end of the challenge
string Question1 = @"
I used a custom exception type to get more practice making custom exceptions.";
string Question2 = @"
I most likely would not have used an exception I think of exceptions for when my code breaks and I don't know what it did.
For things that I expected I would just have a condition for that like an if or a while.
";
Console.Write(Question1); 
Console.Write(Question2);
