public class HelloWorld 
{
    public static string Hello(string name) 
    {
        if (name == null) name = "World";
        return "Hello, " + name + "!";
    }
}