namespace NT101_PJ
{
    partial class RSAForm
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
            richTextBoxInput = new RichTextBox();
            groupBoxInput = new GroupBox();
            groupBoxOutput = new GroupBox();
            richTextBoxOutput = new RichTextBox();
            richTextBoxPublic = new RichTextBox();
            richTextBoxPrivate = new RichTextBox();
            labelPublicKey = new Label();
            labelPrivateKey = new Label();
            comboBoxKeySize = new ComboBox();
            labelKeySize = new Label();
            buttonOpenPublic = new Button();
            buttonOpenPrivate = new Button();
            buttonGenerate = new Button();
            groupBoxKey = new GroupBox();
            labelPadding = new Label();
            comboBoxPadding = new ComboBox();
            buttonSavePrivate = new Button();
            buttonSavePublic = new Button();
            buttonImport = new Button();
            buttonReset = new Button();
            buttonEncrypt = new Button();
            buttonDecrypt = new Button();
            btn_exit = new Button();
            groupBoxInput.SuspendLayout();
            groupBoxOutput.SuspendLayout();
            groupBoxKey.SuspendLayout();
            SuspendLayout();
            // 
            // richTextBoxInput
            // 
            richTextBoxInput.Font = new Font("Segoe UI", 12F);
            richTextBoxInput.Location = new Point(7, 29);
            richTextBoxInput.Margin = new Padding(3, 4, 3, 4);
            richTextBoxInput.Name = "richTextBoxInput";
            richTextBoxInput.Size = new Size(629, 259);
            richTextBoxInput.TabIndex = 0;
            richTextBoxInput.Text = "";
            // 
            // groupBoxInput
            // 
            groupBoxInput.Controls.Add(richTextBoxInput);
            groupBoxInput.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBoxInput.Location = new Point(12, 405);
            groupBoxInput.Margin = new Padding(3, 4, 3, 4);
            groupBoxInput.Name = "groupBoxInput";
            groupBoxInput.Padding = new Padding(3, 4, 3, 4);
            groupBoxInput.Size = new Size(643, 297);
            groupBoxInput.TabIndex = 2;
            groupBoxInput.TabStop = false;
            groupBoxInput.Text = "Input";
            // 
            // groupBoxOutput
            // 
            groupBoxOutput.Controls.Add(richTextBoxOutput);
            groupBoxOutput.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBoxOutput.Location = new Point(697, 405);
            groupBoxOutput.Margin = new Padding(3, 4, 3, 4);
            groupBoxOutput.Name = "groupBoxOutput";
            groupBoxOutput.Padding = new Padding(3, 4, 3, 4);
            groupBoxOutput.Size = new Size(633, 297);
            groupBoxOutput.TabIndex = 3;
            groupBoxOutput.TabStop = false;
            groupBoxOutput.Text = "Output";
            // 
            // richTextBoxOutput
            // 
            richTextBoxOutput.Font = new Font("Segoe UI", 12F);
            richTextBoxOutput.Location = new Point(7, 29);
            richTextBoxOutput.Margin = new Padding(3, 4, 3, 4);
            richTextBoxOutput.Name = "richTextBoxOutput";
            richTextBoxOutput.Size = new Size(619, 259);
            richTextBoxOutput.TabIndex = 0;
            richTextBoxOutput.Text = "";
            // 
            // richTextBoxPublic
            // 
            richTextBoxPublic.Font = new Font("Segoe UI", 12F);
            richTextBoxPublic.Location = new Point(18, 173);
            richTextBoxPublic.Margin = new Padding(3, 4, 3, 4);
            richTextBoxPublic.Name = "richTextBoxPublic";
            richTextBoxPublic.Size = new Size(626, 177);
            richTextBoxPublic.TabIndex = 4;
            richTextBoxPublic.Text = "";
            // 
            // richTextBoxPrivate
            // 
            richTextBoxPrivate.Font = new Font("Segoe UI", 12F);
            richTextBoxPrivate.Location = new Point(685, 169);
            richTextBoxPrivate.Margin = new Padding(3, 4, 3, 4);
            richTextBoxPrivate.Name = "richTextBoxPrivate";
            richTextBoxPrivate.Size = new Size(626, 177);
            richTextBoxPrivate.TabIndex = 5;
            richTextBoxPrivate.Text = "";
            // 
            // labelPublicKey
            // 
            labelPublicKey.AutoSize = true;
            labelPublicKey.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelPublicKey.Location = new Point(18, 141);
            labelPublicKey.Name = "labelPublicKey";
            labelPublicKey.Size = new Size(208, 28);
            labelPublicKey.TabIndex = 6;
            labelPublicKey.Text = "RSA Public Key (PEM)";
            // 
            // labelPrivateKey
            // 
            labelPrivateKey.AutoSize = true;
            labelPrivateKey.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelPrivateKey.Location = new Point(685, 137);
            labelPrivateKey.Name = "labelPrivateKey";
            labelPrivateKey.Size = new Size(215, 28);
            labelPrivateKey.TabIndex = 7;
            labelPrivateKey.Text = "RSA Private Key (PEM)";
            // 
            // comboBoxKeySize
            // 
            comboBoxKeySize.Font = new Font("Segoe UI", 12F);
            comboBoxKeySize.FormattingEnabled = true;
            comboBoxKeySize.Location = new Point(102, 37);
            comboBoxKeySize.Margin = new Padding(3, 4, 3, 4);
            comboBoxKeySize.Name = "comboBoxKeySize";
            comboBoxKeySize.Size = new Size(227, 36);
            comboBoxKeySize.TabIndex = 8;
            // 
            // labelKeySize
            // 
            labelKeySize.AutoSize = true;
            labelKeySize.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelKeySize.Location = new Point(18, 41);
            labelKeySize.Name = "labelKeySize";
            labelKeySize.Size = new Size(87, 28);
            labelKeySize.TabIndex = 9;
            labelKeySize.Text = "Key Size";
            // 
            // buttonOpenPublic
            // 
            buttonOpenPublic.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonOpenPublic.Location = new Point(437, 128);
            buttonOpenPublic.Margin = new Padding(3, 4, 3, 4);
            buttonOpenPublic.Name = "buttonOpenPublic";
            buttonOpenPublic.Size = new Size(101, 37);
            buttonOpenPublic.TabIndex = 10;
            buttonOpenPublic.Text = "Open";
            buttonOpenPublic.UseVisualStyleBackColor = true;
            buttonOpenPublic.Click += buttonOpenPublic_Click;
            // 
            // buttonOpenPrivate
            // 
            buttonOpenPrivate.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonOpenPrivate.Location = new Point(1104, 123);
            buttonOpenPrivate.Margin = new Padding(3, 4, 3, 4);
            buttonOpenPrivate.Name = "buttonOpenPrivate";
            buttonOpenPrivate.Size = new Size(101, 37);
            buttonOpenPrivate.TabIndex = 11;
            buttonOpenPrivate.Text = "Open";
            buttonOpenPrivate.UseVisualStyleBackColor = true;
            buttonOpenPrivate.Click += buttonOpenPrivate_Click;
            // 
            // buttonGenerate
            // 
            buttonGenerate.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonGenerate.Location = new Point(352, 59);
            buttonGenerate.Margin = new Padding(3, 4, 3, 4);
            buttonGenerate.Name = "buttonGenerate";
            buttonGenerate.Size = new Size(115, 39);
            buttonGenerate.TabIndex = 12;
            buttonGenerate.Text = "Generate";
            buttonGenerate.UseVisualStyleBackColor = true;
            buttonGenerate.Click += buttonGenerate_Click;
            // 
            // groupBoxKey
            // 
            groupBoxKey.Controls.Add(labelPadding);
            groupBoxKey.Controls.Add(comboBoxPadding);
            groupBoxKey.Controls.Add(buttonSavePrivate);
            groupBoxKey.Controls.Add(buttonSavePublic);
            groupBoxKey.Controls.Add(buttonImport);
            groupBoxKey.Controls.Add(richTextBoxPublic);
            groupBoxKey.Controls.Add(buttonGenerate);
            groupBoxKey.Controls.Add(richTextBoxPrivate);
            groupBoxKey.Controls.Add(buttonOpenPrivate);
            groupBoxKey.Controls.Add(labelPublicKey);
            groupBoxKey.Controls.Add(buttonOpenPublic);
            groupBoxKey.Controls.Add(labelPrivateKey);
            groupBoxKey.Controls.Add(labelKeySize);
            groupBoxKey.Controls.Add(comboBoxKeySize);
            groupBoxKey.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBoxKey.Location = new Point(12, 13);
            groupBoxKey.Margin = new Padding(3, 4, 3, 4);
            groupBoxKey.Name = "groupBoxKey";
            groupBoxKey.Padding = new Padding(3, 4, 3, 4);
            groupBoxKey.Size = new Size(1323, 369);
            groupBoxKey.TabIndex = 13;
            groupBoxKey.TabStop = false;
            groupBoxKey.Text = "Key";
            // 
            // labelPadding
            // 
            labelPadding.AutoSize = true;
            labelPadding.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelPadding.Location = new Point(18, 88);
            labelPadding.Name = "labelPadding";
            labelPadding.Size = new Size(86, 28);
            labelPadding.TabIndex = 20;
            labelPadding.Text = "Padding";
            // 
            // comboBoxPadding
            // 
            comboBoxPadding.Font = new Font("Segoe UI", 12F);
            comboBoxPadding.FormattingEnabled = true;
            comboBoxPadding.Location = new Point(102, 84);
            comboBoxPadding.Margin = new Padding(3, 4, 3, 4);
            comboBoxPadding.Name = "comboBoxPadding";
            comboBoxPadding.Size = new Size(227, 36);
            comboBoxPadding.TabIndex = 19;
            // 
            // buttonSavePrivate
            // 
            buttonSavePrivate.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonSavePrivate.Location = new Point(1211, 123);
            buttonSavePrivate.Margin = new Padding(3, 4, 3, 4);
            buttonSavePrivate.Name = "buttonSavePrivate";
            buttonSavePrivate.Size = new Size(101, 37);
            buttonSavePrivate.TabIndex = 18;
            buttonSavePrivate.Text = "Save";
            buttonSavePrivate.UseVisualStyleBackColor = true;
            buttonSavePrivate.Click += buttonSavePrivate_Click;
            // 
            // buttonSavePublic
            // 
            buttonSavePublic.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonSavePublic.Location = new Point(544, 128);
            buttonSavePublic.Margin = new Padding(3, 4, 3, 4);
            buttonSavePublic.Name = "buttonSavePublic";
            buttonSavePublic.Size = new Size(101, 37);
            buttonSavePublic.TabIndex = 17;
            buttonSavePublic.Text = "Save";
            buttonSavePublic.UseVisualStyleBackColor = true;
            buttonSavePublic.Click += buttonSavePublic_Click;
            // 
            // buttonImport
            // 
            buttonImport.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonImport.Location = new Point(491, 57);
            buttonImport.Margin = new Padding(3, 4, 3, 4);
            buttonImport.Name = "buttonImport";
            buttonImport.Size = new Size(101, 40);
            buttonImport.TabIndex = 13;
            buttonImport.Text = "Import";
            buttonImport.UseVisualStyleBackColor = true;
            buttonImport.Click += buttonImport_Click;
            // 
            // buttonReset
            // 
            buttonReset.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonReset.Location = new Point(798, 725);
            buttonReset.Margin = new Padding(3, 4, 3, 4);
            buttonReset.Name = "buttonReset";
            buttonReset.Size = new Size(102, 43);
            buttonReset.TabIndex = 14;
            buttonReset.Text = "Reset";
            buttonReset.UseVisualStyleBackColor = true;
            buttonReset.Click += buttonReset_Click;
            // 
            // buttonEncrypt
            // 
            buttonEncrypt.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonEncrypt.Location = new Point(947, 721);
            buttonEncrypt.Margin = new Padding(3, 4, 3, 4);
            buttonEncrypt.Name = "buttonEncrypt";
            buttonEncrypt.Size = new Size(101, 47);
            buttonEncrypt.TabIndex = 15;
            buttonEncrypt.Text = "Encrypt";
            buttonEncrypt.UseVisualStyleBackColor = true;
            buttonEncrypt.Click += buttonEncrypt_Click;
            // 
            // buttonDecrypt
            // 
            buttonDecrypt.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonDecrypt.Location = new Point(1072, 721);
            buttonDecrypt.Margin = new Padding(3, 4, 3, 4);
            buttonDecrypt.Name = "buttonDecrypt";
            buttonDecrypt.Size = new Size(101, 47);
            buttonDecrypt.TabIndex = 16;
            buttonDecrypt.Text = "Decrypt";
            buttonDecrypt.UseVisualStyleBackColor = true;
            buttonDecrypt.Click += buttonDecrypt_Click;
            // 
            // btn_exit
            // 
            btn_exit.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_exit.ForeColor = Color.Red;
            btn_exit.Location = new Point(1221, 721);
            btn_exit.Margin = new Padding(3, 4, 3, 4);
            btn_exit.Name = "btn_exit";
            btn_exit.Size = new Size(131, 47);
            btn_exit.TabIndex = 19;
            btn_exit.Text = "Exit";
            btn_exit.UseVisualStyleBackColor = true;
            btn_exit.Click += btn_exit_Click;
            // 
            // RSAForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1415, 793);
            Controls.Add(btn_exit);
            Controls.Add(buttonDecrypt);
            Controls.Add(buttonEncrypt);
            Controls.Add(buttonReset);
            Controls.Add(groupBoxKey);
            Controls.Add(groupBoxOutput);
            Controls.Add(groupBoxInput);
            Margin = new Padding(3, 4, 3, 4);
            Name = "RSAForm";
            Text = "RSA with PEM";
            FormClosed += RSAForm_FormClosed;
            Load += RSAForm_Load;
            groupBoxInput.ResumeLayout(false);
            groupBoxOutput.ResumeLayout(false);
            groupBoxKey.ResumeLayout(false);
            groupBoxKey.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox richTextBoxInput;
        private GroupBox groupBoxInput;
        private GroupBox groupBoxOutput;
        private RichTextBox richTextBoxOutput;
        private RichTextBox richTextBoxPublic;
        private RichTextBox richTextBoxPrivate;
        private Label labelPublicKey;
        private Label labelPrivateKey;
        private ComboBox comboBoxKeySize;
        private Label labelKeySize;
        private Button buttonOpenPublic;
        private Button buttonOpenPrivate;
        private Button buttonGenerate;
        private GroupBox groupBoxKey;
        private Button buttonImport;
        private Button buttonReset;
        private Button buttonEncrypt;
        private Button buttonDecrypt;
        private Button buttonSavePublic;
        private Button buttonSavePrivate;
        private Label labelPadding;
        private ComboBox comboBoxPadding;
        private Button btn_exit;
    }
}