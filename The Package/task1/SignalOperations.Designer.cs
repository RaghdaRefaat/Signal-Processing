namespace Package
{
    partial class SignalOperations
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
            this.addBtn = new System.Windows.Forms.Button();
            this.multiBtn = new System.Windows.Forms.Button();
            this.multiConstantBtn = new System.Windows.Forms.Button();
            this.foldBtn = new System.Windows.Forms.Button();
            this.shiftBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMulConstant = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtConstantShift = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select An Operation :";
            // 
            // addBtn
            // 
            this.addBtn.Font = new System.Drawing.Font("Tahoma", 8F);
            this.addBtn.Location = new System.Drawing.Point(71, 43);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(104, 40);
            this.addBtn.TabIndex = 4;
            this.addBtn.Text = "Add 2 Signals";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // multiBtn
            // 
            this.multiBtn.Font = new System.Drawing.Font("Tahoma", 8F);
            this.multiBtn.Location = new System.Drawing.Point(71, 89);
            this.multiBtn.Name = "multiBtn";
            this.multiBtn.Size = new System.Drawing.Size(104, 40);
            this.multiBtn.TabIndex = 5;
            this.multiBtn.Text = "Multiply 2 Signals";
            this.multiBtn.UseVisualStyleBackColor = true;
            this.multiBtn.Click += new System.EventHandler(this.multiBtn_Click);
            // 
            // multiConstantBtn
            // 
            this.multiConstantBtn.Font = new System.Drawing.Font("Tahoma", 8F);
            this.multiConstantBtn.Location = new System.Drawing.Point(71, 135);
            this.multiConstantBtn.Name = "multiConstantBtn";
            this.multiConstantBtn.Size = new System.Drawing.Size(104, 40);
            this.multiConstantBtn.TabIndex = 6;
            this.multiConstantBtn.Text = "Multiply Signal By Constant";
            this.multiConstantBtn.UseVisualStyleBackColor = true;
            this.multiConstantBtn.Click += new System.EventHandler(this.multiConstantBtn_Click);
            // 
            // foldBtn
            // 
            this.foldBtn.Font = new System.Drawing.Font("Tahoma", 8F);
            this.foldBtn.Location = new System.Drawing.Point(71, 181);
            this.foldBtn.Name = "foldBtn";
            this.foldBtn.Size = new System.Drawing.Size(104, 40);
            this.foldBtn.TabIndex = 7;
            this.foldBtn.Text = "Fold A Signal";
            this.foldBtn.UseVisualStyleBackColor = true;
            this.foldBtn.Click += new System.EventHandler(this.foldBtn_Click);
            // 
            // shiftBtn
            // 
            this.shiftBtn.Font = new System.Drawing.Font("Tahoma", 8F);
            this.shiftBtn.Location = new System.Drawing.Point(71, 227);
            this.shiftBtn.Name = "shiftBtn";
            this.shiftBtn.Size = new System.Drawing.Size(104, 40);
            this.shiftBtn.TabIndex = 8;
            this.shiftBtn.Text = "Shift A Signal By Constant";
            this.shiftBtn.UseVisualStyleBackColor = true;
            this.shiftBtn.Click += new System.EventHandler(this.shiftBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(201, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Enter The Constant";
            // 
            // txtMulConstant
            // 
            this.txtMulConstant.Location = new System.Drawing.Point(308, 149);
            this.txtMulConstant.Name = "txtMulConstant";
            this.txtMulConstant.Size = new System.Drawing.Size(55, 20);
            this.txtMulConstant.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(201, 241);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Enter The Constant";
            // 
            // txtConstantShift
            // 
            this.txtConstantShift.Location = new System.Drawing.Point(308, 238);
            this.txtConstantShift.Name = "txtConstantShift";
            this.txtConstantShift.Size = new System.Drawing.Size(55, 20);
            this.txtConstantShift.TabIndex = 14;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Font = new System.Drawing.Font("Tahoma", 8F);
            this.btnBrowse.Location = new System.Drawing.Point(236, 43);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(104, 40);
            this.btnBrowse.TabIndex = 17;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // SignalOperations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 306);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.txtConstantShift);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMulConstant);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.shiftBtn);
            this.Controls.Add(this.foldBtn);
            this.Controls.Add(this.multiConstantBtn);
            this.Controls.Add(this.multiBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.label1);
            this.Name = "SignalOperations";
            this.Text = "SignalOperations";
            this.Load += new System.EventHandler(this.SignalOperations_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button multiBtn;
        private System.Windows.Forms.Button multiConstantBtn;
        private System.Windows.Forms.Button foldBtn;
        private System.Windows.Forms.Button shiftBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMulConstant;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtConstantShift;
        private System.Windows.Forms.Button btnBrowse;
    }
}