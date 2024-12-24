namespace NT101_PJ.UI
{
    partial class RSAwKey
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
            rsa_banGiaiMa = new RichTextBox();
            btGiaiMa = new Button();
            rsa_banMaHoaGuiDen = new RichTextBox();
            rsa_BanMaHoa = new RichTextBox();
            rsa_BanRo = new RichTextBox();
            groupBox3 = new GroupBox();
            btMaHoa = new Button();
            groupBox2 = new GroupBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            rsa_TaoKhoa = new Button();
            soPhiN = new TextBox();
            soQ = new TextBox();
            soP = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label4 = new Label();
            soE = new TextBox();
            soN = new TextBox();
            groupBox4 = new GroupBox();
            label5 = new Label();
            soD = new TextBox();
            groupBox5 = new GroupBox();
            groupBox1 = new GroupBox();
            button1 = new Button();
            groupBox6 = new GroupBox();
            label6 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox6.SuspendLayout();
            SuspendLayout();
            // 
            // rsa_banGiaiMa
            // 
            rsa_banGiaiMa.Location = new Point(24, 232);
            rsa_banGiaiMa.Margin = new Padding(3, 2, 3, 2);
            rsa_banGiaiMa.Name = "rsa_banGiaiMa";
            rsa_banGiaiMa.Size = new Size(559, 126);
            rsa_banGiaiMa.TabIndex = 5;
            rsa_banGiaiMa.Text = "";
            // 
            // btGiaiMa
            // 
            btGiaiMa.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btGiaiMa.Location = new Point(471, 22);
            btGiaiMa.Margin = new Padding(3, 2, 3, 2);
            btGiaiMa.Name = "btGiaiMa";
            btGiaiMa.Size = new Size(113, 32);
            btGiaiMa.TabIndex = 4;
            btGiaiMa.Text = "Decrypt";
            btGiaiMa.UseVisualStyleBackColor = true;
            btGiaiMa.Click += btGiaiMa_Click;
            // 
            // rsa_banMaHoaGuiDen
            // 
            rsa_banMaHoaGuiDen.Location = new Point(27, 232);
            rsa_banMaHoaGuiDen.Margin = new Padding(3, 2, 3, 2);
            rsa_banMaHoaGuiDen.Name = "rsa_banMaHoaGuiDen";
            rsa_banMaHoaGuiDen.Size = new Size(552, 126);
            rsa_banMaHoaGuiDen.TabIndex = 3;
            rsa_banMaHoaGuiDen.Text = "";
            // 
            // rsa_BanMaHoa
            // 
            rsa_BanMaHoa.Location = new Point(24, 61);
            rsa_BanMaHoa.Margin = new Padding(3, 2, 3, 2);
            rsa_BanMaHoa.Name = "rsa_BanMaHoa";
            rsa_BanMaHoa.Size = new Size(559, 126);
            rsa_BanMaHoa.TabIndex = 2;
            rsa_BanMaHoa.Text = "";
            // 
            // rsa_BanRo
            // 
            rsa_BanRo.Location = new Point(27, 66);
            rsa_BanRo.Margin = new Padding(3, 2, 3, 2);
            rsa_BanRo.Name = "rsa_BanRo";
            rsa_BanRo.Size = new Size(552, 126);
            rsa_BanRo.TabIndex = 0;
            rsa_BanRo.Text = "";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label11);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(rsa_banMaHoaGuiDen);
            groupBox3.Controls.Add(btMaHoa);
            groupBox3.Controls.Add(rsa_BanRo);
            groupBox3.Location = new Point(468, 20);
            groupBox3.Margin = new Padding(3, 2, 3, 2);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(3, 2, 3, 2);
            groupBox3.Size = new Size(611, 375);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "ENCRYPT";
            // 
            // btMaHoa
            // 
            btMaHoa.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btMaHoa.Location = new Point(473, 26);
            btMaHoa.Margin = new Padding(3, 2, 3, 2);
            btMaHoa.Name = "btMaHoa";
            btMaHoa.Size = new Size(107, 34);
            btMaHoa.TabIndex = 1;
            btMaHoa.Text = "Encrypt";
            btMaHoa.UseVisualStyleBackColor = true;
            btMaHoa.Click += btMaHoa_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(rsa_TaoKhoa);
            groupBox2.Controls.Add(soPhiN);
            groupBox2.Controls.Add(soQ);
            groupBox2.Controls.Add(soP);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label1);
            groupBox2.Location = new Point(24, 41);
            groupBox2.Margin = new Padding(3, 2, 3, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 2, 3, 2);
            groupBox2.Size = new Size(377, 306);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(39, 274);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(189, 20);
            label9.TabIndex = 5;
            label9.Text = "the public and private keys.";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(23, 246);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(309, 20);
            label8.TabIndex = 4;
            label8.Text = "2. n = p x q.n is used as the modulus for both ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(23, 212);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(265, 20);
            label7.TabIndex = 3;
            label7.Text = "1. p and q are two large prime number";
            // 
            // rsa_TaoKhoa
            // 
            rsa_TaoKhoa.Font = new Font("Microsoft YaHei", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rsa_TaoKhoa.Location = new Point(21, 26);
            rsa_TaoKhoa.Margin = new Padding(3, 2, 3, 2);
            rsa_TaoKhoa.Name = "rsa_TaoKhoa";
            rsa_TaoKhoa.Size = new Size(340, 29);
            rsa_TaoKhoa.TabIndex = 2;
            rsa_TaoKhoa.Text = "GENERATE KEY";
            rsa_TaoKhoa.UseVisualStyleBackColor = true;
            rsa_TaoKhoa.Click += rsa_TaoKhoa_Click;
            // 
            // soPhiN
            // 
            soPhiN.Location = new Point(88, 162);
            soPhiN.Margin = new Padding(3, 2, 3, 2);
            soPhiN.Name = "soPhiN";
            soPhiN.Size = new Size(269, 27);
            soPhiN.TabIndex = 1;
            // 
            // soQ
            // 
            soQ.Location = new Point(88, 120);
            soQ.Margin = new Padding(3, 2, 3, 2);
            soQ.Name = "soQ";
            soQ.Size = new Size(269, 27);
            soQ.TabIndex = 1;
            // 
            // soP
            // 
            soP.Location = new Point(88, 74);
            soP.Margin = new Padding(3, 2, 3, 2);
            soP.Name = "soP";
            soP.Size = new Size(272, 27);
            soP.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(16, 161);
            label3.Name = "label3";
            label3.Size = new Size(54, 22);
            label3.TabIndex = 0;
            label3.Text = "Phi N";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(17, 120);
            label2.Name = "label2";
            label2.Size = new Size(24, 22);
            label2.TabIndex = 0;
            label2.Text = "Q";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(17, 79);
            label1.Name = "label1";
            label1.Size = new Size(22, 22);
            label1.TabIndex = 0;
            label1.Text = "P";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 46);
            label4.Name = "label4";
            label4.Size = new Size(20, 20);
            label4.TabIndex = 0;
            label4.Text = "N";
            // 
            // soE
            // 
            soE.Location = new Point(60, 102);
            soE.Margin = new Padding(3, 2, 3, 2);
            soE.Name = "soE";
            soE.Size = new Size(297, 27);
            soE.TabIndex = 1;
            // 
            // soN
            // 
            soN.Location = new Point(59, 46);
            soN.Margin = new Padding(3, 2, 3, 2);
            soN.Name = "soN";
            soN.Size = new Size(299, 27);
            soN.TabIndex = 1;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(soE);
            groupBox4.Controls.Add(soN);
            groupBox4.Controls.Add(label5);
            groupBox4.Controls.Add(label4);
            groupBox4.Location = new Point(24, 374);
            groupBox4.Margin = new Padding(3, 2, 3, 2);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(3, 2, 3, 2);
            groupBox4.Size = new Size(377, 151);
            groupBox4.TabIndex = 1;
            groupBox4.TabStop = false;
            groupBox4.Text = "PUBLIC KEY";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(23, 109);
            label5.Name = "label5";
            label5.Size = new Size(17, 20);
            label5.TabIndex = 0;
            label5.Text = "E";
            // 
            // soD
            // 
            soD.Location = new Point(26, 41);
            soD.Margin = new Padding(3, 2, 3, 2);
            soD.Name = "soD";
            soD.Size = new Size(317, 27);
            soD.TabIndex = 1;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(soD);
            groupBox5.Location = new Point(24, 562);
            groupBox5.Margin = new Padding(3, 2, 3, 2);
            groupBox5.Name = "groupBox5";
            groupBox5.Padding = new Padding(3, 2, 3, 2);
            groupBox5.Size = new Size(377, 98);
            groupBox5.TabIndex = 1;
            groupBox5.TabStop = false;
            groupBox5.Text = "PRIVATE KEY (d,n)";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(groupBox5);
            groupBox1.Controls.Add(groupBox4);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Location = new Point(15, 20);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(427, 771);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "CREATE KEY";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Crimson;
            button1.Location = new Point(24, 680);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(381, 49);
            button1.TabIndex = 2;
            button1.Text = "CLEAR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(label12);
            groupBox6.Controls.Add(label10);
            groupBox6.Controls.Add(rsa_BanMaHoa);
            groupBox6.Controls.Add(rsa_banGiaiMa);
            groupBox6.Controls.Add(btGiaiMa);
            groupBox6.Location = new Point(468, 419);
            groupBox6.Margin = new Padding(3, 2, 3, 2);
            groupBox6.Name = "groupBox6";
            groupBox6.Padding = new Padding(3, 2, 3, 2);
            groupBox6.Size = new Size(611, 375);
            groupBox6.TabIndex = 4;
            groupBox6.TabStop = false;
            groupBox6.Text = "DECRYPT";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(27, 33);
            label6.Name = "label6";
            label6.Size = new Size(67, 20);
            label6.TabIndex = 4;
            label6.Text = "Message";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(24, 34);
            label10.Name = "label10";
            label10.Size = new Size(67, 20);
            label10.TabIndex = 6;
            label10.Text = "Message";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(27, 206);
            label11.Name = "label11";
            label11.Size = new Size(55, 20);
            label11.TabIndex = 5;
            label11.Text = "Output";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(24, 204);
            label12.Name = "label12";
            label12.Size = new Size(55, 20);
            label12.TabIndex = 6;
            label12.Text = "Output";
            // 
            // RSAwKey
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1101, 828);
            Controls.Add(groupBox6);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "RSAwKey";
            Text = "RSA with Key";
            FormClosed += RSAwKey_FormClosed;
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.RichTextBox rsa_banGiaiMa;
        private System.Windows.Forms.Button btGiaiMa;
        private System.Windows.Forms.RichTextBox rsa_banMaHoaGuiDen;
        private System.Windows.Forms.RichTextBox rsa_BanMaHoa;
        private System.Windows.Forms.RichTextBox rsa_BanRo;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btMaHoa;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox soPhiN;
        private System.Windows.Forms.TextBox soQ;
        private System.Windows.Forms.TextBox soP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox soE;
        private System.Windows.Forms.TextBox soN;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox soD;
        private System.Windows.Forms.Button rsa_TaoKhoa;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1;
        private Label label6;
        private Label label11;
        private Label label12;
        private Label label10;
    }
}