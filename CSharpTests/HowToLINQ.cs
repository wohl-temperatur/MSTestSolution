using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

[assembly: CLSCompliant(true)]
namespace CSharpTests
{
    [TestClass]
    public class HowToLinq
    {
        [TestMethod]
        public void Linqメソッド構文()
        {
            List<string> l = new List<string>();
            l.Add("a");
            l.Add("b");
            // ラムダ式
            IEnumerable<string> v = l.Select(val => val + 0);
            Assert.AreEqual(2/*l.Count*/, v.Count());
            l.Add("c");
            Assert.AreEqual(3/*l.Count*/, v.Count());
            Assert.AreEqual("c0"/*l.Last() + 0*/, v.Last());

            // 通常文法
            v = l.Select(m通常文法);
            l.Add("d");
            Assert.AreEqual(l.Count, v.Count());
            Assert.AreEqual("d1"/*通常文法(l.Last())*/, v.Last());

            // デリゲート(匿名メソッド)フル文
            v = l.Select(
                delegate(string val)
                {
                    return val + 2;
                }
            );
            l.Add("e");
            Assert.AreEqual(l.Count, v.Count());
            Assert.AreEqual("a2", v.First());
            Assert.AreEqual("e2", v.Last());
        }
        private string m通常文法(string val)
        {
            return val + 1;
        }

        [TestMethod]
        public void Linqクエリ構文()
        {
            List<string> l = new List<string>();
            l.Add("a");
            l.Add("b");
            // メソッド構文でコンパイルされる
            IEnumerable<string> v = from a in l select a + 0;
            Assert.AreEqual(2/*l.Count*/, v.Count());
            l.Add("c");
            Assert.AreEqual(3/*l.Count*/, v.Count());
        }
    }
}
