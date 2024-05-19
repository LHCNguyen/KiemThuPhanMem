
namespace RectangularArea
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCD = new System.Windows.Forms.TextBox();
            this.txtCR = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtKQ = new System.Windows.Forms.TextBox();
            this.btn_DT = new System.Windows.Forms.Button();
            this.btn_CV = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(131, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(511, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tính diện tích và chu vi Hình Chữ Nhật";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(216, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nhập chiều Dài HCN:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(235, 25);
            this.label4.TabIndex = 1;
            this.label4.Text = "Nhập chiều Rộng HCN:";
            // 
            // txtCD
            // 
            this.txtCD.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCD.Location = new System.Drawing.Point(312, 130);
            this.txtCD.Name = "txtCD";
            this.txtCD.Size = new System.Drawing.Size(226, 31);
            this.txtCD.TabIndex = 2;
            // 
            // txtCR
            // 
            this.txtCR.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCR.Location = new System.Drawing.Point(312, 211);
            this.txtCR.Name = "txtCR";
            this.txtCR.Size = new System.Drawing.Size(226, 31);
            this.txtCR.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 280);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Kết Quả:";
            // 
            // txtKQ
            // 
            this.txtKQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKQ.Location = new System.Drawing.Point(312, 274);
            this.txtKQ.Name = "txtKQ";
            this.txtKQ.Size = new System.Drawing.Size(226, 31);
            this.txtKQ.TabIndex = 2;
            // 
            // btn_DT
            // 
            this.btn_DT.BackColor = System.Drawing.Color.Cyan;
            this.btn_DT.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DT.ForeColor = System.Drawing.Color.Red;
            this.btn_DT.Location = new System.Drawing.Point(223, 339);
            this.btn_DT.Name = "btn_DT";
            this.btn_DT.Size = new System.Drawing.Size(127, 80);
            this.btn_DT.TabIndex = 3;
            this.btn_DT.Text = "Diện tích";
            this.btn_DT.UseVisualStyleBackColor = false;
            this.btn_DT.Click += new System.EventHandler(this.btn_DT_Click);
            // 
            // btn_CV
            // 
            this.btn_CV.BackColor = System.Drawing.Color.Cyan;
            this.btn_CV.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CV.ForeColor = System.Drawing.Color.Red;
            this.btn_CV.Location = new System.Drawing.Point(515, 339);
            this.btn_CV.Name = "btn_CV";
            this.btn_CV.Size = new System.Drawing.Size(127, 80);
            this.btn_CV.TabIndex = 3;
            this.btn_CV.Text = "Chu vi";
            this.btn_CV.UseVisualStyleBackColor = false;
            this.btn_CV.Click += new System.EventHandler(this.btn_CV_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_CV);
            this.Controls.Add(this.btn_DT);
            this.Controls.Add(this.txtKQ);
            this.Controls.Add(this.txtCR);
            this.Controls.Add(this.txtCD);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCD;
        private System.Windows.Forms.TextBox txtCR;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtKQ;
        private System.Windows.Forms.Button btn_DT;
        private System.Windows.Forms.Button btn_CV;
    }
}

