/******************************************************************************\
* Name: Jason D. F. D'Oyley
* Date: October 30, 2022
* Assignment CIS214 Week 4 GP - The Finally Block
*
* Main application (program) class.
* In this application we will demonstrate the use of exception handling with a
* finally block.
\******************************************************************************/

public class FinallyDemo
{
    static void Main(string[] args)
    {
        // Print a header line
        Console.WriteLine("\nJason D'Oyley - Week 4 GP - The Finally Block\n");

        try
        {
            ThrowException();
        }
        catch (Exception e)
        {
            // Caught the exception thrown by throw
            Console.WriteLine(
                "Exception handled in main. Message: " + e.Message
            );
        }

        DoesNotThrowException();
    }

    // Demonstrate try...catch...finally
    public static void ThrowException()
    {
        // Throw an exception and immediately catch it
        try
        {
            Console.WriteLine("\nMethod ThrowException");
            throw new Exception("Exception thrown in ThrowException");
        }
        catch
        {
            Console.WriteLine("Exception handled in method ThrowException");

            // Re-throw the exception for further processing
            throw;
        }
        finally
        {
            // Executes regardles of what happens in try...catch
            Console.WriteLine("Finally executed in ThrowException");
        }

        // Any code placed here would not be reached and would generate
        // comilation warnings because of the throw in the try block - the
        // warning generated is an "unreachable code" warning, which will happen
        // any time a block of code can never be executed; if you uncomment the
        // line of code below, you'll see this demonstrated
        // Console.WriteLine("Program generates warning with this uncommented.")
    }

    // Demonstrate finally with no exception thrown
    public static void DoesNotThrowException()
    {
        // Don't throw an exception
        try
        {
            Console.WriteLine("\nMethod DoesNotThrowException");

        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }
        finally
        {
            // Executes regardless of what happens in try...catch
            Console.WriteLine("Finally executed in DoesNotThrowException");
        }

        Console.WriteLine("End of method DoesNotThrowException");
    }
}
