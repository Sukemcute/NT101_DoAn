namespace NT101_PJ.UI
{
    partial class ChooseRSA
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
            button1 = new Button();
            btnRSAPem = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(80, 124);
            button1.Name = "button1";
            button1.Size = new Size(176, 104);
            button1.TabIndex = 0;
            button1.Text = "RSA";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnRSAwKey_Click;
            // 
            // btnRSAPem
            // 
            btnRSAPem.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRSAPem.Location = new Point(312, 124);
            btnRSAPem.Name = "btnRSAPem";
            btnRSAPem.Size = new Size(176, 104);
            btnRSAPem.TabIndex = 1;
            btnRSAPem.Text = "RSA with PEM";
            btnRSAPem.UseVisualStyleBackColor = true;
            btnRSAPem.Click += btnRSAPem_Click;
            // 
            // ChooseRSA
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(566, 359);
            Controls.Add(btnRSAPem);
            Controls.Add(button1);
            Name = "ChooseRSA";
            Text = "ChooseRSA";
            FormClosed += ChooseRSA_FormClosed;
            Load += ChooseRSA_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button btnRSAPem;
    }
}