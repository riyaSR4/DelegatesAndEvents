using System;
namespace DelegatesAndEvents
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("SingleCastDelegate:");
            ArrayDelegates.SingleCastDelegate();
            Console.WriteLine("MultiCastDelegate:");
            ArrayDelegates.MultiCastDelegate();
            Console.WriteLine("Event:");
            EventHandler.EventImplement();
        }
    }
}