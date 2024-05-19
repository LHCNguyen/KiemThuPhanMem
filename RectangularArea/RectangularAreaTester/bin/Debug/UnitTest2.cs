using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RectangularArea;

namespace RectangularAreaTester
{
    [TestClass]
    public class UnitTest2
    {
        private object testContext;

        public TestContext TestContext { get; set; }
        [TestMethod]

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
            @".\DataDienTich\TestDienTich.csv", 
            "TestDienTich#csv", 
            DataAccessMethod.Sequential)]

        public void TinhDienTichData()
        {
            double a, b, expected, actual;
            a = double.Parse(TestContext.DataRow[0].ToString());
            b = double.Parse(TestContext.DataRow[1].ToString());
            expected = double.Parse(TestContext.DataRow[2].ToString());

            Rectangle r = new Rectangle(a, b);
            actual = r.Cal("DT");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
            @".\DataChuVi\TestChuVi.csv",
            "TestChuVi#csv",
            DataAccessMethod.Sequential)]
        public void TinhChuViData()
        {
            double a, b, expected, actual;
            a = double.Parse(TestContext.DataRow[0].ToString());
            b = double.Parse(TestContext.DataRow[1].ToString());
            expected = double.Parse(TestContext.DataRow[2].ToString());

            Rectangle r = new Rectangle(a, b);
            actual = r.Cal("CV");
            Assert.AreEqual(expected, actual);
        }
    }
}
