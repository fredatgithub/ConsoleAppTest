using System;
using System.Runtime.InteropServices;

namespace ConsoleAppTest
{
  internal class Program
  {
    static void Main()
    {
      Action<string> display = Console.WriteLine;
      display($"The Framework is: {RuntimeInformation.FrameworkDescription}");
      display(string.Empty);
      display($"The Process Architecture is: {RuntimeInformation.ProcessArchitecture}");
      display(string.Empty);
      display($"The OS Architecture is: {RuntimeInformation.OSArchitecture}");
      display(string.Empty);
      display($"The OS Description is: {RuntimeInformation.OSDescription}");
      display(string.Empty);
      display("Press any key to exit:");
      Console.ReadKey();
    }
  }
}
