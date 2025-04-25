namespace VMT2VMAT_GUI
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.txtInput = new System.Windows.Forms.TextBox();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.btnBrowseInput = new System.Windows.Forms.Button();
            this.btnBrowseOutput = new System.Windows.Forms.Button();
            this.btnConvert = new System.Windows.Forms.Button();
            this.comboVMATVer = new System.Windows.Forms.ComboBox();
            this.comboTexExt = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(12, 20);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(400, 20);
            this.txtInput.TabIndex = 0;
            this.txtInput.TextChanged += new System.EventHandler(this.txtInput_TextChanged);
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(12, 58);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(400, 20);
            this.txtOutput.TabIndex = 1;
            this.txtOutput.TextChanged += new System.EventHandler(this.txtOutput_TextChanged);
            // 
            // txtLog
            // 
            this.txtLog.Location = new System.Drawing.Point(12, 131);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ReadOnly = true;
            this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLog.Size = new System.Drawing.Size(480, 150);
            this.txtLog.TabIndex = 2;
            // 
            // btnBrowseInput
            // 
            this.btnBrowseInput.Location = new System.Drawing.Point(420, 17);
            this.btnBrowseInput.Name = "btnBrowseInput";
            this.btnBrowseInput.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseInput.TabIndex = 3;
            this.btnBrowseInput.Text = "VMT File";
            this.btnBrowseInput.UseVisualStyleBackColor = true;
            this.btnBrowseInput.Click += new System.EventHandler(this.btnBrowseInput_Click);
            // 
            // btnBrowseOutput
            // 
            this.btnBrowseOutput.Location = new System.Drawing.Point(420, 55);
            this.btnBrowseOutput.Name = "btnBrowseOutput";
            this.btnBrowseOutput.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseOutput.TabIndex = 5;
            this.btnBrowseOutput.Text = "Output";
            this.btnBrowseOutput.UseVisualStyleBackColor = true;
            this.btnBrowseOutput.Click += new System.EventHandler(this.btnBrowseOutput_Click);
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(417, 93);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(75, 23);
            this.btnConvert.TabIndex = 6;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // comboVMATVer
            // 
            this.comboVMATVer.FormattingEnabled = true;
            this.comboVMATVer.Items.AddRange(new object[] {
            "Half-Life: Alyx",
            "Counter-Strike 2",
            "S&box"});
            this.comboVMATVer.Location = new System.Drawing.Point(12, 95);
            this.comboVMATVer.Name = "comboVMATVer";
            this.comboVMATVer.Size = new System.Drawing.Size(121, 21);
            this.comboVMATVer.TabIndex = 7;
            this.comboVMATVer.Text = "VMAT Version";
            this.comboVMATVer.SelectedIndexChanged += new System.EventHandler(this.comboVMATVer_SelectedIndexChanged);
            // 
            // comboTexExt
            // 
            this.comboTexExt.FormattingEnabled = true;
            this.comboTexExt.Items.AddRange(new object[] {
            "PNG",
            "TGA",
            "JPG"});
            this.comboTexExt.Location = new System.Drawing.Point(139, 95);
            this.comboTexExt.Name = "comboTexExt";
            this.comboTexExt.Size = new System.Drawing.Size(126, 21);
            this.comboTexExt.TabIndex = 8;
            this.comboTexExt.Text = "Texture File Extension";
            this.comboTexExt.SelectedIndexChanged += new System.EventHandler(this.comboTexExt_SelectedIndexChanged);
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(510, 301);
            this.Controls.Add(this.comboTexExt);
            this.Controls.Add(this.comboVMATVer);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.btnBrowseOutput);
            this.Controls.Add(this.btnBrowseInput);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.txtInput);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "VMT2VMAT";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.Button btnBrowseInput;
        private System.Windows.Forms.Button btnBrowseOutput;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.ComboBox comboVMATVer;
        private System.Windows.Forms.ComboBox comboTexExt;
    }
}