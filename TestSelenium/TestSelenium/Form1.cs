using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System.Threading;


namespace TestSelenium
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Chức năng 1: Đăng nhập trang github
        // Test case 1 của chức năng 1: Đăng nhập, không nhập Uesername chỉ nhập Password 
        private void DangNhap_Thieu_UserName_Click(object sender, EventArgs e)
        {
            ChromeDriverService Chrome_Nguyen_36 = ChromeDriverService.CreateDefaultService();
            Chrome_Nguyen_36.HideCommandPromptWindow = true;
            IWebDriver Nguyen_36 = new ChromeDriver(Chrome_Nguyen_36);
            Nguyen_36.Navigate().GoToUrl("https://github.com/login");
            IWebElement taikhoan = Nguyen_36.FindElement(By.Name("login"));
            taikhoan.SendKeys("");
            IWebElement matkhau = Nguyen_36.FindElement(By.Name("password"));
            matkhau.SendKeys("lamhuynhchannguyen2003");
            IWebElement hoanthanh = Nguyen_36.FindElement(By.Name("commit"));
            hoanthanh.Click();
        }

        // Test case 2 của chức năng 1: Đăng nhập, không nhập Password chỉ nhập Username 
        private void DangNhap_ThieuPassWord_Click(object sender, EventArgs e)
        {
            ChromeDriverService Chrome_Nguyen_36 = ChromeDriverService.CreateDefaultService();
            Chrome_Nguyen_36.HideCommandPromptWindow = true;
            IWebDriver Nguyen_36 = new ChromeDriver(Chrome_Nguyen_36);
            Nguyen_36.Navigate().GoToUrl("https://github.com/login");
            IWebElement taikhoan = Nguyen_36.FindElement(By.Name("login"));
            taikhoan.SendKeys("LHCNguyen");
            IWebElement matkhau = Nguyen_36.FindElement(By.Name("password"));
            matkhau.SendKeys("");
            IWebElement hoanthanh = Nguyen_36.FindElement(By.Name("commit"));
            hoanthanh.Click();
        }

        // Test case 3 của chức năng 1: Đăng nhập sai Username
        private void DangNhap_SaiUsername_Click(object sender, EventArgs e)
        {
            ChromeDriverService Chrome_Nguyen_36 = ChromeDriverService.CreateDefaultService();
            Chrome_Nguyen_36.HideCommandPromptWindow = true;
            IWebDriver Nguyen_36 = new ChromeDriver(Chrome_Nguyen_36);
            Nguyen_36.Navigate().GoToUrl("https://github.com/login");
            IWebElement taikhoan = Nguyen_36.FindElement(By.Name("login"));
            taikhoan.SendKeys("LHCNguyen.");
            IWebElement matkhau = Nguyen_36.FindElement(By.Name("password"));
            matkhau.SendKeys("lamhuynhchannguyen2003");
            IWebElement hoanthanh = Nguyen_36.FindElement(By.Name("commit"));
            hoanthanh.Click();
        }

        // Test case 4 của chức năng 1: Đăng nhập sai Password
        private void DangNhap_SaiPassword_Click(object sender, EventArgs e)
        {
            ChromeDriverService Chrome_Nguyen_36 = ChromeDriverService.CreateDefaultService();
            Chrome_Nguyen_36.HideCommandPromptWindow = true;
            IWebDriver Nguyen_36 = new ChromeDriver(Chrome_Nguyen_36);
            Nguyen_36.Navigate().GoToUrl("https://github.com/login");
            IWebElement taikhoan = Nguyen_36.FindElement(By.Name("login"));
            taikhoan.SendKeys("LHCNguyen");
            IWebElement matkhau = Nguyen_36.FindElement(By.Name("password"));
            matkhau.SendKeys("lamhuynhchannguyen2003.");
            IWebElement hoanthanh = Nguyen_36.FindElement(By.Name("commit"));
            hoanthanh.Click();
        }

        //Test case 5 của chức năng 1: Đăng nhập, Nhập chính xác Username và Password
        private void DangNhap_NhapDung_Click(object sender, EventArgs e)
        {
            ChromeDriverService Chrome_Nguyen_36 = ChromeDriverService.CreateDefaultService();
            Chrome_Nguyen_36.HideCommandPromptWindow = true;
            IWebDriver Nguyen_36 = new ChromeDriver(Chrome_Nguyen_36);
            Nguyen_36.Navigate().GoToUrl("https://github.com/login");
            IWebElement taikhoan = Nguyen_36.FindElement(By.Name("login"));
            taikhoan.SendKeys("LHCNguyen");
            IWebElement matkhau = Nguyen_36.FindElement(By.Name("password"));
            matkhau.SendKeys("lamhuynhchannguyen2003");
            IWebElement hoanthanh = Nguyen_36.FindElement(By.Name("commit"));
            hoanthanh.Click();
        }

        // Chức năng 2: Tạo Repositories trong Github
        //Test Case 1 của chức năng 2: Tạo hợp lệ
        private void Tao_Repositories_Click(object sender, EventArgs e)
        {
            ChromeDriverService Chrome_Nguyen_36 = ChromeDriverService.CreateDefaultService();
            Chrome_Nguyen_36.HideCommandPromptWindow = true;
            IWebDriver Nguyen_36 = new ChromeDriver(Chrome_Nguyen_36);
            Nguyen_36.Navigate().GoToUrl("https://github.com/login");
            IWebElement taikhoan = Nguyen_36.FindElement(By.Name("login"));
            taikhoan.SendKeys("LHCNguyen");
            IWebElement matkhau = Nguyen_36.FindElement(By.Name("password"));
            matkhau.SendKeys("lamhuynhchannguyen2003");
            IWebElement hoanthanh = Nguyen_36.FindElement(By.Name("commit"));
            hoanthanh.Click();
            IWebElement newRepositories = Nguyen_36.FindElement(By.ClassName("Button--primary"));
            newRepositories.Click();
            IWebElement nameRepo = Nguyen_36.FindElement(By.XPath("//*[@id=\":ra:\"]"));
            nameRepo.SendKeys("TestKTPMM");
            IWebElement createRepo = Nguyen_36.FindElement(By.ClassName("kLvpkX"));
            createRepo.Click();
        }

        // Test Case 2 của chức năng 2: Tạo Repositories trong Github, Nhưng không nhập tên thùng chứa
        private void Tao_KhongNhapTenRepo_Click(object sender, EventArgs e)
        {
            ChromeDriverService Chrome_Nguyen_36 = ChromeDriverService.CreateDefaultService();
            Chrome_Nguyen_36.HideCommandPromptWindow = true;
            IWebDriver Nguyen_36 = new ChromeDriver(Chrome_Nguyen_36);
            Nguyen_36.Navigate().GoToUrl("https://github.com/login");
            IWebElement taikhoan = Nguyen_36.FindElement(By.Name("login"));
            taikhoan.SendKeys("LHCNguyen");
            IWebElement matkhau = Nguyen_36.FindElement(By.Name("password"));
            matkhau.SendKeys("lamhuynhchannguyen2003");
            IWebElement hoanthanh = Nguyen_36.FindElement(By.Name("commit"));
            hoanthanh.Click();
            IWebElement newRepositories = Nguyen_36.FindElement(By.ClassName("Button--primary"));
            newRepositories.Click();
            IWebElement nameRepo = Nguyen_36.FindElement(By.XPath("//*[@id=\":ra:\"]"));
            nameRepo.SendKeys("");
            
            IWebElement createRepo = Nguyen_36.FindElement(By.ClassName("kLvpkX"));
            createRepo.Click();
        }

        //Test Case 3 của chức năng 2: Tạo Repositories có tên trùng với Reppositories đã tạo
        private void Tao_RepoCoTenTrung_Click(object sender, EventArgs e)
        {
            ChromeDriverService Chrome_Nguyen_36 = ChromeDriverService.CreateDefaultService();
            Chrome_Nguyen_36.HideCommandPromptWindow = true;
            IWebDriver Nguyen_36 = new ChromeDriver(Chrome_Nguyen_36);
            Nguyen_36.Navigate().GoToUrl("https://github.com/login");
            IWebElement taikhoan = Nguyen_36.FindElement(By.Name("login"));
            taikhoan.SendKeys("LHCNguyen");
            IWebElement matkhau = Nguyen_36.FindElement(By.Name("password"));
            matkhau.SendKeys("lamhuynhchannguyen2003");
            IWebElement hoanthanh = Nguyen_36.FindElement(By.Name("commit"));
            hoanthanh.Click();
            IWebElement newRepositories = Nguyen_36.FindElement(By.ClassName("Button--primary"));
            newRepositories.Click();
            IWebElement nameRepo = Nguyen_36.FindElement(By.XPath("//*[@id=\":ra:\"]"));
            nameRepo.SendKeys("TestKTPM");
            IWebElement createRepo = Nguyen_36.FindElement(By.ClassName("kLvpkX"));
            createRepo.Click();
        }
    }
}
