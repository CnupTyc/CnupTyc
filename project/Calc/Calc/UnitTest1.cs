using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calc
{
    [TestClass]
    public class UnitTest1
    {
        /// <summary>
        ///Получает или устанавливает контекст теста, в котором предоставляются
        ///сведения о текущем тестовом запуске и обеспечивается его функциональность.
        ///</summary>
        [TestMethod]
        public void TestSum()
        {
            Calculator m = new Calculator();
            double a = 5;
            double b = 6;
            double c = 11;
            double res = m.Sum(a, b);
            Assert.AreEqual(res.ToString("0.000"), c.ToString("0.000"));
        }
    }
}
