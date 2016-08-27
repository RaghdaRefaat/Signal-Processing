namespace Package
{
    partial class Quantization
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
            this.quantDGV = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.levels = new System.Windows.Forms.Label();
            this.txtLevels = new System.Windows.Forms.TextBox();
            this.btnQuantization = new System.Windows.Forms.Button();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.quantDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // quantDGV
            // 
            this.quantDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.quantDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.col4,
            this.Column4});
            this.quantDGV.Location = new System.Drawing.Point(12, 12);
            this.quantDGV.Name = "quantDGV";
            this.quantDGV.Size = new System.Drawing.Size(545, 391);
            this.quantDGV.TabIndex = 13;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "n";
            this.Column1.Name = "Column1";
            this.Column1.Width = 50;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "x(n)";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "interval";
            this.Column3.Name = "Column3";
            // 
            // col4
            // 
            this.col4.HeaderText = "midpoints";
            this.col4.Name = "col4";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "eq(n) = q(n)-x(n)";
            this.Column4.Name = "Column4";
            this.Column4.Width = 150;
            // 
            // levels
            // 
            this.levels.AutoSize = true;
            this.levels.Location = new System.Drawing.Point(22, 444);
            this.levels.Name = "levels";
            this.levels.Size = new System.Drawing.Size(34, 13);
            this.levels.TabIndex = 16;
            this.levels.Text = "levels";
            // 
            // txtLevels
            // 
            this.txtLevels.Location = new System.Drawing.Point(62, 441);
            this.txtLevels.Name = "txtLevels";
            this.txtLevels.Size = new System.Drawing.Size(71, 20);
            this.txtLevels.TabIndex = 14;
            // 
            // btnQuantization
            // 
            this.btnQuantization.Location = new System.Drawing.Point(290, 422);
            this.btnQuantization.Name = "btnQuantization";
            this.btnQuantization.Size = new System.Drawing.Size(122, 49);
            this.btnQuantization.TabIndex = 18;
            this.btnQuantization.Text = "Do A Quantization\r\n";
            this.btnQuantization.UseVisualStyleBackColor = true;
            this.btnQuantization.Click += new System.EventHandler(this.btnQuantization_Click);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(150, 422);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(122, 49);
            this.btnBrowse.TabIndex = 20;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(435, 422);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 49);
            this.button1.TabIndex = 21;
            this.button1.Text = "Draw The Quantized Signal";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Quantization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 483);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.btnQuantization);
            this.Controls.Add(this.levels);
            this.Controls.Add(this.txtLevels);
            this.Controls.Add(this.quantDGV);
            this.Name = "Quantization";
            this.Text = "Quantization";
            this.Load += new System.EventHandler(this.Quantization_Load);
            ((System.ComponentModel.ISupportInitialize)(this.quantDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView quantDGV;
        private System.Windows.Forms.Label levels;
        private System.Windows.Forms.TextBox txtLevels;
        private System.Windows.Forms.Button btnQuantization;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn col4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Button button1;
    }
}