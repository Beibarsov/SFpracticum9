// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");




Exception[] Exceptions = new Exception[5];
Exceptions[0] = new MyException("Программист решил, что число не может быть равно трем");
Exceptions[1] = new ArgumentNullException();
Exceptions[2] = new ArgumentOutOfRangeException();
Exceptions[3] = new FormatException();
Exceptions[4] = new IndexOutOfRangeException();

foreach (Exception e in Exceptions)
{
    try
    {
        throw e;
    }
    catch (MyException ex)
    {
        Console.WriteLine(ex.Message);
    }
    catch (ArgumentNullException ex)
    {
        Console.WriteLine(ex.Message);
    }
    catch (ArgumentOutOfRangeException ex)
    {
        Console.WriteLine(ex.Message);
    }
    catch (FormatException ex)
    {
        Console.WriteLine(ex.Message);
    }
    catch (IndexOutOfRangeException ex)
    {
        Console.WriteLine(ex.Message);
    }
}
