internal class Program
{
    public delegate string WriteLog(string message);
    public delegate void Del(string message);        
        

    private static void Main(string[] args)
    {
        Del handler = DelegateMethod;
        handler("oof");
        // Instantiate delegate variable log.
        WriteLog log;
        // Point to the method it uses.
        log = ReturnMessage;
        // Given method ReturnMessage returning message of 'Yeet'
        var res = log("Yeet");
        System.Console.WriteLine(res);
    }
    public static string ReturnMessage(string message)
    {
        return message;
    }
    public static void DelegateMethod(string message)
    {
        Console.WriteLine(message);
    }
}

