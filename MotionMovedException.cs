public class MotionMovedException : ImagerException
{
    protected override string Descript { get; } = @"Motion platform encountered erros";

    // sub of Imager Exception. ImagerException base value is 3100;
    public override int ErrorNo { get; protected set; } = 31200;

    public MotionMovedException() : base()
    {       
        
    }

    //Call this construct method if you want to custorm sub - error number. For example : 1012.
    //You used 1012 to indicated more detail error.
    public MotionMovedException(int error) : base()
    {       
        ErrorNo = error;
    }

    //Construct with more message
    public MotionMovedException( string message) : base (message)
    {
    }

    //Construct with more message and sub - error number
    public MotionMovedException( string message, int error ) : base( message )
    {
         ErrorNo = error;
    }

    public MotionMovedException( string message, System.Exception inner ) : base( message, inner ) { }

    //Construct with more message, inner exception and sub - error number
    public MotionMovedException( string message, System.Exception inner, int error ) : base( message, inner )
    {
        ErrorNo = error;
    } 
}