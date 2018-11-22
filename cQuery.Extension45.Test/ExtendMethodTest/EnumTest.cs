using System;
using System.Text;
using System.Collections.Generic;
using cQuery.Extension.ExtendMethods;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace cQuery.Extension45.Test.ExtendMethodTest
{
    [TestClass]
    public class EnumTest
    {
        [TestMethod]
        public void GetDescriptionTest()
        {
            string s = Gender.Male.GetDescription();
            Assert.AreEqual("Man" , s);

            string ss = Gender.Female.GetDescription();
            Assert.AreEqual("Woman" , ss);
        }
    }

    public enum Gender
    {
        [System.ComponentModel.Description("Man")]
        Male = 1,
        [System.ComponentModel.Description("Woman")]
        Female
    }
}
