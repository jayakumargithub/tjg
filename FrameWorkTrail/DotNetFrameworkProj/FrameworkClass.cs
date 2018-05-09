using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StdLibraryOne;

namespace DotNetFrameworkProj
{
    public class FrameworkClass
    {
        public string Name()
        {
            return "FrameworkClass";
        }

        public string Test()
        {
            StdLibraryOne.StdLibraryClass stdLibrary = new StdLibraryClass();
            return stdLibrary.Name();
        }
    }
}
