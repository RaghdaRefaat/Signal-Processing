namespace Package
{
    partial class GraphSumOfSignals
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
            this.zedGraphSum = new ZedGraph.ZedGraphControl();
            this.SuspendLayout();
            // 
            // zedGraphSum
            // 
            this.zedGraphSum.IsShowPointValues = false;
            this.zedGraphSum.Location = new System.Drawing.Point(12, 12);
            this.zedGraphSum.Name = "zedGraphSum";
            this.zedGraphSum.PointValueFormat = "G";
            this.zedGraphSum.Size = new System.Drawing.Size(540, 305);
            this.zedGraphSum.TabIndex = 0;
            // 
            // SumOfSignals
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 329);
            this.Controls.Add(this.zedGraphSum);
            this.Name = "SumOfSignals";
            this.Text = "SumOfSignals";
            this.Load += new System.EventHandler(this.GraphSumOfSignals_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ZedGraph.ZedGraphControl zedGraphSum;
    }
}