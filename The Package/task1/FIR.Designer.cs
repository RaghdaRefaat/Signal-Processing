namespace Package
{
    partial class FIR
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txtboxFC1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxFC2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxTransitionWidth = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBoxStopbandAttenuation = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBoxSamplingFrequency = new System.Windows.Forms.TextBox();
            this.btnDone = new System.Windows.Forms.Button();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbuttonUpSampling = new System.Windows.Forms.RadioButton();
            this.rbuttonDownSampling = new System.Windows.Forms.RadioButton();
            this.rbuttonUpDownSampling = new System.Windows.Forms.RadioButton();
            this.txtBoxUpSampling = new System.Windows.Forms.TextBox();
            this.txtBoxDownSampling = new System.Windows.Forms.TextBox();
            this.txt2DownSampling = new System.Windows.Forms.TextBox();
            this.txt1UpSampling = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "The Type Of The Filter";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Low Pass Filter",
            "High Pass Filter",
            "Band Pass Filter",
            "Band Reject Filter"});
            this.comboBox1.Location = new System.Drawing.Point(143, 19);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // txtboxFC1
            // 
            this.txtboxFC1.Location = new System.Drawing.Point(143, 73);
            this.txtboxFC1.Name = "txtboxFC1";
            this.txtboxFC1.Size = new System.Drawing.Size(43, 20);
            this.txtboxFC1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Cut Off Frequency";
            // 
            // txtBoxFC2
            // 
            this.txtBoxFC2.Location = new System.Drawing.Point(221, 73);
            this.txtBoxFC2.Name = "txtBoxFC2";
            this.txtBoxFC2.Size = new System.Drawing.Size(43, 20);
            this.txtBoxFC2.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Transition Width";
            // 
            // txtBoxTransitionWidth
            // 
            this.txtBoxTransitionWidth.Location = new System.Drawing.Point(143, 124);
            this.txtBoxTransitionWidth.Name = "txtBoxTransitionWidth";
            this.txtBoxTransitionWidth.Size = new System.Drawing.Size(121, 20);
            this.txtBoxTransitionWidth.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Stopband Attenuation";
            // 
            // txtBoxStopbandAttenuation
            // 
            this.txtBoxStopbandAttenuation.Location = new System.Drawing.Point(143, 169);
            this.txtBoxStopbandAttenuation.Name = "txtBoxStopbandAttenuation";
            this.txtBoxStopbandAttenuation.Size = new System.Drawing.Size(121, 20);
            this.txtBoxStopbandAttenuation.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Sampling Frequency";
            // 
            // txtBoxSamplingFrequency
            // 
            this.txtBoxSamplingFrequency.Location = new System.Drawing.Point(143, 216);
            this.txtBoxSamplingFrequency.Name = "txtBoxSamplingFrequency";
            this.txtBoxSamplingFrequency.Size = new System.Drawing.Size(121, 20);
            this.txtBoxSamplingFrequency.TabIndex = 11;
            // 
            // btnDone
            // 
            this.btnDone.Location = new System.Drawing.Point(15, 254);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(119, 54);
            this.btnDone.TabIndex = 12;
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(158, 254);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(119, 54);
            this.btnBrowse.TabIndex = 13;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt1UpSampling);
            this.groupBox1.Controls.Add(this.txt2DownSampling);
            this.groupBox1.Controls.Add(this.txtBoxDownSampling);
            this.groupBox1.Controls.Add(this.txtBoxUpSampling);
            this.groupBox1.Controls.Add(this.rbuttonUpDownSampling);
            this.groupBox1.Controls.Add(this.rbuttonDownSampling);
            this.groupBox1.Controls.Add(this.rbuttonUpSampling);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 14F);
            this.groupBox1.Location = new System.Drawing.Point(283, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(306, 289);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sampling Theory";
            // 
            // rbuttonUpSampling
            // 
            this.rbuttonUpSampling.AutoSize = true;
            this.rbuttonUpSampling.Location = new System.Drawing.Point(26, 57);
            this.rbuttonUpSampling.Name = "rbuttonUpSampling";
            this.rbuttonUpSampling.Size = new System.Drawing.Size(135, 27);
            this.rbuttonUpSampling.TabIndex = 15;
            this.rbuttonUpSampling.TabStop = true;
            this.rbuttonUpSampling.Text = "Up Sampling";
            this.rbuttonUpSampling.UseVisualStyleBackColor = true;
            // 
            // rbuttonDownSampling
            // 
            this.rbuttonDownSampling.AutoSize = true;
            this.rbuttonDownSampling.Location = new System.Drawing.Point(26, 105);
            this.rbuttonDownSampling.Name = "rbuttonDownSampling";
            this.rbuttonDownSampling.Size = new System.Drawing.Size(160, 27);
            this.rbuttonDownSampling.TabIndex = 16;
            this.rbuttonDownSampling.TabStop = true;
            this.rbuttonDownSampling.Text = "Down Sampling";
            this.rbuttonDownSampling.UseVisualStyleBackColor = true;
            // 
            // rbuttonUpDownSampling
            // 
            this.rbuttonUpDownSampling.AutoSize = true;
            this.rbuttonUpDownSampling.Location = new System.Drawing.Point(26, 153);
            this.rbuttonUpDownSampling.Name = "rbuttonUpDownSampling";
            this.rbuttonUpDownSampling.Size = new System.Drawing.Size(228, 27);
            this.rbuttonUpDownSampling.TabIndex = 17;
            this.rbuttonUpDownSampling.TabStop = true;
            this.rbuttonUpDownSampling.Text = "Up And Down Sampling";
            this.rbuttonUpDownSampling.UseVisualStyleBackColor = true;
            // 
            // txtBoxUpSampling
            // 
            this.txtBoxUpSampling.Location = new System.Drawing.Point(230, 56);
            this.txtBoxUpSampling.Name = "txtBoxUpSampling";
            this.txtBoxUpSampling.Size = new System.Drawing.Size(43, 30);
            this.txtBoxUpSampling.TabIndex = 18;
            // 
            // txtBoxDownSampling
            // 
            this.txtBoxDownSampling.Location = new System.Drawing.Point(230, 102);
            this.txtBoxDownSampling.Name = "txtBoxDownSampling";
            this.txtBoxDownSampling.Size = new System.Drawing.Size(43, 30);
            this.txtBoxDownSampling.TabIndex = 19;
            // 
            // txt2DownSampling
            // 
            this.txt2DownSampling.Location = new System.Drawing.Point(191, 200);
            this.txt2DownSampling.Name = "txt2DownSampling";
            this.txt2DownSampling.Size = new System.Drawing.Size(43, 30);
            this.txt2DownSampling.TabIndex = 20;
            // 
            // txt1UpSampling
            // 
            this.txt1UpSampling.Location = new System.Drawing.Point(72, 200);
            this.txt1UpSampling.Name = "txt1UpSampling";
            this.txt1UpSampling.Size = new System.Drawing.Size(43, 30);
            this.txt1UpSampling.TabIndex = 21;
            // 
            // FIR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 326);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.txtBoxSamplingFrequency);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtBoxStopbandAttenuation);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBoxTransitionWidth);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBoxFC2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtboxFC1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Name = "FIR";
            this.Text = "FIR";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox txtboxFC1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxFC2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBoxTransitionWidth;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBoxStopbandAttenuation;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBoxSamplingFrequency;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt1UpSampling;
        private System.Windows.Forms.TextBox txt2DownSampling;
        private System.Windows.Forms.TextBox txtBoxDownSampling;
        private System.Windows.Forms.TextBox txtBoxUpSampling;
        private System.Windows.Forms.RadioButton rbuttonUpDownSampling;
        private System.Windows.Forms.RadioButton rbuttonDownSampling;
        private System.Windows.Forms.RadioButton rbuttonUpSampling;
    }
}