namespace Package
{
    partial class FastFourier
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
            this.btnDone = new System.Windows.Forms.Button();
            this.txtTimeFourier = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnThetaGraph = new System.Windows.Forms.Button();
            this.btnAmplitudeGraph = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFs = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDone
            // 
            this.btnDone.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.btnDone.Location = new System.Drawing.Point(371, 128);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(102, 48);
            this.btnDone.TabIndex = 21;
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // txtTimeFourier
            // 
            this.txtTimeFourier.Location = new System.Drawing.Point(270, 313);
            this.txtTimeFourier.Name = "txtTimeFourier";
            this.txtTimeFourier.Size = new System.Drawing.Size(100, 20);
            this.txtTimeFourier.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label5.Location = new System.Drawing.Point(44, 314);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(216, 17);
            this.label5.TabIndex = 19;
            this.label5.Text = "The Time Of Fast Fourier Trasform";
            // 
            // btnThetaGraph
            // 
            this.btnThetaGraph.Location = new System.Drawing.Point(270, 235);
            this.btnThetaGraph.Name = "btnThetaGraph";
            this.btnThetaGraph.Size = new System.Drawing.Size(100, 50);
            this.btnThetaGraph.TabIndex = 18;
            this.btnThetaGraph.Text = "Segma V.S Theta";
            this.btnThetaGraph.UseVisualStyleBackColor = true;
            this.btnThetaGraph.Click += new System.EventHandler(this.btnThetaGraph_Click);
            // 
            // btnAmplitudeGraph
            // 
            this.btnAmplitudeGraph.Location = new System.Drawing.Point(84, 235);
            this.btnAmplitudeGraph.Name = "btnAmplitudeGraph";
            this.btnAmplitudeGraph.Size = new System.Drawing.Size(102, 50);
            this.btnAmplitudeGraph.TabIndex = 17;
            this.btnAmplitudeGraph.Text = "Segma V.S Amplitude";
            this.btnAmplitudeGraph.UseVisualStyleBackColor = true;
            this.btnAmplitudeGraph.Click += new System.EventHandler(this.btnAmplitudeGraph_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(24, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 17);
            this.label4.TabIndex = 16;
            this.label4.Text = "The Outputs";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label3.Location = new System.Drawing.Point(243, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "Fs";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label2.Location = new System.Drawing.Point(44, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "X(n)";
            // 
            // txtFs
            // 
            this.txtFs.Location = new System.Drawing.Point(270, 80);
            this.txtFs.Name = "txtFs";
            this.txtFs.Size = new System.Drawing.Size(100, 20);
            this.txtFs.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(24, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "The Inputs";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(84, 70);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(102, 48);
            this.btnBrowse.TabIndex = 11;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // FastFourier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 381);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.txtTimeFourier);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnThetaGraph);
            this.Controls.Add(this.btnAmplitudeGraph);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFs);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBrowse);
            this.Name = "FastFourier";
            this.Text = "FastFourier";
            this.Load += new System.EventHandler(this.FastFourier_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.TextBox txtTimeFourier;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnThetaGraph;
        private System.Windows.Forms.Button btnAmplitudeGraph;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBrowse;
    }
}