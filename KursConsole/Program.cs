using System;
using Core;
using Core.ADO;

namespace KursConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            foreach (var ch in DataAccess.GetChilds())
            {
                Console.WriteLine(ch.Name);
            }
        }
    }
}
