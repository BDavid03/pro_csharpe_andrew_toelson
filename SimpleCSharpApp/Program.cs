/* By default the .NET console project template will generate a Main() method 
 * that has a void return value and an array of string types as the single input
 * Parameter. This is not the only possible form of Main(), however, it is permissable
 * to construct your application's entry point using the following signatures
 */
using System;

class Program
{
    
    static int Main(string[] args)
    {
        
        // Dsiplay a simple message to the suer.
        Console.WriteLine("****** My First C# App ******");
        ShowEnvironmentDetails();
        Console.WriteLine("=========================================");
        Console.WriteLine("Hello, World!");
        Console.WriteLine();

        ShowEnvironmentDetails();

        // Process incoming arguments
        //for (int i = 0; i < args.Length; i++)
        //{
        //    Console.WriteLine("Arg:{0}", args[i]);
        //}
        string[] theArgs = Environment.GetCommandLineArgs();
        
        foreach(string arg in theArgs)
        {
            Console.WriteLine("Arg:{0}", arg);
        }
        
        // Wait for enter key to be pressed before shutting down
        Console.ReadLine();

        return 0;
    }
    static void ShowEnvironmentDetails()
    {
        Console.WriteLine("OS Version: {0}", Environment.OSVersion);
        Console.WriteLine("64 Bit OS?: {0}", Environment.Is64BitOperatingSystem);
        Console.WriteLine("64 Bit Process?: {0}", Environment.Is64BitProcess);
        Console.WriteLine("Processor Count: {0}", Environment.ProcessorCount);
        Console.WriteLine("System Directory: {0}", Environment.SystemDirectory);
        Console.WriteLine("User Domain Name: {0}", Environment.UserDomainName);
        Console.WriteLine("User Name: {0}", Environment.UserName);
        Console.WriteLine();

        foreach(string drive in Environment.GetLogicalDrives())
        {
            Console.WriteLine("Drive: {0}", drive);

        }
        Console.WriteLine("Number of processors: {0}", Environment.ProcessorCount); 
        Console.WriteLine(".NET Core Version: {0}", Environment.Version);
    }
}