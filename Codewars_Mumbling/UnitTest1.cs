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
            AccumulShouldBe(s, "B");
        }

        [TestMethod]
        public void s_is_bc_Accum_should_be_B_Cc()
        {
            var s = "bc";
            AccumulShouldBe(s,"B-Cc");
        }

        private static void AccumulShouldBe(string s, string expected)
        {
            Assert.AreEqual(expected, Accumul.Accum(s));
        }
    }

    public class Accumul
    {
        public static String Accum(string s)
        {
            // your code
            if (s.Length == 1) return s.ToUpper();
            var target = s;
            var temp =  target[0]+ "-"+target[1];
            var final = temp.ToUpper() + target[1];
            return final;
        }
    }
}
