using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

[assembly: CLSCompliant(true)]
namespace UniversalClassLibraryTests
{
    [TestClass]
    public class HowToNewReference
    {
        [TestMethod]
        public void 別メモリ文字列()
        {
            // ユニバーサルDLLで文字列を作成
            string s1 = "";
            string s2 = String.Empty;
            string s3 = String.Copy(String.Empty);
            string s4 = String.Copy(String.Empty);
            string s5 = UniversalClassLibrary.Class1.GetNewString();
            string s6 = UniversalClassLibrary.Class1.GetNewString();
            // 一般.NET
            Assert.IsTrue(Object.ReferenceEquals(s1, s2));
            Assert.IsTrue(!Object.ReferenceEquals(s1, s3));
            Assert.IsTrue(!Object.ReferenceEquals(s3, s4));
            // ユニバーサル.NET
            Assert.IsTrue(s1 == s5);
            Assert.IsTrue(s2 == s6);
            Assert.IsTrue(s5 == s6);
            Assert.IsFalse(Object.ReferenceEquals(s1, s5));
            Assert.IsFalse(Object.ReferenceEquals(s2, s6));
            Assert.IsFalse(Object.ReferenceEquals(s5, s6));

            // 補足
            Assert.IsTrue("a"+"b" == "ab");
            Assert.IsTrue(Object.ReferenceEquals("a" + "b", "ab"));
            Assert.IsTrue(String.Concat("a" + "b") == String.Concat("ab"));
            Assert.IsFalse(Object.ReferenceEquals(String.Concat("a" + "b"), String.Concat("ab")));
            Assert.IsFalse(Object.ReferenceEquals(String.Concat("ab"), String.Concat("ab")));
        }
    }
}
