
public class CamerException : ImagerException 
{

    protected override string Descript { get; } = @"Camer encountered erros";

    // sub of Imager Exception. ImagerException base value is 3100;
    public override int ErrorNo { get; protected set; } = 31100; 
    public CamerException() : base()
    {       
        
    }

    //Call this construct method if you want to custorm sub - error number. For example : 1012.
    //You used 1012 to indicated more detail error.
    public CamerException(int error) : base()
    {       
        ErrorNo = error;
    }

    //Construct with more message
    public CamerException( string message) : base (message)
    {
    }

    //Construct with more message and sub - error number
    public CamerException( string message, int error ) : base( message )
    {
         ErrorNo = error;
    }

    public CamerException( string message, System.Exception inner ) : base( message, inner ) { }

    //Construct with more message, inner exception and sub - error number
    public CamerException( string message, System.Exception inner, int error ) : base( message, inner )
    {
        ErrorNo = error;
    }
}