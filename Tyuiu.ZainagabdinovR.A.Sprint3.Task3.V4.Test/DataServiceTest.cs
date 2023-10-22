using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ZainagabdinovR.A.Sprint3.Task3.V4.Lib;

namespace Tyuiu.ZainagabdinovR.A.Sprint3.Task3.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetCharCount()
        {
            DataService ds = new DataService();

            string value = "plkjjdw cvjkl";
            char item = 'j';

            string res = ds.DeleteCharInString(value, item);

            string wait = "plk dw cv kl";

            Assert.AreEqual(wait, res);
        }
    }
}
