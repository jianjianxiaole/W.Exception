
public class InitializateException : WangException
{
    protected override string Descript { get; } = "BGI Device encoutnered initializate error";

    //base value
    public override int ErrorNo { get; protected set; } = 20000; 

    public InitializateException() : base()
    {       
        
    }

    //Call this construct method if you want to custorm sub - error number. For example : 1012.
    //You used 1012 to indicated more detail error.
    public InitializateException(int error) : base()
    {       
        ErrorNo = error;
    }

    //Construct with more message
    public InitializateException( string message) : base (message)
    {
    }

    //Construct with more message and sub - error number
    public InitializateException( string message, int error ) : base( message )
    {
         ErrorNo = error;
    }

    public InitializateException( string message, System.Exception inner ) : base( message, inner ) { }

    //Construct with more message, inner exception and sub - error number
    public InitializateException( string message, System.Exception inner, int error ) : base( message, inner )
    {
        ErrorNo = error;
    }
}