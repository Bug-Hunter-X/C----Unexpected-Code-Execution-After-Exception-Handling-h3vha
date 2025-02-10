public class ExampleClass
{
    public int MyProperty { get; set; }

    public ExampleClass(int value)
    {
        MyProperty = value;
    }

    public void MyMethod()
    {
        try
        {
            // Some code that might throw an exception
            int result = 10 / MyProperty;
        }
        catch (DivideByZeroException ex)
        {
            // Handle the exception
            Console.WriteLine("An error occurred: " + ex.Message);
        }
        //This line will be executed even if the exception was thrown, so it could lead to unexpected behavior.
        Console.WriteLine("Method execution continued"); 
    }
}