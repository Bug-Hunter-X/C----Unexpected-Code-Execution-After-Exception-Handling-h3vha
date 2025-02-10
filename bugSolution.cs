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
            Console.WriteLine("Result: " + result);
        }
        catch (DivideByZeroException ex)
        {
            // Handle the exception and prevent further execution if necessary
            Console.WriteLine("An error occurred: " + ex.Message);
            return; //Added return statement to prevent further execution
        }
        Console.WriteLine("Method execution continued"); 
    }
}