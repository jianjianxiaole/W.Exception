public class ImagerException : WangException
{
    protected override string Descript { get; } = @"Imager encountered error";

    public override int ErrorNo { get; protected set; } = 31000;

    public ImagerException() : base()
    {       
        
    }

    //Call this construct method if you want to custorm sub - error number. For example : 1012.
    //You used 1012 to indicated more detail error.
    public ImagerException(int error) : base()
    {       
        ErrorNo = error;
    }

    //Construct with more message
    public ImagerException( string message) : base (message)
    {
    }

    //Construct with more message and sub - error number
    public ImagerException( string message, int error ) : base( message )
    {
         ErrorNo = error;
    }

    public ImagerException( string message, System.Exception inner ) : base( message, inner ) { }

    //Construct with more message, inner exception and sub - error number
    public ImagerException( string message, System.Exception inner, int error ) : base( message, inner )
    {
        ErrorNo = error;
    }
}