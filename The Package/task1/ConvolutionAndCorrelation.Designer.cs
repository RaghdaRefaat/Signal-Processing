namespace Package
{
    partial class ConvolutionAndCorrelation
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
            this.cmboxOperations = new System.Windows.Forms.ComboBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.btnDone = new System.Windows.Forms.Button();
            this.rbtnPer = new System.Windows.Forms.CheckBox();
            this.normalRB = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14F);
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choose The  Operation";
            // 
            // cmboxOperations
            // 
            this.cmboxOperations.FormattingEnabled = true;
            this.cmboxOperations.Items.AddRange(new object[] {
            "Direct Covolution",
            "Direct Cross Correlation",
            "Direct Auto Correlation",
            "Fast Cross Correlation",
            "Fast Auto Correlation",
            "Fast Covolution"});
            this.cmboxOperations.Location = new System.Drawing.Point(49, 83);
            this.cmboxOperations.Name = "cmboxOperations";
            this.cmboxOperations.Size = new System.Drawing.Size(174, 21);
            this.cmboxOperations.TabIndex = 1;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(16, 182);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(99, 60);
            this.btnBrowse.TabIndex = 2;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // btnDone
            // 
            this.btnDone.Location = new System.Drawing.Point(178, 182);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(105, 60);
            this.btnDone.TabIndex = 3;
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // rbtnPer
            // 
            this.rbtnPer.AutoSize = true;
            this.rbtnPer.Location = new System.Drawing.Point(21, 138);
            this.rbtnPer.Name = "rbtnPer";
            this.rbtnPer.Size = new System.Drawing.Size(94, 17);
            this.rbtnPer.TabIndex = 8;
            this.rbtnPer.Text = "Periodic Signal";
            this.rbtnPer.UseVisualStyleBackColor = true;
            // 
            // normalRB
            // 
            this.normalRB.AutoSize = true;
            this.normalRB.Location = new System.Drawing.Point(178, 138);
            this.normalRB.Name = "normalRB";
            this.normalRB.Size = new System.Drawing.Size(90, 17);
            this.normalRB.TabIndex = 10;
            this.normalRB.Text = "Normal Signal";
            this.normalRB.UseVisualStyleBackColor = true;
            // 
            // ConvolutionAndCorrelation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 278);
            this.Controls.Add(this.normalRB);
            this.Controls.Add(this.rbtnPer);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.cmboxOperations);
            this.Controls.Add(this.label1);
            this.Name = "ConvolutionAndCorrelation";
            this.Text = "ConvolutionAndCorrelation";
            this.Load += new System.EventHandler(this.ConvolutionAndCorrelation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmboxOperations;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.CheckBox rbtnPer;
        private System.Windows.Forms.CheckBox normalRB;
    }
}