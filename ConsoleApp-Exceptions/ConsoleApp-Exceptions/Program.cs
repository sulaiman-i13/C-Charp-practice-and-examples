using System;

try
{
    //var x = 10;
    string? y = null;
	//var z = 0;
	//var w = x / z;
	//Console.WriteLine(y.ToUpper());
	throw new MyDivideByZeroException("this is my exception thrown");

	


}
catch(MyDivideByZeroException e) { 
    Console.WriteLine(e.Message); 
}
//we can use filter on catching an exception like this:

catch (Exception e)when (e.Source == "ConsoleApp-Exceptions")
{
    
    Console.WriteLine(e.Message);
}
finally
{
    Console.WriteLine("finished");
}

class MyDivideByZeroException : DivideByZeroException
{
    public MyDivideByZeroException(string message):base(message)
    {
        
    }
}