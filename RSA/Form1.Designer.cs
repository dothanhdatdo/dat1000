namespace RSA
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.soP = new System.Windows.Forms.TextBox();
            this.soQ = new System.Windows.Forms.TextBox();
            this.soPhiN = new System.Windows.Forms.TextBox();
            this.soN = new System.Windows.Forms.TextBox();
            this.soE = new System.Windows.Forms.TextBox();
            this.soD = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rsa_BanRo = new System.Windows.Forms.RichTextBox();
            this.btMaHoa = new System.Windows.Forms.Button();
            this.rsa_BanMaHoa = new System.Windows.Forms.RichTextBox();
            this.rsa_banGiaiMa = new System.Windows.Forms.RichTextBox();
            this.btGiaiMa = new System.Windows.Forms.Button();
            this.rsa_banMaHoaGuiDen = new System.Windows.Forms.RichTextBox();
            this.rsa_TaoKhoa2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rsa_TaoKhoa2);
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(30, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1254, 236);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tạo khóa";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.soPhiN);
            this.groupBox2.Controls.Add(this.soQ);
            this.groupBox2.Controls.Add(this.soP);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(49, 40);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(407, 179);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.soE);
            this.groupBox4.Controls.Add(this.soN);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Location = new System.Drawing.Point(524, 40);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(407, 179);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Khóa công khai";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.soD);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Location = new System.Drawing.Point(990, 40);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(234, 179);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Khóa bí mật";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nguyên tố p";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nguyên tố q";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Phi n";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "n";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "e";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(16, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "d";
            // 
            // soP
            // 
            this.soP.Location = new System.Drawing.Point(141, 37);
            this.soP.Name = "soP";
            this.soP.Size = new System.Drawing.Size(146, 22);
            this.soP.TabIndex = 1;
            // 
            // soQ
            // 
            this.soQ.Location = new System.Drawing.Point(141, 65);
            this.soQ.Name = "soQ";
            this.soQ.Size = new System.Drawing.Size(146, 22);
            this.soQ.TabIndex = 1;
            // 
            // soPhiN
            // 
            this.soPhiN.Location = new System.Drawing.Point(141, 116);
            this.soPhiN.Name = "soPhiN";
            this.soPhiN.Size = new System.Drawing.Size(146, 22);
            this.soPhiN.TabIndex = 1;
            // 
            // soN
            // 
            this.soN.Location = new System.Drawing.Point(143, 37);
            this.soN.Name = "soN";
            this.soN.Size = new System.Drawing.Size(146, 22);
            this.soN.TabIndex = 1;
            // 
            // soE
            // 
            this.soE.Location = new System.Drawing.Point(143, 82);
            this.soE.Name = "soE";
            this.soE.Size = new System.Drawing.Size(146, 22);
            this.soE.TabIndex = 1;
            // 
            // soD
            // 
            this.soD.Location = new System.Drawing.Point(21, 82);
            this.soD.Name = "soD";
            this.soD.Size = new System.Drawing.Size(146, 22);
            this.soD.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rsa_banGiaiMa);
            this.groupBox3.Controls.Add(this.btGiaiMa);
            this.groupBox3.Controls.Add(this.rsa_banMaHoaGuiDen);
            this.groupBox3.Controls.Add(this.rsa_BanMaHoa);
            this.groupBox3.Controls.Add(this.btMaHoa);
            this.groupBox3.Controls.Add(this.rsa_BanRo);
            this.groupBox3.Location = new System.Drawing.Point(30, 267);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1253, 261);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Mã hóa";
            // 
            // rsa_BanRo
            // 
            this.rsa_BanRo.Location = new System.Drawing.Point(27, 31);
            this.rsa_BanRo.Name = "rsa_BanRo";
            this.rsa_BanRo.Size = new System.Drawing.Size(527, 103);
            this.rsa_BanRo.TabIndex = 0;
            this.rsa_BanRo.Text = "";
            // 
            // btMaHoa
            // 
            this.btMaHoa.Location = new System.Drawing.Point(602, 79);
            this.btMaHoa.Name = "btMaHoa";
            this.btMaHoa.Size = new System.Drawing.Size(75, 23);
            this.btMaHoa.TabIndex = 1;
            this.btMaHoa.Text = "Mã hóa";
            this.btMaHoa.UseVisualStyleBackColor = true;
            this.btMaHoa.Click += new System.EventHandler(this.btMaHoa_Click);
            // 
            // rsa_BanMaHoa
            // 
            this.rsa_BanMaHoa.Location = new System.Drawing.Point(720, 31);
            this.rsa_BanMaHoa.Name = "rsa_BanMaHoa";
            this.rsa_BanMaHoa.Size = new System.Drawing.Size(527, 103);
            this.rsa_BanMaHoa.TabIndex = 2;
            this.rsa_BanMaHoa.Text = "";
            // 
            // rsa_banGiaiMa
            // 
            this.rsa_banGiaiMa.Location = new System.Drawing.Point(720, 145);
            this.rsa_banGiaiMa.Name = "rsa_banGiaiMa";
            this.rsa_banGiaiMa.Size = new System.Drawing.Size(527, 103);
            this.rsa_banGiaiMa.TabIndex = 5;
            this.rsa_banGiaiMa.Text = "";
            // 
            // btGiaiMa
            // 
            this.btGiaiMa.Location = new System.Drawing.Point(602, 193);
            this.btGiaiMa.Name = "btGiaiMa";
            this.btGiaiMa.Size = new System.Drawing.Size(75, 23);
            this.btGiaiMa.TabIndex = 4;
            this.btGiaiMa.Text = "Giải mã";
            this.btGiaiMa.UseVisualStyleBackColor = true;
            this.btGiaiMa.Click += new System.EventHandler(this.btGiaiMa_Click);
            // 
            // rsa_banMaHoaGuiDen
            // 
            this.rsa_banMaHoaGuiDen.Location = new System.Drawing.Point(27, 145);
            this.rsa_banMaHoaGuiDen.Name = "rsa_banMaHoaGuiDen";
            this.rsa_banMaHoaGuiDen.Size = new System.Drawing.Size(527, 103);
            this.rsa_banMaHoaGuiDen.TabIndex = 3;
            this.rsa_banMaHoaGuiDen.Text = "";
            // 
            // rsa_TaoKhoa2
            // 
            this.rsa_TaoKhoa2.Location = new System.Drawing.Point(289, 11);
            this.rsa_TaoKhoa2.Name = "rsa_TaoKhoa2";
            this.rsa_TaoKhoa2.Size = new System.Drawing.Size(125, 23);
            this.rsa_TaoKhoa2.TabIndex = 2;
            this.rsa_TaoKhoa2.Text = "Tạo khóa";
            this.rsa_TaoKhoa2.UseVisualStyleBackColor = true;
            this.rsa_TaoKhoa2.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1318, 555);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button rsa_TaoKhoa2;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox soD;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox soE;
        private System.Windows.Forms.TextBox soN;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox soPhiN;
        private System.Windows.Forms.TextBox soQ;
        private System.Windows.Forms.TextBox soP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RichTextBox rsa_banGiaiMa;
        private System.Windows.Forms.Button btGiaiMa;
        private System.Windows.Forms.RichTextBox rsa_banMaHoaGuiDen;
        private System.Windows.Forms.RichTextBox rsa_BanMaHoa;
        private System.Windows.Forms.Button btMaHoa;
        private System.Windows.Forms.RichTextBox rsa_BanRo;
    }
}

