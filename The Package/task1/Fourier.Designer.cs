namespace Package
{
    partial class Fourier
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
            this.btnBrowse = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFs = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAmplitudeGraph = new System.Windows.Forms.Button();
            this.btnThetaGraph = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTimeFourier = new System.Windows.Forms.TextBox();
            this.btnDone = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(72, 38);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(102, 48);
            this.btnBrowse.TabIndex = 0;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "The Inputs";
            // 
            // txtFs
            // 
            this.txtFs.Location = new System.Drawing.Point(258, 48);
            this.txtFs.Name = "txtFs";
            this.txtFs.Size = new System.Drawing.Size(100, 20);
            this.txtFs.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label2.Location = new System.Drawing.Point(32, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "X(n)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label3.Location = new System.Drawing.Point(231, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Fs";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(12, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "The Outputs";
            // 
            // btnAmplitudeGraph
            // 
            this.btnAmplitudeGraph.Location = new System.Drawing.Point(72, 203);
            this.btnAmplitudeGraph.Name = "btnAmplitudeGraph";
            this.btnAmplitudeGraph.Size = new System.Drawing.Size(102, 50);
            this.btnAmplitudeGraph.TabIndex = 6;
            this.btnAmplitudeGraph.Text = "Segma V.S Amplitude";
            this.btnAmplitudeGraph.UseVisualStyleBackColor = true;
            this.btnAmplitudeGraph.Click += new System.EventHandler(this.btnAmplitudeGraph_Click);
            // 
            // btnThetaGraph
            // 
            this.btnThetaGraph.Location = new System.Drawing.Point(258, 203);
            this.btnThetaGraph.Name = "btnThetaGraph";
            this.btnThetaGraph.Size = new System.Drawing.Size(100, 50);
            this.btnThetaGraph.TabIndex = 7;
            this.btnThetaGraph.Text = "Segma V.S Theta";
            this.btnThetaGraph.UseVisualStyleBackColor = true;
            this.btnThetaGraph.Click += new System.EventHandler(this.btnThetaGraph_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label5.Location = new System.Drawing.Point(32, 282);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(187, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "The Time Of Fourier Trasform";
            // 
            // txtTimeFourier
            // 
            this.txtTimeFourier.Location = new System.Drawing.Point(258, 281);
            this.txtTimeFourier.Name = "txtTimeFourier";
            this.txtTimeFourier.Size = new System.Drawing.Size(100, 20);
            this.txtTimeFourier.TabIndex = 9;
            // 
            // btnDone
            // 
            this.btnDone.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.btnDone.Location = new System.Drawing.Point(359, 96);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(102, 48);
            this.btnDone.TabIndex = 10;
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // Fourier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 349);
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
            this.Name = "Fourier";
            this.Text = "Fourier";
            this.Load += new System.EventHandler(this.Fourier_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFs;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAmplitudeGraph;
        private System.Windows.Forms.Button btnThetaGraph;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTimeFourier;
        private System.Windows.Forms.Button btnDone;

    }
}