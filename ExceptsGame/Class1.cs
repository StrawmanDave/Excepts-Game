namespace ExceptsGame;

public class Class1
{

}

public class AlreadyChosenException : Exception
{
    public AlreadyChosenException(string defaultMessage = "Repeated chosen number.") : base(defaultMessage){}
}

public class RaisinCookieException : Exception
{
    public RaisinCookieException(string defaultMessage = "Looks like you got the yucky oatmeal raisin cookie.") : base(defaultMessage){}
}