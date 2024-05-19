using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using RectangularArea;


namespace RectangularAreaTester
{
    [TestClass]
    public class UnitTest1
    {
        private Rectangle r;
        [TestInitialize]
        public void SetUp() // khai báo sẵn các biến để dùng test
        {
            r = new Rectangle(5, 5);
        }
        [TestMethod] // Test case tính diện tích hình chữ nhật
        public void Test_TinhDienTich_HCN()
        {
            double expected, actual;
            expected = 25;
            actual = r.Cal("DT");
            Assert.AreEqual(expected, actual);
        }
        [TestMethod] // Test case tính chu vi hình chữ nhật
        public void Test_TinhChuVi_HCN()
        {
            double expected, actual;
            expected = 20;
            actual = r.Cal("CV");
            Assert.AreEqual(expected, actual);
        }
        
    }
}
