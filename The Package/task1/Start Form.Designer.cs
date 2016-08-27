namespace Package
{
    partial class Start_Form
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
            this.btnTask1 = new System.Windows.Forms.Button();
            this.btnQuantization = new System.Windows.Forms.Button();
            this.btnFourier = new System.Windows.Forms.Button();
            this.btnInverse = new System.Windows.Forms.Button();
            this.btnFastFourier = new System.Windows.Forms.Button();
            this.btnSignalsOperations = new System.Windows.Forms.Button();
            this.btnCovolution = new System.Windows.Forms.Button();
            this.btnIFFT = new System.Windows.Forms.Button();
            this.btnFIR = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(420, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome In Our Package";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnTask1
            // 
            this.btnTask1.Location = new System.Drawing.Point(117, 73);
            this.btnTask1.Name = "btnTask1";
            this.btnTask1.Size = new System.Drawing.Size(166, 36);
            this.btnTask1.TabIndex = 1;
            this.btnTask1.Text = "First Task";
            this.btnTask1.UseVisualStyleBackColor = true;
            this.btnTask1.Click += new System.EventHandler(this.btnTask1_Click);
            // 
            // btnQuantization
            // 
            this.btnQuantization.Location = new System.Drawing.Point(117, 115);
            this.btnQuantization.Name = "btnQuantization";
            this.btnQuantization.Size = new System.Drawing.Size(166, 36);
            this.btnQuantization.TabIndex = 2;
            this.btnQuantization.Text = "Quantization";
            this.btnQuantization.UseVisualStyleBackColor = true;
            this.btnQuantization.Click += new System.EventHandler(this.btnQuantization_Click);
            // 
            // btnFourier
            // 
            this.btnFourier.Location = new System.Drawing.Point(117, 157);
            this.btnFourier.Name = "btnFourier";
            this.btnFourier.Size = new System.Drawing.Size(166, 36);
            this.btnFourier.TabIndex = 3;
            this.btnFourier.Text = "Fourier Transform";
            this.btnFourier.UseVisualStyleBackColor = true;
            this.btnFourier.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnInverse
            // 
            this.btnInverse.Location = new System.Drawing.Point(117, 199);
            this.btnInverse.Name = "btnInverse";
            this.btnInverse.Size = new System.Drawing.Size(166, 36);
            this.btnInverse.TabIndex = 4;
            this.btnInverse.Text = "Inverse Fourier Transform";
            this.btnInverse.UseVisualStyleBackColor = true;
            this.btnInverse.Click += new System.EventHandler(this.btnInverse_Click);
            // 
            // btnFastFourier
            // 
            this.btnFastFourier.Location = new System.Drawing.Point(117, 241);
            this.btnFastFourier.Name = "btnFastFourier";
            this.btnFastFourier.Size = new System.Drawing.Size(166, 36);
            this.btnFastFourier.TabIndex = 5;
            this.btnFastFourier.Text = "Fast Fourier Transform";
            this.btnFastFourier.UseVisualStyleBackColor = true;
            this.btnFastFourier.Click += new System.EventHandler(this.btnFastFourier_Click);
            // 
            // btnSignalsOperations
            // 
            this.btnSignalsOperations.Location = new System.Drawing.Point(117, 325);
            this.btnSignalsOperations.Name = "btnSignalsOperations";
            this.btnSignalsOperations.Size = new System.Drawing.Size(166, 36);
            this.btnSignalsOperations.TabIndex = 6;
            this.btnSignalsOperations.Text = "Signal\'s Operations";
            this.btnSignalsOperations.UseVisualStyleBackColor = true;
            this.btnSignalsOperations.Click += new System.EventHandler(this.btnSignalsOperations_Click);
            // 
            // btnCovolution
            // 
            this.btnCovolution.Location = new System.Drawing.Point(117, 367);
            this.btnCovolution.Name = "btnCovolution";
            this.btnCovolution.Size = new System.Drawing.Size(166, 36);
            this.btnCovolution.TabIndex = 7;
            this.btnCovolution.Text = "Convolution And  Correlation";
            this.btnCovolution.UseVisualStyleBackColor = true;
            this.btnCovolution.Click += new System.EventHandler(this.btnCovolution_Click);
            // 
            // btnIFFT
            // 
            this.btnIFFT.Location = new System.Drawing.Point(117, 283);
            this.btnIFFT.Name = "btnIFFT";
            this.btnIFFT.Size = new System.Drawing.Size(166, 36);
            this.btnIFFT.TabIndex = 8;
            this.btnIFFT.Text = "Inverse Fast Fourier Transform";
            this.btnIFFT.UseVisualStyleBackColor = true;
            this.btnIFFT.Click += new System.EventHandler(this.btnIFFT_Click);
            // 
            // btnFIR
            // 
            this.btnFIR.Location = new System.Drawing.Point(117, 409);
            this.btnFIR.Name = "btnFIR";
            this.btnFIR.Size = new System.Drawing.Size(166, 36);
            this.btnFIR.TabIndex = 9;
            this.btnFIR.Text = "FIR";
            this.btnFIR.UseVisualStyleBackColor = true;
            this.btnFIR.Click += new System.EventHandler(this.btnFIR_Click);
            // 
            // Start_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 461);
            this.Controls.Add(this.btnFIR);
            this.Controls.Add(this.btnIFFT);
            this.Controls.Add(this.btnCovolution);
            this.Controls.Add(this.btnSignalsOperations);
            this.Controls.Add(this.btnFastFourier);
            this.Controls.Add(this.btnInverse);
            this.Controls.Add(this.btnFourier);
            this.Controls.Add(this.btnQuantization);
            this.Controls.Add(this.btnTask1);
            this.Controls.Add(this.label1);
            this.Name = "Start_Form";
            this.Text = "Start_Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTask1;
        private System.Windows.Forms.Button btnQuantization;
        private System.Windows.Forms.Button btnFourier;
        private System.Windows.Forms.Button btnInverse;
        private System.Windows.Forms.Button btnFastFourier;
        private System.Windows.Forms.Button btnSignalsOperations;
        private System.Windows.Forms.Button btnCovolution;
        private System.Windows.Forms.Button btnIFFT;
        private System.Windows.Forms.Button btnFIR;
    }
}