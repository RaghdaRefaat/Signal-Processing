using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZedGraph;

namespace Package
{
    public partial class GraphSumOfSignals : Form
    {
        public GraphSumOfSignals()
        {
            InitializeComponent();
        }

        private void GraphSumOfSignals_Load(object sender, EventArgs e)
        {
            FirstTask f = new FirstTask();
            f.CreateGraph(zedGraphSum, FirstTask.sum, Color.Red);
        }
    }
}
