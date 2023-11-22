using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace ListView_INFO_process
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Process.GetProcesses().ToList().ForEach(p => Console.WriteLine($"{p.Id}. {p.ProcessName}"));
            Console.ReadLine();
        }
    }
}
