using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RectangularArea
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        private void btn_DT_Click(object sender, EventArgs e)//Hàm xử lí nút tính DIỆN TÍCH của chương trình
        {
            double CD, CR, kq;// Khai báo các biến để chứa các giá trị
            CD = double.Parse(txtCD.Text);// Lấy dữ liệu chiều dài được người dùng nhập vào
            CR = double.Parse(txtCR.Text);// Lấy dữ liệu chiều rộng được người dùng nhập vào 
            Rectangle c = new Rectangle(CD, CR);
            kq = c.Cal("DT");
            txtKQ.Text = kq.ToString();// Sau khi tính ra kết quả hệ thống sẽ hiển thị kết quả lên màn hình
        }

        private void btn_CV_Click(object sender, EventArgs e)// Hàm xử lí nút tính CHU VI của chương trình
        {
            double CD, CR, kq;// Khai báo các biến để chứa các giá trị
            CD = double.Parse(txtCD.Text);// Lấy dữ liệu chiều dài được người dùng nhập vào
            CR = double.Parse(txtCR.Text);// Lấy dữ liệu chiều rộng được người dùng nhập vào 
            Rectangle c = new Rectangle(CD, CR);
            kq = c.Cal("CV");
            txtKQ.Text = kq.ToString();// Sau khi tính ra kết quả hệ thống sẽ hiển thị kết quả lên màn hình
        }
    }
}
