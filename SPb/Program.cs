
using System.Diagnostics;

foreach (Process process in Process.GetProcesses())
{
    Console.WriteLine(process.NonpagedSystemMemorySize64);
}



