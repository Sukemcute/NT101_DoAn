namespace NT101_PJ
{
    partial class PlayFairForm
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
            groupBox1 = new GroupBox();
            groupBox3 = new GroupBox();
            rBtn6x6 = new RadioButton();
            rBtn5x5 = new RadioButton();
            panel1 = new Panel();
            textKey = new TextBox();
            label4 = new Label();
            label3 = new Label();
            textMessage = new TextBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            groupBox2 = new GroupBox();
            rBtnIgnoreDuplicates = new CheckBox();
            rBtnSeparateDuplicates = new CheckBox();
            label2 = new Label();
            label1 = new Label();
            textSecondSeparator = new TextBox();
            textFirstSeparator = new TextBox();
            rBtnSeparateDuplicatesFS = new CheckBox();
            groupBox4 = new GroupBox();
            label5 = new Label();
            textResult = new TextBox();
            textBox1 = new TextBox();
            btnEncrypt = new Button();
            btnDecrypt = new Button();
            btn_cls = new Button();
            btn_exit = new Button();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(groupBox3);
            groupBox1.Controls.Add(panel1);
            groupBox1.Controls.Add(textKey);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(textMessage);
            groupBox1.Font = new Font("Microsoft YaHei", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(12, 394);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(415, 599);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Input";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(rBtn6x6);
            groupBox3.Controls.Add(rBtn5x5);
            groupBox3.Font = new Font("Microsoft YaHei", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox3.Location = new Point(259, 365);
            groupBox3.Margin = new Padding(3, 4, 3, 4);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(3, 4, 3, 4);
            groupBox3.Size = new Size(134, 150);
            groupBox3.TabIndex = 5;
            groupBox3.TabStop = false;
            groupBox3.Text = "Matrix";
            // 
            // rBtn6x6
            // 
            rBtn6x6.AutoSize = true;
            rBtn6x6.Font = new Font("Microsoft YaHei", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rBtn6x6.Location = new Point(15, 92);
            rBtn6x6.Margin = new Padding(3, 4, 3, 4);
            rBtn6x6.Name = "rBtn6x6";
            rBtn6x6.Size = new Size(110, 23);
            rBtn6x6.TabIndex = 1;
            rBtn6x6.TabStop = true;
            rBtn6x6.Text = "6x6 matrix";
            rBtn6x6.UseVisualStyleBackColor = true;
            // 
            // rBtn5x5
            // 
            rBtn5x5.AutoSize = true;
            rBtn5x5.Font = new Font("Microsoft YaHei", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rBtn5x5.Location = new Point(15, 50);
            rBtn5x5.Margin = new Padding(3, 4, 3, 4);
            rBtn5x5.Name = "rBtn5x5";
            rBtn5x5.Size = new Size(110, 23);
            rBtn5x5.TabIndex = 0;
            rBtn5x5.TabStop = true;
            rBtn5x5.Text = "5x5 matrix";
            rBtn5x5.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Location = new Point(6, 365);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(244, 215);
            panel1.TabIndex = 4;
            // 
            // textKey
            // 
            textKey.Location = new Point(6, 310);
            textKey.Margin = new Padding(3, 4, 3, 4);
            textKey.Name = "textKey";
            textKey.Size = new Size(386, 34);
            textKey.TabIndex = 3;
            textKey.TextChanged += textKey_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(40, 272);
            label4.Name = "label4";
            label4.Size = new Size(47, 27);
            label4.TabIndex = 2;
            label4.Text = "Key";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(40, 51);
            label3.Name = "label3";
            label3.Size = new Size(96, 27);
            label3.TabIndex = 1;
            label3.Text = "Message";
            // 
            // textMessage
            // 
            textMessage.Location = new Point(6, 89);
            textMessage.Margin = new Padding(3, 4, 3, 4);
            textMessage.Multiline = true;
            textMessage.Name = "textMessage";
            textMessage.Size = new Size(386, 162);
            textMessage.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(rBtnIgnoreDuplicates);
            groupBox2.Controls.Add(rBtnSeparateDuplicates);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(textSecondSeparator);
            groupBox2.Controls.Add(textFirstSeparator);
            groupBox2.Controls.Add(rBtnSeparateDuplicatesFS);
            groupBox2.Font = new Font("Microsoft YaHei", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(15, 22);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(412, 341);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Option";
            // 
            // rBtnIgnoreDuplicates
            // 
            rBtnIgnoreDuplicates.AutoSize = true;
            rBtnIgnoreDuplicates.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rBtnIgnoreDuplicates.Location = new Point(42, 261);
            rBtnIgnoreDuplicates.Margin = new Padding(3, 4, 3, 4);
            rBtnIgnoreDuplicates.Name = "rBtnIgnoreDuplicates";
            rBtnIgnoreDuplicates.Size = new Size(333, 24);
            rBtnIgnoreDuplicates.TabIndex = 6;
            rBtnIgnoreDuplicates.Text = "Ignore duplicate letters in the key phrase";
            rBtnIgnoreDuplicates.UseVisualStyleBackColor = true;
            // 
            // rBtnSeparateDuplicates
            // 
            rBtnSeparateDuplicates.AutoSize = true;
            rBtnSeparateDuplicates.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rBtnSeparateDuplicates.Location = new Point(42, 201);
            rBtnSeparateDuplicates.Margin = new Padding(3, 4, 3, 4);
            rBtnSeparateDuplicates.Name = "rBtnSeparateDuplicates";
            rBtnSeparateDuplicates.Size = new Size(347, 24);
            rBtnSeparateDuplicates.TabIndex = 5;
            rBtnSeparateDuplicates.Text = "Separate duplicate letters only within pairs";
            rBtnSeparateDuplicates.UseVisualStyleBackColor = true;
            rBtnSeparateDuplicates.CheckedChanged += rBtnSeparateDuplicates_CheckedChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(74, 149);
            label2.Name = "label2";
            label2.Size = new Size(143, 20);
            label2.TabIndex = 4;
            label2.Text = "Second Separator";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(74, 92);
            label1.Name = "label1";
            label1.Size = new Size(121, 20);
            label1.TabIndex = 3;
            label1.Text = "First Separator";
            // 
            // textSecondSeparator
            // 
            textSecondSeparator.Location = new Point(256, 139);
            textSecondSeparator.Margin = new Padding(3, 4, 3, 4);
            textSecondSeparator.Name = "textSecondSeparator";
            textSecondSeparator.Size = new Size(34, 34);
            textSecondSeparator.TabIndex = 2;
            textSecondSeparator.Text = "Y";
            textSecondSeparator.TextAlign = HorizontalAlignment.Center;
            // 
            // textFirstSeparator
            // 
            textFirstSeparator.Location = new Point(256, 85);
            textFirstSeparator.Margin = new Padding(3, 4, 3, 4);
            textFirstSeparator.Name = "textFirstSeparator";
            textFirstSeparator.Size = new Size(34, 34);
            textFirstSeparator.TabIndex = 1;
            textFirstSeparator.Text = "X";
            textFirstSeparator.TextAlign = HorizontalAlignment.Center;
            // 
            // rBtnSeparateDuplicatesFS
            // 
            rBtnSeparateDuplicatesFS.AutoSize = true;
            rBtnSeparateDuplicatesFS.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rBtnSeparateDuplicatesFS.Location = new Point(42, 46);
            rBtnSeparateDuplicatesFS.Margin = new Padding(3, 4, 3, 4);
            rBtnSeparateDuplicatesFS.Name = "rBtnSeparateDuplicatesFS";
            rBtnSeparateDuplicatesFS.Size = new Size(222, 24);
            rBtnSeparateDuplicatesFS.TabIndex = 0;
            rBtnSeparateDuplicatesFS.Text = "Separate duplicate letters";
            rBtnSeparateDuplicatesFS.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(label5);
            groupBox4.Controls.Add(textResult);
            groupBox4.Controls.Add(textBox1);
            groupBox4.Font = new Font("Microsoft YaHei", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox4.Location = new Point(445, 22);
            groupBox4.Margin = new Padding(3, 4, 3, 4);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(3, 4, 3, 4);
            groupBox4.Size = new Size(412, 622);
            groupBox4.TabIndex = 2;
            groupBox4.TabStop = false;
            groupBox4.Text = "Output";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(40, 55);
            label5.Name = "label5";
            label5.Size = new Size(69, 27);
            label5.TabIndex = 4;
            label5.Text = "Result";
            // 
            // textResult
            // 
            textResult.Location = new Point(6, 92);
            textResult.Margin = new Padding(3, 4, 3, 4);
            textResult.Multiline = true;
            textResult.Name = "textResult";
            textResult.Size = new Size(400, 522);
            textResult.TabIndex = 3;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(256, 139);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(34, 34);
            textBox1.TabIndex = 2;
            textBox1.Text = "Y";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // btnEncrypt
            // 
            btnEncrypt.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEncrypt.Location = new Point(505, 702);
            btnEncrypt.Margin = new Padding(3, 4, 3, 4);
            btnEncrypt.Name = "btnEncrypt";
            btnEncrypt.Size = new Size(131, 88);
            btnEncrypt.TabIndex = 3;
            btnEncrypt.Text = "Encrypt";
            btnEncrypt.UseVisualStyleBackColor = true;
            btnEncrypt.Click += btnEncrypt_Click;
            // 
            // btnDecrypt
            // 
            btnDecrypt.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDecrypt.Location = new Point(682, 702);
            btnDecrypt.Margin = new Padding(3, 4, 3, 4);
            btnDecrypt.Name = "btnDecrypt";
            btnDecrypt.Size = new Size(131, 88);
            btnDecrypt.TabIndex = 4;
            btnDecrypt.Text = "Decrypt";
            btnDecrypt.UseVisualStyleBackColor = true;
            btnDecrypt.Click += btnDecrypt_Click;
            // 
            // btn_cls
            // 
            btn_cls.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_cls.ForeColor = Color.Red;
            btn_cls.Location = new Point(505, 829);
            btn_cls.Margin = new Padding(3, 4, 3, 4);
            btn_cls.Name = "btn_cls";
            btn_cls.Size = new Size(131, 88);
            btn_cls.TabIndex = 5;
            btn_cls.Text = "Clear";
            btn_cls.UseVisualStyleBackColor = true;
            btn_cls.Click += btn_cls_Click;
            // 
            // btn_exit
            // 
            btn_exit.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_exit.ForeColor = Color.Red;
            btn_exit.Location = new Point(682, 829);
            btn_exit.Margin = new Padding(3, 4, 3, 4);
            btn_exit.Name = "btn_exit";
            btn_exit.Size = new Size(131, 88);
            btn_exit.TabIndex = 6;
            btn_exit.Text = "Exit";
            btn_exit.UseVisualStyleBackColor = true;
            btn_exit.Click += btn_exit_Click;
            // 
            // PlayFairForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(879, 1015);
            Controls.Add(btn_exit);
            Controls.Add(btn_cls);
            Controls.Add(btnDecrypt);
            Controls.Add(btnEncrypt);
            Controls.Add(groupBox4);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "PlayFairForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PlayFair";
            FormClosed += PlayFair_FormClosed;
            Load += PlayFair_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox textMessage;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox rBtnSeparateDuplicatesFS;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textSecondSeparator;
        private System.Windows.Forms.TextBox textFirstSeparator;
        private System.Windows.Forms.CheckBox rBtnIgnoreDuplicates;
        private System.Windows.Forms.CheckBox rBtnSeparateDuplicates;
        private System.Windows.Forms.TextBox textKey;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rBtn6x6;
        private System.Windows.Forms.RadioButton rBtn5x5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textResult;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.Button btn_cls;
        private System.Windows.Forms.Button btn_exit;
    }
}