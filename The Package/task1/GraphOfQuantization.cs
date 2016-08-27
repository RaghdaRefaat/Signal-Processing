using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Package
{
    public partial class GraphOfQuantization : Form
    {
        public GraphOfQuantization()
        {
            InitializeComponent();
        }

        private void GraphOfQuantization_Load(object sender, EventArgs e)
        {
            FirstTask f = new FirstTask();
            f.CreateGraph(zedGraphControl1,Quantization.q_x, Color.Blue);
            zedGraphControl1.ClientSize = this.Size;
        }
    }
}
