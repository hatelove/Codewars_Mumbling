using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Codewars_Mumbling
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void s_is_b_Accum_should_be_B()
        {
            var s = "b";
            Assert.AreEqual("B", Accumul.Accum(s));
        }
    }

    public class Accumul
    {
        public static String Accum(string s)
        {
            // your code
            return s.ToUpper();
        }
    }
}
