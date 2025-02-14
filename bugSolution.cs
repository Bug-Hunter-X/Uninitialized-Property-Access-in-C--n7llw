public class ExampleClass
{
    public int MyProperty { get; set; }

    // Constructor to initialize the property
    public ExampleClass()
    {
        MyProperty = 0; // Explicit initialization
    }

    public void MyMethod()
    {
        Console.WriteLine(MyProperty); // Now MyProperty has a defined value.
        MyProperty = 10;
    }
}