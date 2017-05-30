using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

[assembly: System.Runtime.InteropServices.ComVisible(false)]
[assembly: CLSCompliant(true)]
namespace UniversalClassLibrary
{
    public sealed class Class1
    {
        private Class1(){}

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1024:UsePropertiesWhereAppropriate")]
        public static string GetNewString()
        {
            //return new String(new char[0]);
            //return "abc".Replace("abc", String.Empty);
            //return "ab".Replace("a", String.Empty).Replace("b", String.Empty);
            //return "ab".Substring(1, 1).Replace("b","");
            //return "ab".Substring(1, 0);
            //return "".ToString();
            return String.Concat(String.Empty);
        }
    }
}
