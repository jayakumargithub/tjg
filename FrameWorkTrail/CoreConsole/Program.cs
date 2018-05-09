using System;
using DotNetFrameworkProj;
using StdLibraryOne;
namespace CoreConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            StdLibraryOne.StdLibraryClass one = new StdLibraryClass();
            one.Test();
            one.Name();

            DotNetFrameworkProj.FrameworkClass proj = new FrameworkClass();

            proj.Name();


            Console.WriteLine("Hello World!");
        }
    }
}
