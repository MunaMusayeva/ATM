namespace ConsoleApp9;

internal class yanlis_pin:Exception
{
    public string Message { get; set; }
    public yanlis_pin(string Message) :base(Message)
    {
       
    }
}
