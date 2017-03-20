using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

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
            AccumulShouldBe(s, "B-Cc");
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
            var final = string.Empty;
            if (s.Length == 1)
            {
                final = ToUpper(s);
            }
            else
            {
                var temp = s[0] + "-" + s[1];
                final = ToUpper(temp) + s[1];
            }

            return final;
        }

        private static string ToUpper(string temp)
        {
            return temp.ToUpper();
        }
    }
}