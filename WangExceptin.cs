using System;

public class WangException : Exception
{    
    //此异常的‘元描述'
    protected virtual string Descript { get; } = "BGI Device encoutnered error";
    
    
    //BGI EXCEPTION 最顶层错误码
    public virtual int ErrorNo { get; protected set; } = 1000;
    
    public override string Message
    {
        get 
        {
            return $"{Descript}. Error code : {ErrorNo}. {base.Message}";
        }
    }

    public WangException() : base()
    {       
        
    }

    //Call this construct method if you want to custorm sub - error number. For example : 1012.
    //You used 1012 to indicated more detail error.
    public WangException(int error) : base()
    {       
        ErrorNo = error;
    }

    //Construct with more message
    public WangException( string message) : base (message)
    {
    }

    //Construct with more message and sub - error number
    public WangException( string message, int error ) : base( message )
    {
         ErrorNo = error;
    }

    public WangException( string message, System.Exception inner ) : base( message, inner ) { }

    //Construct with more message, inner exception and sub - error number
    public WangException( string message, System.Exception inner, int error ) : base( message, inner )
    {
        ErrorNo = error;
    }
}
